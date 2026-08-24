using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GestorMantenimiento.Data;

namespace GestorMantenimiento
{
    public partial class MainForm : Form
    {
        private int idUsuario;
        private string nombreUsuario;
        private string rol;

        private readonly EquipoDAO equipoDAO;
        private readonly MantenimientosDAO mantenimientoDAO;

        private DataGridView dgvActividad;


        public MainForm(
            int idUsuario,
            string nombreUsuario,
            string rol)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.rol = rol;

            equipoDAO = new EquipoDAO();
            mantenimientoDAO = new MantenimientosDAO();

            lblUsuario.Text = nombreUsuario;
            lblRol.Text = rol;

            CrearTablaActividad();
            CargarDashboard();
        }



        private void CrearTablaActividad()
        {
            dgvActividad = new DataGridView();

            dgvActividad.Name = "dgvActividad";

            dgvActividad.Dock = DockStyle.Fill;

            dgvActividad.BackgroundColor = Color.White;

            dgvActividad.BorderStyle = BorderStyle.None;

            dgvActividad.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvActividad.GridColor =
                Color.FromArgb(235, 238, 242);

            dgvActividad.RowHeadersVisible = false;

            dgvActividad.AllowUserToAddRows = false;

            dgvActividad.AllowUserToDeleteRows = false;

            dgvActividad.AllowUserToResizeRows = false;

            dgvActividad.ReadOnly = true;

            dgvActividad.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvActividad.MultiSelect = false;

            dgvActividad.AutoGenerateColumns = false;

            dgvActividad.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvActividad.RowTemplate.Height = 42;

            dgvActividad.EnableHeadersVisualStyles = false;

            dgvActividad.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 42);

            dgvActividad.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvActividad.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            dgvActividad.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvActividad.ColumnHeadersHeight = 38;

