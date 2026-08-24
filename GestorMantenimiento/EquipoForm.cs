using System;
using System.Windows.Forms;
using GestorMantenimiento.Data;
using GestorMantenimiento.Models;

namespace GestorMantenimiento
{
    public partial class EquipoForm : Form
    {
        private readonly EquipoDAO equipoDAO;

        private Equipo equipoEditar;

      

        public EquipoForm()
        {
            InitializeComponent();

            equipoDAO = new EquipoDAO();

            equipoEditar = null;

            ConfigurarFormularioNuevo();
        }

      

        public EquipoForm(Equipo equipo)
        {
            InitializeComponent();

            equipoDAO = new EquipoDAO();

            equipoEditar = equipo;

            ConfigurarFormularioEditar();
        }

        

        private void ConfigurarFormularioNuevo()
        {
            lblTitulo.Text = "Nuevo equipo";

            lblSubtitulo.Text =
                "Registra la información del equipo";

            cmbTipo.SelectedIndex = -1;

            cmbEstado.SelectedIndex = 0;

            dtpAdquisicion.Value = DateTime.Today;

            dtpGarantia.Value =
                DateTime.Today.AddYears(1);

            txtCodigo.Focus();
        }

     
        private void ConfigurarFormularioEditar()
        {
            lblTitulo.Text = "Editar equipo";

            lblSubtitulo.Text =
                "Modifica la información del equipo";

            if (equipoEditar == null)
            {
                return;
            }

            txtCodigo.Text =
                equipoEditar.Codigo;

            cmbTipo.Text =
                equipoEditar.Tipo;

            txtMarca.Text =
                equipoEditar.Marca;

            txtModelo.Text =
                equipoEditar.Modelo;

            txtSerie.Text =
                equipoEditar.NumeroSerie;

            txtUsuario.Text =
                equipoEditar.UsuarioAsignado;

            txtArea.Text =
                equipoEditar.Area;

            txtSistema.Text =
                equipoEditar.SistemaOperativo;

            txtRam.Text =
                equipoEditar.RAM;

            txtAlmacenamiento.Text =
                equipoEditar.Almacenamiento;

            txtIp.Text =
                equipoEditar.IP;

            if (equipoEditar.FechaAdquisicion.HasValue)
            {
                dtpAdquisicion.Value =
                    equipoEditar.FechaAdquisicion.Value;
            }

            if (equipoEditar.FechaGarantia.HasValue)
            {
                dtpGarantia.Value =
                    equipoEditar.FechaGarantia.Value;
            }

            cmbEstado.Text =
                equipoEditar.Estado;

            txtObservaciones.Text =
                equipoEditar.Observaciones;
        }


        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            try
            {
                Equipo equipo =
                    new Equipo();

                if (equipoEditar != null)
                {
                    equipo.Id =
                        equipoEditar.Id;
                }

                equipo.Codigo =
                    txtCodigo.Text.Trim();

                equipo.Tipo =
                    cmbTipo.Text.Trim();

                equipo.Marca =
                    txtMarca.Text.Trim();

                equipo.Modelo =
                    txtModelo.Text.Trim();

                equipo.NumeroSerie =
                    txtSerie.Text.Trim();

                equipo.UsuarioAsignado =
                    txtUsuario.Text.Trim();

                equipo.Area =
                    txtArea.Text.Trim();

                equipo.SistemaOperativo =
                    txtSistema.Text.Trim();

                equipo.RAM =
                    txtRam.Text.Trim();

                equipo.Almacenamiento =
                    txtAlmacenamiento.Text.Trim();

                equipo.IP =
                    txtIp.Text.Trim();

                equipo.FechaAdquisicion =
                    dtpAdquisicion.Value.Date;

                equipo.FechaGarantia =
                    dtpGarantia.Value.Date;

                equipo.Estado =
                    cmbEstado.Text.Trim();

                equipo.Observaciones =
                    txtObservaciones.Text.Trim();

                bool resultado;

             

                if (equipoEditar != null)
                {
                    resultado =
                        equipoDAO.Actualizar(equipo);
                }


                else
                {
                    resultado =
                        equipoDAO.Agregar(equipo);
                }

                if (resultado)
                {
                    MessageBox.Show(
                        equipoEditar != null
                            ? "Equipo actualizado correctamente."
                            : "Equipo registrado correctamente.",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult =
                        DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la información.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar el equipo.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Ingresa el código del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbTipo.Text))
            {
                MessageBox.Show(
                    "Selecciona el tipo de equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTipo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show(
                    "Ingresa la marca del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMarca.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show(
                    "Ingresa el modelo del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtModelo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbEstado.Text))
            {
                MessageBox.Show(
                    "Selecciona el estado del equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEstado.Focus();

                return false;
            }

            return true;
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.Cancel;

            this.Close();
        }
    }
}