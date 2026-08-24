namespace GestorMantenimiento
{
    partial class GarantiasForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardVigentes;
        private System.Windows.Forms.Panel cardPorVencer;
        private System.Windows.Forms.Panel cardVencidas;

        private System.Windows.Forms.Label lblNumeroVigentes;
        private System.Windows.Forms.Label lblNumeroPorVencer;
        private System.Windows.Forms.Label lblNumeroVencidas;

        private System.Windows.Forms.Label lblTextoVigentes;
        private System.Windows.Forms.Label lblTextoPorVencer;
        private System.Windows.Forms.Label lblTextoVencidas;

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;

        private System.Windows.Forms.DataGridView dgvGarantias;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;


        protected override void Dispose(bool disposing)
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

            this.cardVigentes =
                new System.Windows.Forms.Panel();

            this.lblNumeroVigentes =
                new System.Windows.Forms.Label();

            this.lblTextoVigentes =
                new System.Windows.Forms.Label();

            this.cardPorVencer =
                new System.Windows.Forms.Panel();

            this.lblNumeroPorVencer =
                new System.Windows.Forms.Label();

            this.lblTextoPorVencer =
                new System.Windows.Forms.Label();

            this.cardVencidas =
                new System.Windows.Forms.Panel();

            this.lblNumeroVencidas =
                new System.Windows.Forms.Label();

            this.lblTextoVencidas =
                new System.Windows.Forms.Label();

            this.txtBuscar =
                new System.Windows.Forms.TextBox();

            this.btnActualizar =
                new System.Windows.Forms.Button();

            this.btnCerrar =
                new System.Windows.Forms.Button();

            this.dgvGarantias =
                new System.Windows.Forms.DataGridView();

            this.colId =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colCodigo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTipo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMarca =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colModelo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colFecha =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDias =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colEstado =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelSuperior.SuspendLayout();

            this.cardVigentes.SuspendLayout();

            this.cardPorVencer.SuspendLayout();

            this.cardVencidas.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvGarantias)).BeginInit();

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
                new System.Drawing.Size(1100, 105);

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

            this.lblTitulo.Size =
                new System.Drawing.Size(155, 45);

            this.lblTitulo.Text =
                "Garantías";



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

            this.lblSubtitulo.Size =
                new System.Drawing.Size(265, 19);

            this.lblSubtitulo.Text =
                "Control y seguimiento de garantías";


            this.cardVigentes.BackColor =
                System.Drawing.Color.White;

            this.cardVigentes.Location =
                new System.Drawing.Point(30, 125);

            this.cardVigentes.Name =
                "cardVigentes";

            this.cardVigentes.Size =
                new System.Drawing.Size(220, 85);

            this.cardVigentes.Controls.Add(
                this.lblTextoVigentes);

            this.cardVigentes.Controls.Add(
                this.lblNumeroVigentes);


            this.lblNumeroVigentes.AutoSize = true;

            this.lblNumeroVigentes.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroVigentes.ForeColor =
                System.Drawing.Color.FromArgb(
                    46, 125, 50);

            this.lblNumeroVigentes.Location =
                new System.Drawing.Point(15, 8);

            this.lblNumeroVigentes.Name =
                "lblNumeroVigentes";

            this.lblNumeroVigentes.Text =
                "0";


            this.lblTextoVigentes.AutoSize = true;

            this.lblTextoVigentes.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoVigentes.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoVigentes.Location =
                new System.Drawing.Point(18, 55);

            this.lblTextoVigentes.Name =
                "lblTextoVigentes";

            this.lblTextoVigentes.Text =
                "Garantías vigentes";

            this.cardPorVencer.BackColor =
                System.Drawing.Color.White;

            this.cardPorVencer.Location =
                new System.Drawing.Point(270, 125);

            this.cardPorVencer.Name =
                "cardPorVencer";

            this.cardPorVencer.Size =
                new System.Drawing.Size(220, 85);

            this.cardPorVencer.Controls.Add(
                this.lblTextoPorVencer);

            this.cardPorVencer.Controls.Add(
                this.lblNumeroPorVencer);


            this.lblNumeroPorVencer.AutoSize = true;

            this.lblNumeroPorVencer.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroPorVencer.ForeColor =
                System.Drawing.Color.FromArgb(
                    245, 166, 35);

            this.lblNumeroPorVencer.Location =
                new System.Drawing.Point(15, 8);

            this.lblNumeroPorVencer.Name =
                "lblNumeroPorVencer";

            this.lblNumeroPorVencer.Text =
                "0";


            this.lblTextoPorVencer.AutoSize = true;

            this.lblTextoPorVencer.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoPorVencer.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoPorVencer.Location =
                new System.Drawing.Point(18, 55);

            this.lblTextoPorVencer.Name =
                "lblTextoPorVencer";

            this.lblTextoPorVencer.Text =
                "Vencen en 30 días";



            this.cardVencidas.BackColor =
                System.Drawing.Color.White;

            this.cardVencidas.Location =
                new System.Drawing.Point(510, 125);

            this.cardVencidas.Name =
                "cardVencidas";

            this.cardVencidas.Size =
                new System.Drawing.Size(220, 85);

            this.cardVencidas.Controls.Add(
                this.lblTextoVencidas);

            this.cardVencidas.Controls.Add(
                this.lblNumeroVencidas);


            this.lblNumeroVencidas.AutoSize = true;

            this.lblNumeroVencidas.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroVencidas.ForeColor =
                System.Drawing.Color.FromArgb(
                    198, 40, 40);

            this.lblNumeroVencidas.Location =
                new System.Drawing.Point(15, 8);

            this.lblNumeroVencidas.Name =
                "lblNumeroVencidas";

            this.lblNumeroVencidas.Text =
                "0";


            this.lblTextoVencidas.AutoSize = true;

            this.lblTextoVencidas.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblTextoVencidas.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoVencidas.Location =
                new System.Drawing.Point(18, 55);

            this.lblTextoVencidas.Name =
                "lblTextoVencidas";

            this.lblTextoVencidas.Text =
                "Garantías vencidas";


            this.txtBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtBuscar.Location =
                new System.Drawing.Point(30, 235);

            this.txtBuscar.Name =
                "txtBuscar";

            this.txtBuscar.Size =
                new System.Drawing.Size(300, 25);

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
                new System.Drawing.Point(345, 233);

            this.btnActualizar.Name =
                "btnActualizar";

            this.btnActualizar.Size =
                new System.Drawing.Size(110, 30);

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
                    9F);

            this.btnCerrar.ForeColor =
                System.Drawing.Color.White;

            this.btnCerrar.Location =
                new System.Drawing.Point(465, 233);

            this.btnCerrar.Name =
                "btnCerrar";

            this.btnCerrar.Size =
                new System.Drawing.Size(100, 30);

            this.btnCerrar.Text =
                "Cerrar";

            this.btnCerrar.UseVisualStyleBackColor =
                false;

            this.btnCerrar.Click +=
                new System.EventHandler(
                    this.btnCerrar_Click);


            this.dgvGarantias.AllowUserToAddRows =
                false;

            this.dgvGarantias.AllowUserToDeleteRows =
                false;

            this.dgvGarantias.AllowUserToResizeRows =
                false;

            this.dgvGarantias.AutoGenerateColumns =
                false;

            this.dgvGarantias.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvGarantias.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvGarantias.ColumnHeadersHeight =
                38;

            this.dgvGarantias.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvGarantias.EnableHeadersVisualStyles =
                false;

            this.dgvGarantias.Location =
                new System.Drawing.Point(30, 280);

            this.dgvGarantias.Name =
                "dgvGarantias";

            this.dgvGarantias.ReadOnly =
                true;

            this.dgvGarantias.RowHeadersVisible =
                false;

            this.dgvGarantias.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvGarantias.Size =
                new System.Drawing.Size(1020, 330);

            this.dgvGarantias.TabIndex = 7;


           

            this.colId.HeaderText =
                "ID";

            this.colId.Name =
                "colId";

            this.colId.DataPropertyName =
                "Id";

            this.colId.Visible =
                false;


            this.colCodigo.HeaderText =
                "Código";

            this.colCodigo.Name =
                "colCodigo";

            this.colCodigo.Width =
                100;


            this.colTipo.HeaderText =
                "Tipo";

            this.colTipo.Name =
                "colTipo";

            this.colTipo.Width =
                130;


            this.colMarca.HeaderText =
                "Marca";

            this.colMarca.Name =
                "colMarca";

            this.colMarca.Width =
                120;


            this.colModelo.HeaderText =
                "Modelo";

            this.colModelo.Name =
                "colModelo";

            this.colModelo.Width =
                140;


            this.colFecha.HeaderText =
                "Vencimiento";

            this.colFecha.Name =
                "colFecha";

            this.colFecha.Width =
                120;


            this.colDias.HeaderText =
                "Tiempo";

            this.colDias.Name =
                "colDias";

            this.colDias.Width =
                120;


            this.colEstado.HeaderText =
                "Estado";

            this.colEstado.Name =
                "colEstado";

            this.colEstado.Width =
                130;


            this.dgvGarantias.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colId,
                    this.colCodigo,
                    this.colTipo,
                    this.colMarca,
                    this.colModelo,
                    this.colFecha,
                    this.colDias,
                    this.colEstado
                });



            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1100, 650);

            this.Controls.Add(
                this.dgvGarantias);

            this.Controls.Add(
                this.btnCerrar);

            this.Controls.Add(
                this.btnActualizar);

            this.Controls.Add(
                this.txtBuscar);

            this.Controls.Add(
                this.cardVencidas);

            this.Controls.Add(
                this.cardPorVencer);

            this.Controls.Add(
                this.cardVigentes);

            this.Controls.Add(
                this.panelSuperior);

            this.Name =
                "GarantiasForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestor de Mantenimiento - Garantías";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;


            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.cardVigentes.ResumeLayout(false);
            this.cardVigentes.PerformLayout();

            this.cardPorVencer.ResumeLayout(false);
            this.cardPorVencer.PerformLayout();

            this.cardVencidas.ResumeLayout(false);
            this.cardVencidas.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvGarantias)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}