            dgvActividad.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9F);

            dgvActividad.DefaultCellStyle.ForeColor =
                Color.FromArgb(50, 55, 60);

            dgvActividad.DefaultCellStyle.BackColor =
                Color.White;

            dgvActividad.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(255, 193, 7);

            dgvActividad.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 32, 42);

            dgvActividad.DefaultCellStyle.Padding =
                new Padding(8, 0, 8, 0);



            DataGridViewTextBoxColumn columnaEquipo =
                new DataGridViewTextBoxColumn();

            columnaEquipo.Name = "codigo_equipo";
            columnaEquipo.HeaderText = "Equipo";
            columnaEquipo.DataPropertyName = "codigo_equipo";
            columnaEquipo.Width = 100;


            

            DataGridViewTextBoxColumn columnaTipo =
                new DataGridViewTextBoxColumn();

            columnaTipo.Name = "tipo";
            columnaTipo.HeaderText = "Mantenimiento";
            columnaTipo.DataPropertyName = "tipo";
            columnaTipo.Width = 130;

            DataGridViewTextBoxColumn columnaProblema =
                new DataGridViewTextBoxColumn();

            columnaProblema.Name = "problema";
            columnaProblema.HeaderText = "Problema";
            columnaProblema.DataPropertyName = "problema";
            columnaProblema.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;



            DataGridViewTextBoxColumn columnaFecha =
                new DataGridViewTextBoxColumn();

            columnaFecha.Name = "fecha_mantenimiento";
            columnaFecha.HeaderText = "Fecha";
            columnaFecha.DataPropertyName =
                "fecha_mantenimiento";

            columnaFecha.Width = 130;

            columnaFecha.DefaultCellStyle.Format =
                "dd/MM/yyyy HH:mm";


            dgvActividad.Columns.Add(
                columnaEquipo);

            dgvActividad.Columns.Add(
                columnaTipo);

            dgvActividad.Columns.Add(
                columnaProblema);

            dgvActividad.Columns.Add(
                columnaFecha);



            panelActividad.Controls.Clear();

            panelActividad.Controls.Add(
                dgvActividad);
        }
        private void CargarDashboard()
        {
            try
            {
               

                int totalEquipos =
                    equipoDAO.ContarEquipos();

                int equiposActivos =
                    equipoDAO.ContarPorEstado("Activo");

                lblNumeroEquipos.Text =
                    totalEquipos.ToString();

                ActualizarTextoEquipos(
     totalEquipos,
     equiposActivos);



                int mantenimientosMes =
                    mantenimientoDAO.ContarMantenimientosMes();

                lblNumeroMantenimientos.Text =
                    mantenimientosMes.ToString();

                lblTextoMantenimientos.Text =
                    "Mantenimientos este mes";



                int garantiasPorVencer =
                    mantenimientoDAO.ContarGarantiasPorVencer();

                lblNumeroGarantias.Text =
                    garantiasPorVencer.ToString();

                ActualizarEstadoGarantias(
                    garantiasPorVencer);


             

                lblNumeroTickets.Text = "0";

                lblTextoTickets.Text =
                    "Tickets abiertos";


               

                CargarActividadReciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el Dashboard.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ActualizarTextoEquipos(
            int total,
            int activos)
        {
            if (total == 0)
            {
                lblTextoEquipos.Text =
                    "Sin equipos registrados";

                return;
            }

            if (activos == total)
            {
                lblTextoEquipos.Text =
                    "Todos los equipos activos";
            }
            else
            {
                lblTextoEquipos.Text =
                    activos + " de " + total + " activos";
            }
        }
        private void CargarActividadReciente()
        {
            try
            {
                DataTable tabla =
                    mantenimientoDAO.ObtenerRecientes(5);

                if (tabla.Rows.Count == 0)
                {
                    dgvActividad.DataSource = null;

                    dgvActividad.Visible = false;

                    MostrarSinActividad();

                    return;
                }

                Control mensaje =
                    panelActividad.Controls["lblSinActividad"];

                if (mensaje != null)
                {
                    mensaje.Visible = false;
                }

                dgvActividad.Visible = true;

                dgvActividad.DataSource = tabla;
            }
            catch (Exception)
            {
                dgvActividad.Visible = false;

                MostrarSinActividad(
                    "No se pudo cargar la actividad reciente.");
            }
        }


        private void MostrarSinActividad(
            string mensaje = "No hay actividad reciente")
        {
            if (panelActividad.Controls.ContainsKey(
                "lblSinActividad"))
            {
                Label existente =
                    panelActividad.Controls["lblSinActividad"]
                    as Label;

                if (existente != null)
                {
                    existente.Text = mensaje;
                    existente.Visible = true;
                }

                return;
            }

            Label lblSinActividad =
                new Label();

            lblSinActividad.Name =
                "lblSinActividad";

            lblSinActividad.Text =
                mensaje;

            lblSinActividad.Dock =
                DockStyle.Fill;

            lblSinActividad.TextAlign =
                ContentAlignment.MiddleCenter;

            lblSinActividad.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);

            lblSinActividad.ForeColor =
                Color.FromArgb(130, 135, 140);

            lblSinActividad.BackColor =
                Color.White;

            panelActividad.Controls.Add(
                lblSinActividad);
        }
        private void ActualizarEstadoGarantias(int cantidad)
        {
            if (cantidad == 0)
            {
                cardGarantias.BackColor =
                    Color.FromArgb(232, 245, 233);

                lblNumeroGarantias.ForeColor =
                    Color.FromArgb(46, 125, 50);

                lblTextoGarantias.Text =
                    "Sin garantías próximas";
            }
            else if (cantidad <= 3)
            {
                cardGarantias.BackColor =
                    Color.FromArgb(255, 248, 225);

                lblNumeroGarantias.ForeColor =
                    Color.FromArgb(245, 166, 35);

                lblTextoGarantias.Text =
                    "Garantías por vencer";
            }
            else
            {
                cardGarantias.BackColor =
                    Color.FromArgb(255, 235, 238);

                lblNumeroGarantias.ForeColor =
                    Color.FromArgb(198, 40, 40);

                lblTextoGarantias.Text =
                    "Atención requerida";
            }
        }

        private void btnInicio_Click(
            object sender,
            EventArgs e)
        {
            lblTitulo.Text = "Dashboard";

            lblSubtitulo.Text =
                "Resumen general del sistema";

            CargarDashboard();
        }


        

        private void btnEquipos_Click(
            object sender,
            EventArgs e)
        {
            using (EquiposForm form =
                new EquiposForm())
            {
                form.ShowDialog(this);
            }

            CargarDashboard();
        }


     

        private void btnMantenimientos_Click(
            object sender,
            EventArgs e)
        {
            using (MantenimientosForm form =
                new MantenimientosForm(
                    idUsuario,
                    nombreUsuario))
            {
                form.ShowDialog(this);
            }

            CargarDashboard();
        }
        private void btnGarantias_Click(
      object sender,
      EventArgs e)
        {
            using (GarantiasForm form = new GarantiasForm())
            {
                form.ShowDialog(this);
            }

            CargarDashboard();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosForm formulario = new UsuariosForm();

                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible abrir el módulo de Usuarios.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnReportes_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Aquí construiremos el módulo de reportes.",
                "Reportes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }



        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Deseas cerrar la sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LoginForm login =
                    new LoginForm();

                login.Show();

                this.Close();
            }
        }


    

        private void btnSalir_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Deseas salir del sistema?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}