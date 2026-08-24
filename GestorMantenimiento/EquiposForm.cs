using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestorMantenimiento.Data;
using GestorMantenimiento.Models;

namespace GestorMantenimiento
{
    public partial class EquiposForm : Form
    {
        private readonly EquipoDAO equipoDAO;

        public EquiposForm()
        {
            InitializeComponent();

            equipoDAO = new EquipoDAO();

            ConfigurarGrid();

            CargarEquipos();
        }

        

        private void ConfigurarGrid()
        {
            dgvEquipos.AutoGenerateColumns = false;

            dgvEquipos.Columns.Clear();

            DataGridViewTextBoxColumn colId =
                new DataGridViewTextBoxColumn();

            colId.Name = "Id";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Visible = false;

            dgvEquipos.Columns.Add(colId);

            DataGridViewTextBoxColumn colCodigo =
                new DataGridViewTextBoxColumn();

            colCodigo.Name = "Codigo";
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Código";

            dgvEquipos.Columns.Add(colCodigo);

            DataGridViewTextBoxColumn colTipo =
                new DataGridViewTextBoxColumn();

            colTipo.Name = "Tipo";
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo";

            dgvEquipos.Columns.Add(colTipo);

            DataGridViewTextBoxColumn colMarca =
                new DataGridViewTextBoxColumn();

            colMarca.Name = "Marca";
            colMarca.DataPropertyName = "Marca";
            colMarca.HeaderText = "Marca";

            dgvEquipos.Columns.Add(colMarca);

            DataGridViewTextBoxColumn colModelo =
                new DataGridViewTextBoxColumn();

            colModelo.Name = "Modelo";
            colModelo.DataPropertyName = "Modelo";
            colModelo.HeaderText = "Modelo";

            dgvEquipos.Columns.Add(colModelo);

            DataGridViewTextBoxColumn colSerie =
                new DataGridViewTextBoxColumn();

            colSerie.Name = "NumeroSerie";
            colSerie.DataPropertyName = "NumeroSerie";
            colSerie.HeaderText = "N.º Serie";

            dgvEquipos.Columns.Add(colSerie);

            DataGridViewTextBoxColumn colUsuario =
                new DataGridViewTextBoxColumn();

            colUsuario.Name = "UsuarioAsignado";
            colUsuario.DataPropertyName = "UsuarioAsignado";
            colUsuario.HeaderText = "Usuario";

            dgvEquipos.Columns.Add(colUsuario);

            DataGridViewTextBoxColumn colArea =
                new DataGridViewTextBoxColumn();

            colArea.Name = "Area";
            colArea.DataPropertyName = "Area";
            colArea.HeaderText = "Área";

            dgvEquipos.Columns.Add(colArea);

            DataGridViewTextBoxColumn colEstado =
                new DataGridViewTextBoxColumn();

            colEstado.Name = "Estado";
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";

            dgvEquipos.Columns.Add(colEstado);
        }


        private void CargarEquipos()
        {
            try
            {
                List<Equipo> equipos =
                    equipoDAO.ObtenerTodos();

                dgvEquipos.DataSource = equipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los equipos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void txtBuscar_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string texto =
                    txtBuscar.Text.Trim();

                if (string.IsNullOrEmpty(texto))
                {
                    CargarEquipos();
                    return;
                }

                List<Equipo> equipos =
                    equipoDAO.Buscar(texto);

                dgvEquipos.DataSource = equipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al realizar la búsqueda.\n\n" +
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
            EquipoForm form =
                new EquipoForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos();
            }
        }

       

        private void btnEditar_Click(
            object sender,
            EventArgs e)
        {
            EditarEquipoSeleccionado();
        }

    

        private void dgvEquipos_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditarEquipoSeleccionado();
            }
        }


        private void EditarEquipoSeleccionado()
        {
            if (dgvEquipos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecciona un equipo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Equipo equipo =
                dgvEquipos.CurrentRow.DataBoundItem
                as Equipo;

            if (equipo == null)
            {
                return;
            }

            EquipoForm form =
                new EquipoForm(equipo);

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarEquipos();
            }
        }


        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecciona un equipo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Equipo equipo =
                dgvEquipos.CurrentRow.DataBoundItem
                as Equipo;

            if (equipo == null)
            {
                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Seguro que deseas eliminar el equipo?\n\n" +
                    "Código: " + equipo.Codigo,
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool eliminado =
                    equipoDAO.Eliminar(equipo.Id);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Equipo eliminado correctamente.",
                        "Correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarEquipos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el equipo.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscar.Clear();

            CargarEquipos();
        }
    }
}