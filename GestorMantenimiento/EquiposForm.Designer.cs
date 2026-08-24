namespace GestorMantenimiento
{
    partial class EquiposForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelTabla;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.DataGridView dgvEquipos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();

            this.dgvEquipos = new System.Windows.Forms.DataGridView();

            this.panelPrincipal.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelTabla.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();

            this.SuspendLayout();


            this.panelPrincipal.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelPrincipal.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.panelPrincipal.Controls.Add(
                this.panelTabla);

            this.panelPrincipal.Controls.Add(
                this.panelAcciones);

            this.panelPrincipal.Controls.Add(
                this.panelTitulo);

            this.panelPrincipal.Location =
                new System.Drawing.Point(0, 0);

            this.panelPrincipal.Name =
                "panelPrincipal";

            this.panelPrincipal.Size =
                new System.Drawing.Size(1200, 700);


            this.panelTitulo.BackColor =
                System.Drawing.Color.White;

            this.panelTitulo.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelTitulo.Height = 100;

            this.panelTitulo.Controls.Add(
                this.lblSubtitulo);

            this.panelTitulo.Controls.Add(
                this.lblTitulo);


            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(35, 40, 45);

            this.lblTitulo.Location =
                new System.Drawing.Point(35, 18);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Equipos";


            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSubtitulo.Location =
                new System.Drawing.Point(39, 65);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Text =
                "Administración de equipos de tecnología";

            

            this.panelAcciones.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelAcciones.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelAcciones.Height = 75;

            this.panelAcciones.Controls.Add(
                this.btnActualizar);

            this.panelAcciones.Controls.Add(
                this.btnEliminar);

            this.panelAcciones.Controls.Add(
                this.btnEditar);

            this.panelAcciones.Controls.Add(
                this.btnNuevo);

            this.panelAcciones.Controls.Add(
                this.txtBuscar);

      

            this.txtBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtBuscar.Location =
                new System.Drawing.Point(35, 18);

            this.txtBuscar.Name =
                "txtBuscar";

            this.txtBuscar.Size =
                new System.Drawing.Size(350, 25);

            this.txtBuscar.TabIndex = 0;

            this.txtBuscar.TextChanged +=
                new System.EventHandler(
                    this.txtBuscar_TextChanged);


            this.btnNuevo.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.btnNuevo.FlatAppearance.BorderSize = 0;

            this.btnNuevo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNuevo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnNuevo.ForeColor =
                System.Drawing.Color.White;

            this.btnNuevo.Location =
                new System.Drawing.Point(410, 15);

            this.btnNuevo.Name =
                "btnNuevo";

            this.btnNuevo.Size =
                new System.Drawing.Size(125, 35);

            this.btnNuevo.TabIndex = 1;

            this.btnNuevo.Text =
                "+ Nuevo";

            this.btnNuevo.UseVisualStyleBackColor = false;

            this.btnNuevo.Click +=
                new System.EventHandler(
                    this.btnNuevo_Click);


            this.btnEditar.BackColor =
                System.Drawing.Color.White;

            this.btnEditar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEditar.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(210, 215, 220);

            this.btnEditar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnEditar.ForeColor =
                System.Drawing.Color.FromArgb(40, 45, 50);

            this.btnEditar.Location =
                new System.Drawing.Point(545, 15);

            this.btnEditar.Name =
                "btnEditar";

            this.btnEditar.Size =
                new System.Drawing.Size(105, 35);

            this.btnEditar.TabIndex = 2;

            this.btnEditar.Text =
                "Editar";

            this.btnEditar.Click +=
                new System.EventHandler(
                    this.btnEditar_Click);


            this.btnEliminar.BackColor =
                System.Drawing.Color.White;

            this.btnEliminar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(210, 215, 220);

            this.btnEliminar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnEliminar.ForeColor =
                System.Drawing.Color.FromArgb(180, 50, 50);

            this.btnEliminar.Location =
                new System.Drawing.Point(660, 15);

            this.btnEliminar.Name =
                "btnEliminar";

            this.btnEliminar.Size =
                new System.Drawing.Size(105, 35);

            this.btnEliminar.TabIndex = 3;

            this.btnEliminar.Text =
                "Eliminar";

            this.btnEliminar.Click +=
                new System.EventHandler(
                    this.btnEliminar_Click);


            this.btnActualizar.BackColor =
                System.Drawing.Color.White;

            this.btnActualizar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnActualizar.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(210, 215, 220);

            this.btnActualizar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnActualizar.ForeColor =
                System.Drawing.Color.FromArgb(40, 45, 50);

            this.btnActualizar.Location =
                new System.Drawing.Point(775, 15);

            this.btnActualizar.Name =
                "btnActualizar";

            this.btnActualizar.Size =
                new System.Drawing.Size(110, 35);

            this.btnActualizar.TabIndex = 4;

            this.btnActualizar.Text =
                "Actualizar";

            this.btnActualizar.Click +=
                new System.EventHandler(
                    this.btnActualizar_Click);


            this.panelTabla.BackColor =
                System.Drawing.Color.White;

            this.panelTabla.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.panelTabla.Padding =
                new System.Windows.Forms.Padding(20);

            this.panelTabla.Controls.Add(
                this.dgvEquipos);


            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.AllowUserToResizeRows = false;

            this.dgvEquipos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvEquipos.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvEquipos.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvEquipos.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvEquipos.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvEquipos.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.dgvEquipos.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvEquipos.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.dgvEquipos.ColumnHeadersHeight = 40;

            this.dgvEquipos.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvEquipos.EnableHeadersVisualStyles = false;

            this.dgvEquipos.Location =
                new System.Drawing.Point(20, 20);

            this.dgvEquipos.MultiSelect = false;

            this.dgvEquipos.Name =
                "dgvEquipos";

            this.dgvEquipos.ReadOnly = true;

            this.dgvEquipos.RowHeadersVisible = false;

            this.dgvEquipos.RowTemplate.Height = 35;

            this.dgvEquipos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvEquipos.TabIndex = 0;

            this.dgvEquipos.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvEquipos_CellDoubleClick);


            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(
                this.panelPrincipal);

            this.Name =
                "EquiposForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Equipos - Gestor de Mantenimiento";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvEquipos)).EndInit();

            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();

            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();

            this.panelTabla.ResumeLayout(false);

            this.panelPrincipal.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}