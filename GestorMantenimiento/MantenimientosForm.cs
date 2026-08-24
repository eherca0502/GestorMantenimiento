using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GestorMantenimiento
{
    public partial class MantenimientosForm : Form
    {
        private readonly MantenimientosDAO mantenimientoDAO;

        private int idUsuario;
        private int idMantenimientoSeleccionado = 0;
        private string nombreUsuario;

        private bool modoEdicion = false;

        public MantenimientosForm(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();

            mantenimientoDAO = new MantenimientosDAO();

            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
        }

       
        private void MantenimientosForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEquipos();
                CargarMantenimientos();

                PrepararFormularioNuevo();

                panelFormulario.Visible = false;
                panelTabla.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el módulo de mantenimientos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEquipos()
        {
            DataTable tabla = mantenimientoDAO.ObtenerEquipos();

            cmbEquipo.DataSource = null;

            cmbEquipo.DisplayMember = "descripcion";
            cmbEquipo.ValueMember = "id";

            DataTable equipos = new DataTable();

            equipos.Columns.Add(
                "id",
                typeof(int));

            equipos.Columns.Add(
                "descripcion",
                typeof(string));

            foreach (DataRow fila in tabla.Rows)
            {
                string codigo =
                    fila["codigo"] == DBNull.Value
                        ? ""
                        : fila["codigo"].ToString();

                string tipo =
                    fila["tipo"] == DBNull.Value
                        ? ""
                        : fila["tipo"].ToString();

                string marca =
                    fila["marca"] == DBNull.Value
                        ? ""
                        : fila["marca"].ToString();

                string modelo =
                    fila["modelo"] == DBNull.Value
                        ? ""
                        : fila["modelo"].ToString();

                string descripcion =
                    codigo + " - " +
                    tipo + " " +
                    marca + " " +
                    modelo;

                equipos.Rows.Add(
                    Convert.ToInt32(fila["id"]),
                    descripcion.Trim());
            }

            cmbEquipo.DataSource = equipos;

            if (cmbEquipo.Items.Count > 0)
            {
                cmbEquipo.SelectedIndex = 0;
            }
        }
        private void CargarMantenimientos()
        {
            DataTable tabla =
                mantenimientoDAO.ObtenerTodos();

            dgvMantenimientos.DataSource = tabla;

            ConfigurarGrid();

            lblRegistros.Text =
                "Mantenimientos registrados: " +
                tabla.Rows.Count;
        }

        private void ConfigurarGrid()
        {
            if (dgvMantenimientos.Columns.Count == 0)
            {
                return;
            }

            OcultarColumna("id");
            OcultarColumna("equipo_id");
            OcultarColumna("usuario_id");

            RenombrarColumna(
                "codigo_equipo",
                "Código");

            RenombrarColumna(
                "tipo_equipo",
                "Equipo");

            RenombrarColumna(
                "marca",
                "Marca");

            RenombrarColumna(
                "modelo",
                "Modelo");

            RenombrarColumna(
                "tipo",
                "Tipo");

            RenombrarColumna(
                "problema",
                "Problema");

            RenombrarColumna(
                "diagnostico",
                "Diagnóstico");

            RenombrarColumna(
                "solucion",
                "Solución");

            RenombrarColumna(
                "costo",
                "Costo");

            RenombrarColumna(
                "fecha_mantenimiento",
                "Fecha");

            RenombrarColumna(
                "observaciones",
                "Observaciones");

            dgvMantenimientos.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            dgvMantenimientos.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(
                    25,
                    32,
                    42);

            dgvMantenimientos.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            dgvMantenimientos.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            dgvMantenimientos.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(
                    255,
                    193,
                    7);

            dgvMantenimientos.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(
                    25,
                    32,
                    42);

            if (dgvMantenimientos.Columns.Contains("costo"))
            {
                dgvMantenimientos.Columns["costo"]
                    .DefaultCellStyle.Format = "C2";
            }

            if (dgvMantenimientos.Columns.Contains(
                "fecha_mantenimiento"))
            {
                dgvMantenimientos.Columns[
                    "fecha_mantenimiento"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }
        }

        private void OcultarColumna(string nombre)
        {
            if (dgvMantenimientos.Columns.Contains(nombre))
            {
                dgvMantenimientos.Columns[nombre]
                    .Visible = false;
            }
        }
        private void RenombrarColumna(
            string nombre,
            string titulo)
        {
            if (dgvMantenimientos.Columns.Contains(nombre))
            {
                dgvMantenimientos.Columns[nombre]
                    .HeaderText = titulo;
            }
        }

     
        private void BuscarMantenimientos()
        {
            string texto =
                txtBuscar.Text.Trim();

            DataTable tabla;

            if (string.IsNullOrWhiteSpace(texto))
            {
                tabla =
                    mantenimientoDAO.ObtenerTodos();
            }
            else
            {
                tabla =
                    mantenimientoDAO.Buscar(texto);
            }

            dgvMantenimientos.DataSource = tabla;

            ConfigurarGrid();

            lblRegistros.Text =
                "Mantenimientos registrados: " +
                tabla.Rows.Count;
        }
        private void txtBuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            BuscarMantenimientos();
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            BuscarMantenimientos();
        }

 
        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            PrepararFormularioNuevo();

            panelFormulario.Visible = true;
            panelTabla.Visible = false;

            cmbEquipo.Focus();
        }

        private void PrepararFormularioNuevo()
        {
            modoEdicion = false;

            idMantenimientoSeleccionado = 0;

            LimpiarFormulario();

            btnGuardar.Text = "Guardar";

            dtpFecha.Value = DateTime.Now;

            if (cmbTipo.Items.Count > 0)
            {
                cmbTipo.SelectedIndex = 0;
            }

            if (cmbEquipo.Items.Count > 0)
            {
                cmbEquipo.SelectedIndex = 0;
            }
        }

        private void LimpiarFormulario()
        {
            if (cmbEquipo.Items.Count > 0)
            {
                cmbEquipo.SelectedIndex = 0;
            }

            if (cmbTipo.Items.Count > 0)
            {
                cmbTipo.SelectedIndex = 0;
            }

            txtProblema.Clear();
            txtDiagnostico.Clear();
            txtSolucion.Clear();

            txtCosto.Text = "0";

            txtObservaciones.Clear();

            dtpFecha.Value = DateTime.Now;
        }

        private void btnEditar_Click(
            object sender,
            EventArgs e)
        {
            EditarSeleccionado();
        }

      
        private void dgvMantenimientos_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            EditarSeleccionado();
        }

        private void EditarSeleccionado()
        {
            if (dgvMantenimientos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecciona un mantenimiento.",
                    "Editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                object valor =
                    dgvMantenimientos.CurrentRow
                        .Cells["id"].Value;

                if (valor == null ||
                    valor == DBNull.Value)
                {
                    return;
                }

                int id =
                    Convert.ToInt32(valor);

                DataTable tabla =
                    mantenimientoDAO.ObtenerPorId(id);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontró el mantenimiento.",
                        "Editar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DataRow fila =
                    tabla.Rows[0];

                idMantenimientoSeleccionado = id;

                modoEdicion = true;

               
                if (fila["equipo_id"] != DBNull.Value)
                {
                    int equipoId =
                        Convert.ToInt32(
                            fila["equipo_id"]);

                    cmbEquipo.SelectedValue =
                        equipoId;
                }

                
                string tipo =
                    fila["tipo"] == DBNull.Value
                        ? ""
                        : fila["tipo"].ToString();

                int indiceTipo =
                    cmbTipo.Items.IndexOf(tipo);

                if (indiceTipo >= 0)
                {
                    cmbTipo.SelectedIndex =
                        indiceTipo;
                }
                else
                {
                    cmbTipo.SelectedIndex = -1;
                }

                txtProblema.Text =
                    fila["problema"] == DBNull.Value
                        ? ""
                        : fila["problema"].ToString();

                txtDiagnostico.Text =
                    fila["diagnostico"] == DBNull.Value
                        ? ""
                        : fila["diagnostico"].ToString();

                txtSolucion.Text =
                    fila["solucion"] == DBNull.Value
                        ? ""
                        : fila["solucion"].ToString();

                txtCosto.Text =
                    fila["costo"] == DBNull.Value
                        ? "0"
                        : Convert.ToDecimal(
                            fila["costo"])
                            .ToString(
                                "0.00",
                                CultureInfo.InvariantCulture);

                if (fila["fecha_mantenimiento"] !=
                    DBNull.Value)
                {
                    dtpFecha.Value =
                        Convert.ToDateTime(
                            fila["fecha_mantenimiento"]);
                }
                else
                {
                    dtpFecha.Value =
                        DateTime.Now;
                }

                txtObservaciones.Text =
                    fila["observaciones"] == DBNull.Value
                        ? ""
                        : fila["observaciones"].ToString();

                btnGuardar.Text =
                    "Actualizar";

                panelFormulario.Visible = true;
                panelTabla.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el mantenimiento.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
                int equipoId =
                    Convert.ToInt32(
                        cmbEquipo.SelectedValue);

                string tipo =
                    cmbTipo.SelectedItem.ToString();

                string problema =
                    txtProblema.Text.Trim();

                string diagnostico =
                    txtDiagnostico.Text.Trim();

                string solucion =
                    txtSolucion.Text.Trim();

                decimal costo;

                string textoCosto =
                    txtCosto.Text.Trim()
                        .Replace("$", "")
                        .Replace(",", "");

                if (!decimal.TryParse(
                    textoCosto,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out costo))
                {
                    MessageBox.Show(
                        "El costo no tiene un formato válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCosto.Focus();

                    return;
                }

                DateTime fecha =
                    dtpFecha.Value;

                string observaciones =
                    txtObservaciones.Text.Trim();

                bool resultado;

                if (modoEdicion)
                {
                    resultado =
                        mantenimientoDAO.Actualizar(
                            idMantenimientoSeleccionado,
                            equipoId,
                            tipo,
                            problema,
                            diagnostico,
                            solucion,
                            costo,
                            fecha,
                            observaciones);
                }
             
                else
                {
                    if (idUsuario <= 0)
                    {
                        MessageBox.Show(
                            "No se pudo identificar al usuario actual. " +
                            "Abre el módulo desde una sesión iniciada.",
                            "Usuario no identificado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    resultado =
                        mantenimientoDAO.Insertar(
                            equipoId,
                            idUsuario,
                            tipo,
                            problema,
                            diagnostico,
                            solucion,
                            costo,
                            fecha,
                            observaciones);
                }

                if (resultado)
                {
                    MessageBox.Show(
                        modoEdicion
                            ? "Mantenimiento actualizado correctamente."
                            : "Mantenimiento registrado correctamente.",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarMantenimientos();

                    panelFormulario.Visible = false;
                    panelTabla.Visible = true;

                    LimpiarFormulario();

                    modoEdicion = false;
                    idMantenimientoSeleccionado = 0;
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el mantenimiento.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al guardar el mantenimiento.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            if (cmbEquipo.SelectedIndex < 0 ||
                cmbEquipo.SelectedValue == null)
            {
                MessageBox.Show(
                    "Selecciona un equipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEquipo.Focus();

                return false;
            }

            if (cmbTipo.SelectedIndex < 0 ||
                cmbTipo.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona el tipo de mantenimiento.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTipo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtProblema.Text))
            {
                MessageBox.Show(
                    "Escribe el problema presentado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProblema.Focus();

                return false;
            }

            string textoCosto =
                txtCosto.Text.Trim()
                    .Replace("$", "")
                    .Replace(",", "");

            decimal costo;

            if (!decimal.TryParse(
                textoCosto,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out costo))
            {
                MessageBox.Show(
                    "Introduce un costo válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCosto.Focus();

                return false;
            }

            if (costo < 0)
            {
                MessageBox.Show(
                    "El costo no puede ser negativo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCosto.Focus();

                return false;
            }

            return true;
        }

        
        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Deseas cancelar y volver a la lista?",
                    "Cancelar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                panelFormulario.Visible = false;
                panelTabla.Visible = true;

                LimpiarFormulario();

                modoEdicion = false;

                idMantenimientoSeleccionado = 0;
            }
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvMantenimientos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecciona un mantenimiento.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                object valor =
                    dgvMantenimientos.CurrentRow
                        .Cells["id"].Value;

                if (valor == null ||
                    valor == DBNull.Value)
                {
                    return;
                }

                int id =
                    Convert.ToInt32(valor);

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Estás seguro de eliminar este mantenimiento?\n\n" +
                        "Esta acción no se puede deshacer.",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (resultado != DialogResult.Yes)
                {
                    return;
                }

                bool eliminado =
                    mantenimientoDAO.Eliminar(id);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Mantenimiento eliminado correctamente.",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarMantenimientos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el mantenimiento.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el mantenimiento.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}