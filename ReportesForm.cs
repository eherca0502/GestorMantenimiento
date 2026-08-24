using GestorMantenimiento.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static GestorMantenimiento.Data.ReportesDAO;

namespace GestorMantenimiento
{
    public partial class ReportesForm : Form
    {
        private readonly ReportesDAO reportesDAO;

        private List<ReporteEquipo> reporteEquipos;
        private List<ReporteMantenimiento> reporteMantenimientos;
        private List<ReporteGarantia> reporteGarantias;


        public ReportesForm()
        {
            InitializeComponent();

            reportesDAO = new ReportesDAO();

            ConfigurarFormulario();

            CargarResumen();

            CargarDatos();
        }



        private void ConfigurarFormulario()
        {
            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Equipos");
            cmbTipoReporte.Items.Add("Mantenimientos");
            cmbTipoReporte.Items.Add("Garantías");

            cmbTipoReporte.SelectedIndex = 0;
        }



        private void CargarResumen()
        {
            try
            {
                int equipos =
                    reportesDAO.ContarEquipos();

                int mantenimientos =
                    reportesDAO.ContarMantenimientos();

                int garantiasVigentes =
                    reportesDAO.ContarGarantiasVigentes();

                decimal costoTotal =
                    reportesDAO.ObtenerCostoTotalMantenimientos();

                lblNumeroEquipos.Text =
                    equipos.ToString();

                lblNumeroMantenimientos.Text =
                    mantenimientos.ToString();

                lblNumeroGarantias.Text =
                    garantiasVigentes.ToString();

                lblNumeroCosto.Text =
                    costoTotal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el resumen.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarDatos()
        {
            try
            {
                string tipo =
                    cmbTipoReporte.SelectedItem?
                    .ToString();

                if (tipo == "Equipos")
                {
                    CargarReporteEquipos();
                }
                else if (tipo == "Mantenimientos")
                {
                    CargarReporteMantenimientos();
                }
                else if (tipo == "Garantías")
                {
                    CargarReporteGarantias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos del reporte.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void CargarReporteEquipos()
        {
            reporteEquipos =
                reportesDAO.ObtenerReporteEquipos();

            MostrarEquipos(reporteEquipos);
        }


        private void MostrarEquipos(
            List<ReporteEquipo> lista)
        {
            dgvReportes.Rows.Clear();

            foreach (ReporteEquipo equipo in lista)
            {
                dgvReportes.Rows.Add(
                    equipo.Id,
                    equipo.Codigo,
                    equipo.Tipo,
                    equipo.Marca,
                    equipo.Modelo,
                    equipo.NumeroSerie,
                    equipo.UsuarioAsignado,
                    equipo.Area,
                    equipo.Estado,
                    equipo.FechaGarantia.HasValue
                        ? equipo.FechaGarantia.Value
                            .ToString("dd/MM/yyyy")
                        : "");
            }

            ConfigurarColumnasEquipos();

            lblCantidadResultados.Text =
                lista.Count + " registros";
        }



        private void CargarReporteMantenimientos()
        {
            reporteMantenimientos =
                reportesDAO.ObtenerReporteMantenimientos();

            MostrarMantenimientos(
                reporteMantenimientos);
        }


        private void MostrarMantenimientos(
            List<ReporteMantenimiento> lista)
        {
            dgvReportes.Rows.Clear();

            foreach (
                ReporteMantenimiento mantenimiento
                in lista)
            {
                dgvReportes.Rows.Add(
                    mantenimiento.Id,
                    mantenimiento.Codigo,
                    mantenimiento.TipoEquipo,
                    mantenimiento.Marca,
                    mantenimiento.Modelo,
                    mantenimiento.NombreUsuario,
                    mantenimiento.Tipo,
                    mantenimiento.Problema,
                    mantenimiento.Diagnostico,
                    mantenimiento.Solucion,
                    mantenimiento.Costo.ToString("C2"),
                    mantenimiento.FechaMantenimiento.HasValue
                        ? mantenimiento.FechaMantenimiento.Value
                            .ToString("dd/MM/yyyy")
                        : "");
            }

            ConfigurarColumnasMantenimientos();

            lblCantidadResultados.Text =
                lista.Count + " registros";
        }



        private void CargarReporteGarantias()
        {
            reporteGarantias =
                reportesDAO.ObtenerReporteGarantias();

            MostrarGarantias(reporteGarantias);
        }


        private void MostrarGarantias(
            List<ReporteGarantia> lista)
        {
            dgvReportes.Rows.Clear();

            foreach (ReporteGarantia garantia in lista)
            {
                int diasRestantes =
                    (garantia.FechaGarantia.Date -
                     DateTime.Today).Days;

                string tiempo;

                if (diasRestantes < 0)
                {
                    tiempo = "Vencida";
                }
                else if (diasRestantes == 0)
                {
                    tiempo = "Vence hoy";
                }
                else
                {
                    tiempo =
                        diasRestantes + " días";
                }

                dgvReportes.Rows.Add(
                    garantia.Id,
                    garantia.Codigo,
                    garantia.Tipo,
                    garantia.Marca,
                    garantia.Modelo,
                    garantia.UsuarioAsignado,
                    garantia.Area,
                    garantia.FechaGarantia
                        .ToString("dd/MM/yyyy"),
                    tiempo,
                    garantia.EstadoGarantia);
            }

            ConfigurarColumnasGarantias();

            lblCantidadResultados.Text =
                lista.Count + " registros";
        }



        private void ConfigurarColumnasEquipos()
        {
            dgvReportes.Columns.Clear();

            AgregarColumna(
                "colId",
                "ID",
                false);

            AgregarColumna(
                "colCodigo",
                "Código",
                true);

            AgregarColumna(
                "colTipo",
                "Tipo",
                true);

            AgregarColumna(
                "colMarca",
                "Marca",
                true);

            AgregarColumna(
                "colModelo",
                "Modelo",
                true);

            AgregarColumna(
                "colSerie",
                "No. Serie",
                true);

            AgregarColumna(
                "colUsuario",
                "Usuario asignado",
                true);

            AgregarColumna(
                "colArea",
                "Área",
                true);

            AgregarColumna(
                "colEstado",
                "Estado",
                true);

            AgregarColumna(
                "colGarantia",
                "Garantía",
                true);
        }


        private void ConfigurarColumnasMantenimientos()
        {
            dgvReportes.Columns.Clear();

            AgregarColumna(
                "colId",
                "ID",
                false);

            AgregarColumna(
                "colCodigo",
                "Código",
                true);

            AgregarColumna(
                "colTipoEquipo",
                "Equipo",
                true);

            AgregarColumna(
                "colMarca",
                "Marca",
                true);

            AgregarColumna(
                "colModelo",
                "Modelo",
                true);

            AgregarColumna(
                "colUsuario",
                "Usuario",
                true);

            AgregarColumna(
                "colTipo",
                "Tipo",
                true);

            AgregarColumna(
                "colProblema",
                "Problema",
                true);

            AgregarColumna(
                "colDiagnostico",
                "Diagnóstico",
                true);

            AgregarColumna(
                "colSolucion",
                "Solución",
                true);

            AgregarColumna(
                "colCosto",
                "Costo",
                true);

            AgregarColumna(
                "colFecha",
                "Fecha",
                true);
        }


        private void ConfigurarColumnasGarantias()
        {
            dgvReportes.Columns.Clear();

            AgregarColumna(
                "colId",
                "ID",
                false);

            AgregarColumna(
                "colCodigo",
                "Código",
                true);

            AgregarColumna(
                "colTipo",
                "Tipo",
                true);

            AgregarColumna(
                "colMarca",
                "Marca",
                true);

            AgregarColumna(
                "colModelo",
                "Modelo",
                true);

            AgregarColumna(
                "colUsuario",
                "Usuario asignado",
                true);

            AgregarColumna(
                "colArea",
                "Área",
                true);

            AgregarColumna(
                "colFecha",
                "Vencimiento",
                true);

            AgregarColumna(
                "colTiempo",
                "Tiempo",
                true);

            AgregarColumna(
                "colEstado",
                "Estado",
                true);
        }


        private void AgregarColumna(
            string nombre,
            string encabezado,
            bool visible)
        {
            DataGridViewTextBoxColumn columna =
                new DataGridViewTextBoxColumn();

            columna.Name = nombre;

            columna.HeaderText =
                encabezado;

            columna.Visible =
                visible;

            dgvReportes.Columns.Add(
                columna);
        }



        private void txtBuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim()
                .ToLower();

            string tipo =
                cmbTipoReporte.SelectedItem?
                .ToString();

            if (tipo == "Equipos")
            {
                if (reporteEquipos == null)
                    return;

                List<ReporteEquipo> filtrados =
                    reporteEquipos
                    .Where(equipo =>
                        (equipo.Codigo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (equipo.Tipo ?? "")
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

                        (equipo.UsuarioAsignado ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (equipo.Area ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (equipo.Estado ?? "")
                            .ToLower()
                            .Contains(texto))
                    .ToList();

                MostrarEquipos(filtrados);
            }
            else if (tipo == "Mantenimientos")
            {
                if (reporteMantenimientos == null)
                    return;

                List<ReporteMantenimiento> filtrados =
                    reporteMantenimientos
                    .Where(m =>
                        (m.Codigo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (m.NombreUsuario ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (m.Tipo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (m.Problema ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (m.Diagnostico ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (m.Solucion ?? "")
                            .ToLower()
                            .Contains(texto))
                    .ToList();

                MostrarMantenimientos(
                    filtrados);
            }
            else if (tipo == "Garantías")
            {
                if (reporteGarantias == null)
                    return;

                List<ReporteGarantia> filtrados =
                    reporteGarantias
                    .Where(g =>
                        (g.Codigo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.Tipo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.Marca ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.Modelo ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.UsuarioAsignado ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.Area ?? "")
                            .ToLower()
                            .Contains(texto)

                        ||

                        (g.EstadoGarantia ?? "")
                            .ToLower()
                            .Contains(texto))
                    .ToList();

                MostrarGarantias(
                    filtrados);
            }
        }


        private void cmbTipoReporte_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            txtBuscar.Clear();

            CargarDatos();
        }



        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            CargarResumen();

            CargarDatos();
        }


        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}
