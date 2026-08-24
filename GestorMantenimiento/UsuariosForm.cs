using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestorMantenimiento.Models;

namespace GestorMantenimiento
{
    public partial class UsuariosForm : Form
    {
        private readonly UsuariosDAO usuariosDAO;

        private int idUsuarioSeleccionado = 0;

        private bool modoEdicion = false;


        public UsuariosForm()
        {
            InitializeComponent();

            usuariosDAO = new UsuariosDAO();

            ConfigurarFormulario();

            CargarUsuarios();
        }



        private void ConfigurarFormulario()
        {
            txtContrasena.UseSystemPasswordChar = true;

            cmbRol.Items.Clear();

            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Técnico");
            cmbRol.Items.Add("Usuario");

            cmbRol.SelectedIndex = 2;

            chkActivo.Checked = true;

            dgvUsuarios.AutoGenerateColumns = true;

            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.MultiSelect = false;

            dgvUsuarios.ReadOnly = true;

            dgvUsuarios.AllowUserToAddRows = false;

            dgvUsuarios.AllowUserToDeleteRows = false;

            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            LimpiarFormulario();
        }


        private void CargarUsuarios()
        {
            try
            {
                List<Usuario> usuarios =
                    usuariosDAO.ObtenerTodos();

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarios;

                ConfigurarColumnas();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los usuarios.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ConfigurarColumnas()
        {
            if (dgvUsuarios == null)
                return;

            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
            {
                if (columna.DataPropertyName == "Id")
                {
                    columna.Visible = false;
                }
                else if (columna.DataPropertyName == "NombreUsuario")
                {
                    columna.HeaderText = "Usuario";
                }
                else if (columna.DataPropertyName == "Contrasena")
                {
                    columna.Visible = false;
                }
                else if (columna.DataPropertyName == "Rol")
                {
                    columna.HeaderText = "Rol";
                }
                else if (columna.DataPropertyName == "Activo")
                {
                    columna.HeaderText = "Activo";
                }
            }
        }

        private void txtBuscar_TextChanged(
            object sender,
            EventArgs args)
        {
            try
            {
                string texto =
                    txtBuscar.Text.Trim();

                List<Usuario> usuarios;

                if (string.IsNullOrWhiteSpace(texto))
                {
                    usuarios =
                        usuariosDAO.ObtenerTodos();
                }
                else
                {
                    usuarios =
                        usuariosDAO.Buscar(texto);
                }

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = usuarios;

                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible realizar la búsqueda.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


     

        private void dgvUsuarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                Usuario usuario =
                    dgvUsuarios.Rows[e.RowIndex]
                    .DataBoundItem as Usuario;

                if (usuario == null)
                    return;

                idUsuarioSeleccionado =
                    usuario.Id;

                txtNombreUsuario.Text =
                    usuario.NombreUsuario;

                txtContrasena.Text =
                    usuario.Contrasena;

                cmbRol.Text =
                    usuario.Rol;

                chkActivo.Checked =
                    usuario.Activo;

                modoEdicion = true;

                btnGuardar.Text =
                    "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible seleccionar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            LimpiarFormulario();

            modoEdicion = false;

            idUsuarioSeleccionado = 0;

            btnGuardar.Text = "Guardar";

            txtNombreUsuario.Focus();
        }



        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                string nombreUsuario =
                    txtNombreUsuario.Text.Trim();

                string contrasena =
                    txtContrasena.Text;

                string rol =
                    cmbRol.Text.Trim();

                bool activo =
                    chkActivo.Checked;



                if (!modoEdicion)
                {
                    if (usuariosDAO.ExisteNombreUsuario(
                        nombreUsuario))
                    {
                        MessageBox.Show(
                            "El nombre de usuario ya existe.",
                            "Usuario duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtNombreUsuario.Focus();

                        return;
                    }

                    Usuario usuario =
                        new Usuario();

                    usuario.NombreUsuario =
                        nombreUsuario;

                    usuario.Contrasena =
                        contrasena;

                    usuario.Rol =
                        rol;

                    usuario.Activo =
                        activo;

                    bool resultado =
                        usuariosDAO.Agregar(usuario);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Usuario registrado correctamente.",
                            "Usuarios",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No fue posible registrar el usuario.",
                            "Usuarios",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }



                else
                {
                    if (usuariosDAO.ExisteNombreUsuario(
                        nombreUsuario,
                        idUsuarioSeleccionado))
                    {
                        MessageBox.Show(
                            "El nombre de usuario ya existe.",
                            "Usuario duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtNombreUsuario.Focus();

                        return;
                    }

                    Usuario usuario =
                        new Usuario();

                    usuario.Id =
                        idUsuarioSeleccionado;

                    usuario.NombreUsuario =
                        nombreUsuario;

                    usuario.Contrasena =
                        contrasena;

                    usuario.Rol =
                        rol;

                    usuario.Activo =
                        activo;

                    bool resultado;

                    if (string.IsNullOrWhiteSpace(
                        contrasena))
                    {
                        resultado =
                            usuariosDAO
                            .ActualizarSinCambiarContrasena(
                                usuario);
                    }
                    else
                    {
                        resultado =
                            usuariosDAO.Actualizar(
                                usuario);
                    }

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Usuario actualizado correctamente.",
                            "Usuarios",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No fue posible actualizar el usuario.",
                            "Usuarios",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show(
                    "Selecciona un usuario primero.",
                    "Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Deseas eliminar el usuario seleccionado?",
                    "Eliminar usuario",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                bool eliminado =
                    usuariosDAO.Eliminar(
                        idUsuarioSeleccionado);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Usuario eliminado correctamente.",
                        "Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible eliminar el usuario.",
                        "Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible eliminar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnCambiarEstado_Click(
            object sender,
            EventArgs e)
        {
            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show(
                    "Selecciona un usuario primero.",
                    "Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                bool nuevoEstado =
                    !chkActivo.Checked;

                bool resultado =
                    usuariosDAO.CambiarEstado(
                        idUsuarioSeleccionado,
                        nuevoEstado);

                if (resultado)
                {
                    MessageBox.Show(
                        nuevoEstado
                            ? "Usuario activado correctamente."
                            : "Usuario desactivado correctamente.",
                        "Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cambiar el estado del usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = 0;

            txtNombreUsuario.Clear();

            txtContrasena.Clear();

            cmbRol.SelectedIndex = 2;

            chkActivo.Checked = true;

            modoEdicion = false;

            if (btnGuardar != null)
            {
                btnGuardar.Text =
                    "Guardar";
            }

            if (dgvUsuarios != null)
            {
                dgvUsuarios.ClearSelection();
            }
        }


        

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(
                txtNombreUsuario.Text))
            {
                MessageBox.Show(
                    "Ingresa el nombre de usuario.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombreUsuario.Focus();

                return false;
            }

            if (!modoEdicion &&
                string.IsNullOrWhiteSpace(
                    txtContrasena.Text))
            {
                MessageBox.Show(
                    "Ingresa una contraseña.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();

                return false;
            }

            if (cmbRol.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(
                    cmbRol.Text))
            {
                MessageBox.Show(
                    "Selecciona un rol.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRol.Focus();

                return false;
            }

            return true;
        }


        

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}
