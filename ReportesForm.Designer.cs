namespace GestorMantenimiento
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardEquipos;
        private System.Windows.Forms.Panel cardMantenimientos;
        private System.Windows.Forms.Panel cardGarantias;
        private System.Windows.Forms.Panel cardCosto;

        private System.Windows.Forms.Label lblNumeroEquipos;
        private System.Windows.Forms.Label lblNumeroMantenimientos;
        private System.Windows.Forms.Label lblNumeroGarantias;
        private System.Windows.Forms.Label lblNumeroCosto;

        private System.Windows.Forms.Label lblTextoEquipos;
        private System.Windows.Forms.Label lblTextoMantenimientos;
        private System.Windows.Forms.Label lblTextoGarantias;
        private System.Windows.Forms.Label lblTextoCosto;

        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.ComboBox cmbTipoReporte;

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;

        private System.Windows.Forms.Label lblCantidadResultados;

        private System.Windows.Forms.DataGridView dgvReportes;


        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.panelSuperior =
                new System.Windows.Forms.Panel();

            this.lblTitulo =
                new System.Windows.Forms.Label();

            this.lblSubtitulo =
                new System.Windows.Forms.Label();

            this.cardEquipos =
                new System.Windows.Forms.Panel();

            this.lblNumeroEquipos =
                new System.Windows.Forms.Label();

            this.lblTextoEquipos =
                new System.Windows.Forms.Label();

            this.cardMantenimientos =
                new System.Windows.Forms.Panel();

            this.lblNumeroMantenimientos =
                new System.Windows.Forms.Label();

            this.lblTextoMantenimientos =
                new System.Windows.Forms.Label();

            this.cardGarantias =
                new System.Windows.Forms.Panel();

            this.lblNumeroGarantias =
                new System.Windows.Forms.Label();

            this.lblTextoGarantias =
                new System.Windows.Forms.Label();

            this.cardCosto =
                new System.Windows.Forms.Panel();

            this.lblNumeroCosto =
                new System.Windows.Forms.Label();

            this.lblTextoCosto =
                new System.Windows.Forms.Label();

            this.lblTipoReporte =
                new System.Windows.Forms.Label();

            this.cmbTipoReporte =
                new System.Windows.Forms.ComboBox();

            this.lblBuscar =
                new System.Windows.Forms.Label();

            this.txtBuscar =
                new System.Windows.Forms.TextBox();

            this.btnActualizar =
                new System.Windows.Forms.Button();

            this.btnCerrar =
                new System.Windows.Forms.Button();

            this.lblCantidadResultados =
                new System.Windows.Forms.Label();

            this.dgvReportes =
                new System.Windows.Forms.DataGridView();


            this.panelSuperior.SuspendLayout();

            this.cardEquipos.SuspendLayout();

            this.cardMantenimientos.SuspendLayout();

            this.cardGarantias.SuspendLayout();

            this.cardCosto.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReportes)).BeginInit();

            this.SuspendLayout();



            this.panelSuperior.BackColor =
                System.Drawing.Color.White;

            this.panelSuperior.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelSuperior.Location =
                new System.Drawing.Point(0, 0);

            this.panelSuperior.Name =
                "panelSuperior";

            this.panelSuperior.Size =
                new System.Drawing.Size(1200, 105);

            this.panelSuperior.TabIndex = 0;

            this.panelSuperior.Controls.Add(
                this.lblSubtitulo);

            this.panelSuperior.Controls.Add(
                this.lblTitulo);



            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(
                    35, 40, 45);

            this.lblTitulo.Location =
                new System.Drawing.Point(30, 17);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Reportes";



            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSubtitulo.Location =
                new System.Drawing.Point(34, 64);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Text =
                "Consulta y análisis de la información del sistema";



            this.cardEquipos.BackColor =
                System.Drawing.Color.White;

            this.cardEquipos.Location =
                new System.Drawing.Point(30, 125);

            this.cardEquipos.Name =
                "cardEquipos";

            this.cardEquipos.Size =
                new System.Drawing.Size(245, 90);

            this.cardEquipos.Controls.Add(
                this.lblTextoEquipos);

            this.cardEquipos.Controls.Add(
                this.lblNumeroEquipos);


            this.lblNumeroEquipos.AutoSize = true;

            this.lblNumeroEquipos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroEquipos.ForeColor =
                System.Drawing.Color.FromArgb(
                    0, 32, 74);

            this.lblNumeroEquipos.Location =
                new System.Drawing.Point(18, 8);

            this.lblNumeroEquipos.Name =
                "lblNumeroEquipos";

            this.lblNumeroEquipos.Text =
                "0";


            this.lblTextoEquipos.AutoSize = true;

            this.lblTextoEquipos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoEquipos.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoEquipos.Location =
                new System.Drawing.Point(20, 58);

            this.lblTextoEquipos.Name =
                "lblTextoEquipos";

            this.lblTextoEquipos.Text =
                "Equipos registrados";


            this.cardMantenimientos.BackColor =
                System.Drawing.Color.White;

            this.cardMantenimientos.Location =
                new System.Drawing.Point(295, 125);

            this.cardMantenimientos.Name =
                "cardMantenimientos";

            this.cardMantenimientos.Size =
                new System.Drawing.Size(245, 90);

            this.cardMantenimientos.Controls.Add(
                this.lblTextoMantenimientos);

            this.cardMantenimientos.Controls.Add(
                this.lblNumeroMantenimientos);


            this.lblNumeroMantenimientos.AutoSize = true;

            this.lblNumeroMantenimientos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroMantenimientos.ForeColor =
                System.Drawing.Color.FromArgb(
                    40, 167, 69);

            this.lblNumeroMantenimientos.Location =
                new System.Drawing.Point(18, 8);

            this.lblNumeroMantenimientos.Name =
                "lblNumeroMantenimientos";

            this.lblNumeroMantenimientos.Text =
                "0";


            this.lblTextoMantenimientos.AutoSize = true;

            this.lblTextoMantenimientos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoMantenimientos.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoMantenimientos.Location =
                new System.Drawing.Point(20, 58);

            this.lblTextoMantenimientos.Name =
                "lblTextoMantenimientos";

            this.lblTextoMantenimientos.Text =
                "Mantenimientos realizados";



            this.cardGarantias.BackColor =
                System.Drawing.Color.White;

            this.cardGarantias.Location =
                new System.Drawing.Point(560, 125);

            this.cardGarantias.Name =
                "cardGarantias";

            this.cardGarantias.Size =
                new System.Drawing.Size(245, 90);

            this.cardGarantias.Controls.Add(
                this.lblTextoGarantias);

            this.cardGarantias.Controls.Add(
                this.lblNumeroGarantias);


            this.lblNumeroGarantias.AutoSize = true;

            this.lblNumeroGarantias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroGarantias.ForeColor =
                System.Drawing.Color.FromArgb(
                    245, 166, 35);

            this.lblNumeroGarantias.Location =
                new System.Drawing.Point(18, 8);

            this.lblNumeroGarantias.Name =
                "lblNumeroGarantias";

            this.lblNumeroGarantias.Text =
                "0";


            this.lblTextoGarantias.AutoSize = true;

            this.lblTextoGarantias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoGarantias.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoGarantias.Location =
                new System.Drawing.Point(20, 58);

            this.lblTextoGarantias.Name =
                "lblTextoGarantias";

            this.lblTextoGarantias.Text =
                "Garantías vigentes";



            this.cardCosto.BackColor =
                System.Drawing.Color.White;

            this.cardCosto.Location =
                new System.Drawing.Point(825, 125);

            this.cardCosto.Name =
                "cardCosto";

            this.cardCosto.Size =
                new System.Drawing.Size(245, 90);

            this.cardCosto.Controls.Add(
                this.lblTextoCosto);

            this.cardCosto.Controls.Add(
                this.lblNumeroCosto);


            this.lblNumeroCosto.AutoSize = true;

            this.lblNumeroCosto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroCosto.ForeColor =
                System.Drawing.Color.FromArgb(
                    198, 40, 40);

            this.lblNumeroCosto.Location =
                new System.Drawing.Point(18, 10);

            this.lblNumeroCosto.Name =
                "lblNumeroCosto";

            this.lblNumeroCosto.Text =
                "$0.00";


            this.lblTextoCosto.AutoSize = true;

            this.lblTextoCosto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoCosto.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoCosto.Location =
                new System.Drawing.Point(20, 58);

            this.lblTextoCosto.Name =
                "lblTextoCosto";

            this.lblTextoCosto.Text =
                "Costo total mantenimiento";


            

            this.lblTipoReporte.AutoSize = true;

            this.lblTipoReporte.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblTipoReporte.ForeColor =
                System.Drawing.Color.FromArgb(
                    45, 50, 55);

            this.lblTipoReporte.Location =
                new System.Drawing.Point(30, 238);

            this.lblTipoReporte.Name =
                "lblTipoReporte";

            this.lblTipoReporte.Text =
                "Reporte:";


            this.cmbTipoReporte.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbTipoReporte.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.cmbTipoReporte.FormattingEnabled = true;

            this.cmbTipoReporte.Location =
                new System.Drawing.Point(90, 234);

            this.cmbTipoReporte.Name =
                "cmbTipoReporte";

            this.cmbTipoReporte.Size =
                new System.Drawing.Size(180, 25);

            this.cmbTipoReporte.TabIndex = 1;

            this.cmbTipoReporte.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbTipoReporte_SelectedIndexChanged);


            

            this.lblBuscar.AutoSize = true;

            this.lblBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblBuscar.Location =
                new System.Drawing.Point(295, 238);

            this.lblBuscar.Name =
                "lblBuscar";

            this.lblBuscar.Text =
                "Buscar:";


            this.txtBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtBuscar.Location =
                new System.Drawing.Point(345, 234);

            this.txtBuscar.Name =
                "txtBuscar";

            this.txtBuscar.Size =
                new System.Drawing.Size(260, 25);

            this.txtBuscar.TabIndex = 2;

            this.txtBuscar.TextChanged +=
                new System.EventHandler(
                    this.txtBuscar_TextChanged);


      

            this.btnActualizar.BackColor =
                System.Drawing.Color.FromArgb(
                    255, 193, 7);

            this.btnActualizar.FlatAppearance.BorderSize =
                0;

            this.btnActualizar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnActualizar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnActualizar.ForeColor =
                System.Drawing.Color.FromArgb(
                    25, 32, 42);

            this.btnActualizar.Location =
                new System.Drawing.Point(625, 232);

            this.btnActualizar.Name =
                "btnActualizar";

            this.btnActualizar.Size =
                new System.Drawing.Size(110, 30);

            this.btnActualizar.TabIndex = 3;

            this.btnActualizar.Text =
                "Actualizar";

            this.btnActualizar.UseVisualStyleBackColor =
                false;

            this.btnActualizar.Click +=
                new System.EventHandler(
                    this.btnActualizar_Click);


            this.btnCerrar.BackColor =
                System.Drawing.Color.FromArgb(
                    25, 32, 42);

            this.btnCerrar.FlatAppearance.BorderSize =
                0;

            this.btnCerrar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCerrar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnCerrar.ForeColor =
                System.Drawing.Color.White;

            this.btnCerrar.Location =
                new System.Drawing.Point(745, 232);

            this.btnCerrar.Name =
                "btnCerrar";

            this.btnCerrar.Size =
                new System.Drawing.Size(100, 30);

            this.btnCerrar.TabIndex = 4;

            this.btnCerrar.Text =
                "Cerrar";

            this.btnCerrar.UseVisualStyleBackColor =
                false;

            this.btnCerrar.Click +=
                new System.EventHandler(
                    this.btnCerrar_Click);


            this.lblCantidadResultados.AutoSize = true;

            this.lblCantidadResultados.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblCantidadResultados.ForeColor =
                System.Drawing.Color.Gray;

            this.lblCantidadResultados.Location =
                new System.Drawing.Point(
                    900,
                    238);

            this.lblCantidadResultados.Name =
                "lblCantidadResultados";

            this.lblCantidadResultados.Text =
                "0 registros";



            this.dgvReportes.AllowUserToAddRows =
                false;

            this.dgvReportes.AllowUserToDeleteRows =
                false;

            this.dgvReportes.AllowUserToResizeRows =
                false;

            this.dgvReportes.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvReportes.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvReportes.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvReportes.ColumnHeadersHeight =
                38;

            this.dgvReportes.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvReportes.EnableHeadersVisualStyles =
                false;

            this.dgvReportes.GridColor =
                System.Drawing.Color.FromArgb(
                    225, 228, 232);

            this.dgvReportes.Location =
                new System.Drawing.Point(30, 280);

            this.dgvReportes.Name =
                "dgvReportes";

            this.dgvReportes.ReadOnly =
                true;

            this.dgvReportes.RowHeadersVisible =
                false;

            this.dgvReportes.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvReportes.Size =
                new System.Drawing.Size(1140, 390);

            this.dgvReportes.TabIndex = 5;



            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(
                    1200,
                    700);

            this.Controls.Add(
                this.dgvReportes);

            this.Controls.Add(
                this.lblCantidadResultados);

            this.Controls.Add(
                this.btnCerrar);

            this.Controls.Add(
                this.btnActualizar);

            this.Controls.Add(
                this.txtBuscar);

            this.Controls.Add(
                this.lblBuscar);

            this.Controls.Add(
                this.cmbTipoReporte);

            this.Controls.Add(
                this.lblTipoReporte);

            this.Controls.Add(
                this.cardCosto);

            this.Controls.Add(
                this.cardGarantias);

            this.Controls.Add(
                this.cardMantenimientos);

            this.Controls.Add(
                this.cardEquipos);

            this.Controls.Add(
                this.panelSuperior);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = true;

            this.Name =
                "ReportesForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestor de Mantenimiento - Reportes";


            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.cardEquipos.ResumeLayout(false);
            this.cardEquipos.PerformLayout();

            this.cardMantenimientos.ResumeLayout(false);
            this.cardMantenimientos.PerformLayout();

            this.cardGarantias.ResumeLayout(false);
            this.cardGarantias.PerformLayout();

            this.cardCosto.ResumeLayout(false);
            this.cardCosto.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReportes)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}