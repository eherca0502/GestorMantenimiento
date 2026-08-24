using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestorMantenimiento
{
    public partial class LoginForm : Form
    {
        private Conexion conexion = new Conexion();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingresa el usuario y la contraseña.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    connection.Open();

                    string consulta = @"
                        SELECT id, nombre_usuario, rol
                        FROM usuarios
                        WHERE nombre_usuario = @usuario
                        AND contrasena = @contrasena
                        AND activo = 1";

                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUsuario = Convert.ToInt32(reader["id"]);
                                string nombreUsuario = reader["nombre_usuario"].ToString();
                                string rol = reader["rol"].ToString();

                                MainForm principal = new MainForm(
                                    idUsuario,
                                    nombreUsuario,
                                    rol);

                                principal.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos.",
                                    "Acceso denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                txtContrasena.Clear();
                                txtContrasena.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo conectar con la base de datos.\n\n" +
                    ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion.PerformClick();
            }
        }
    }
}