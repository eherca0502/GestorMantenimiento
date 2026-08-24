using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GestorMantenimiento.Models;
using GestorMantenimiento.Data;

namespace GestorMantenimiento
{
    public partial class GarantiasForm : Form
    {
        private readonly EquipoDAO equipoDAO;

        private List<Equipo> equipos;

        public GarantiasForm()
        {
            InitializeComponent();

            equipoDAO = new EquipoDAO();

            CargarGarantias();
        }


        private void CargarGarantias()
        {
            try
            {
                equipos = equipoDAO.ObtenerGarantias();

                MostrarGarantias(equipos);

                ActualizarContadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las garantías.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void MostrarGarantias(
            List<Equipo> lista)
        {
            dgvGarantias.Rows.Clear();

            foreach (Equipo equipo in lista)
            {
                string estadoGarantia =
                    ObtenerEstadoGarantia(
                        equipo.FechaGarantia);

                int diasRestantes =
                    ObtenerDiasRestantes(
                        equipo.FechaGarantia);

                string textoDias;

                if (diasRestantes < 0)
                {
                    textoDias =
                        "Vencida";
                }
                else if (diasRestantes == 0)
                {
                    textoDias =
                        "Vence hoy";
                }
                else
                {
                    textoDias =
                        diasRestantes + " días";
                }

                dgvGarantias.Rows.Add(
                    equipo.Id,
                    equipo.Codigo,
                    equipo.Tipo,
                    equipo.Marca,
                    equipo.Modelo,
                    equipo.FechaGarantia.HasValue
                        ? equipo.FechaGarantia.Value
                            .ToString("dd/MM/yyyy")
                        : "",
                    textoDias,
                    estadoGarantia);
            }

            ColorearFilas();
        }



        private string ObtenerEstadoGarantia(
            DateTime? fecha)
        {
            if (!fecha.HasValue)
                return "Sin garantía";

            DateTime hoy =
                DateTime.Today;

            if (fecha.Value.Date < hoy)
                return "Vencida";

            if (fecha.Value.Date == hoy)
                return "Vence hoy";

            if (fecha.Value.Date <=
                hoy.AddDays(30))
                return "Por vencer";

            return "Vigente";
        }


        private int ObtenerDiasRestantes(
            DateTime? fecha)
        {
            if (!fecha.HasValue)
                return -1;

            return (
                fecha.Value.Date -
                DateTime.Today).Days;
        }


        private void ActualizarContadores()
        {
            int vigentes = 0;
            int porVencer = 0;
            int vencidas = 0;

            foreach (Equipo equipo in equipos)
            {
                string estado =
                    ObtenerEstadoGarantia(
                        equipo.FechaGarantia);

                if (estado == "Vigente")
                    vigentes++;

                else if (estado == "Por vencer")
                    porVencer++;

                else if (estado == "Vencida" ||
                         estado == "Vence hoy")
                    vencidas++;
            }

            lblNumeroVigentes.Text =
                vigentes.ToString();

            lblNumeroPorVencer.Text =
                porVencer.ToString();

            lblNumeroVencidas.Text =
                vencidas.ToString();
        }



        private void ColorearFilas()
        {
            foreach (DataGridViewRow fila
                in dgvGarantias.Rows)
            {
                if (fila.Cells["colEstado"].Value == null)
                    continue;

                string estado =
                    fila.Cells["colEstado"]
                    .Value.ToString();

                if (estado == "Vencida")
                {
                    fila.DefaultCellStyle.BackColor =
                        Color.FromArgb(
                            255, 235, 238);

                    fila.DefaultCellStyle.ForeColor =
                        Color.FromArgb(
                            198, 40, 40);
                }
                else if (estado == "Vence hoy")
                {
                    fila.DefaultCellStyle.BackColor =
                        Color.FromArgb(
                            255, 224, 178);

                    fila.DefaultCellStyle.ForeColor =
                        Color.FromArgb(
                            180, 100, 0);
                }
                else if (estado == "Por vencer")
                {
                    fila.DefaultCellStyle.BackColor =
                        Color.FromArgb(
                            255, 248, 225);

                    fila.DefaultCellStyle.ForeColor =
                        Color.FromArgb(
                            120, 90, 0);
                }
                else
                {
                    fila.DefaultCellStyle.BackColor =
                        Color.White;

                    fila.DefaultCellStyle.ForeColor =
                        Color.FromArgb(
                            45, 50, 55);
                }
            }
        }



        private void txtBuscar_TextChanged(
     object sender,
     EventArgs args)
        {
            string texto =
                txtBuscar.Text.Trim()
                .ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MostrarGarantias(equipos);
                return;
            }

            List<Equipo> filtrados =
                equipos
                .Where(equipo =>
                    (equipo.Codigo ?? "")
                        .ToLower()
                        .Contains(texto)

                    ||

                    (equipo.Marca ?? "")
                        .ToLower()
                        .Contains(texto)

                    ||

                    (equipo.Modelo ?? "")
                        .ToLower()
                        .Contains(texto)

                    ||

                    (equipo.Tipo ?? "")
                        .ToLower()
                        .Contains(texto))
                .ToList();

            MostrarGarantias(filtrados);
        }

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            CargarGarantias();
        }



        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}