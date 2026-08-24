namespace GestorMantenimiento
{
    partial class MantenimientosForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Panel panelFormulario;

        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cmbEquipo;

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;

        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox txtProblema;

        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;

        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.TextBox txtSolucion;

        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;

        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvMantenimientos;

        private System.Windows.Forms.Label lblRegistros;

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
            this.components = new System.ComponentModel.Container();

            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.panelFormulario = new System.Windows.Forms.Panel();

            this.lblEquipo = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();

            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();

            this.lblProblema = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();

            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();

            this.lblSolucion = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();

            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();

            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();

            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvMantenimientos = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();

            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).BeginInit();
            this.SuspendLayout();


            this.panelSuperior.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblTitulo);

            this.panelSuperior.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelSuperior.Location =
                new System.Drawing.Point(0, 0);

            this.panelSuperior.Name =
                "panelSuperior";

            this.panelSuperior.Size =
                new System.Drawing.Size(1200, 85);

            this.panelSuperior.TabIndex = 0;

            

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.White;

            this.lblTitulo.Location =
                new System.Drawing.Point(28, 13);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Size =
                new System.Drawing.Size(230, 42);

            this.lblTitulo.TabIndex = 0;

            this.lblTitulo.Text =
                "Mantenimientos";

         

            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9.5F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(180, 190, 200);

            this.lblSubtitulo.Location =
                new System.Drawing.Point(31, 55);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Size =
                new System.Drawing.Size(290, 17);

            this.lblSubtitulo.TabIndex = 1;

            this.lblSubtitulo.Text =
                "Registro y seguimiento de mantenimiento";


            this.panelBusqueda.BackColor =
                System.Drawing.Color.White;

            this.panelBusqueda.Controls.Add(this.btnEliminar);
            this.panelBusqueda.Controls.Add(this.btnEditar);
            this.panelBusqueda.Controls.Add(this.btnNuevo);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.txtBuscar);

            this.panelBusqueda.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelBusqueda.Location =
                new System.Drawing.Point(0, 85);

            this.panelBusqueda.Name =
                "panelBusqueda";

            this.panelBusqueda.Size =
                new System.Drawing.Size(1200, 65);

            this.panelBusqueda.TabIndex = 1;

            this.txtBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtBuscar.ForeColor =
                System.Drawing.Color.FromArgb(70, 70, 70);

            this.txtBuscar.Location =
                new System.Drawing.Point(30, 17);

            this.txtBuscar.Name =
                "txtBuscar";

            this.txtBuscar.Size =
                new System.Drawing.Size(350, 25);

            this.txtBuscar.TabIndex = 0;

            this.txtBuscar.TextChanged +=
                new System.EventHandler(
                    this.txtBuscar_TextChanged);


            this.btnBuscar.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.btnBuscar.FlatAppearance.BorderSize = 0;

            this.btnBuscar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnBuscar.ForeColor =
                System.Drawing.Color.White;

            this.btnBuscar.Location =
                new System.Drawing.Point(390, 15);

            this.btnBuscar.Name =
                "btnBuscar";

            this.btnBuscar.Size =
                new System.Drawing.Size(90, 30);

            this.btnBuscar.TabIndex = 1;

            this.btnBuscar.Text =
                "Buscar";

            this.btnBuscar.UseVisualStyleBackColor =
                false;

            this.btnBuscar.Click +=
                new System.EventHandler(
                    this.btnBuscar_Click);


            this.btnNuevo.BackColor =
                System.Drawing.Color.FromArgb(255, 193, 7);

            this.btnNuevo.FlatAppearance.BorderSize = 0;

            this.btnNuevo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNuevo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnNuevo.ForeColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.btnNuevo.Location =
                new System.Drawing.Point(785, 15);

            this.btnNuevo.Name =
                "btnNuevo";

            this.btnNuevo.Size =
                new System.Drawing.Size(125, 32);

            this.btnNuevo.TabIndex = 2;

            this.btnNuevo.Text =
                "+ Nuevo";

            this.btnNuevo.UseVisualStyleBackColor =
                false;

            this.btnNuevo.Click +=
                new System.EventHandler(
                    this.btnNuevo_Click);


            this.btnEditar.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.btnEditar.FlatAppearance.BorderSize = 0;

            this.btnEditar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEditar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnEditar.ForeColor =
                System.Drawing.Color.White;

            this.btnEditar.Location =
                new System.Drawing.Point(920, 15);

            this.btnEditar.Name =
                "btnEditar";

            this.btnEditar.Size =
                new System.Drawing.Size(110, 32);

            this.btnEditar.TabIndex = 3;

            this.btnEditar.Text =
                "Editar";

            this.btnEditar.UseVisualStyleBackColor =
                false;

            this.btnEditar.Click +=
                new System.EventHandler(
                    this.btnEditar_Click);


            this.btnEliminar.BackColor =
                System.Drawing.Color.FromArgb(220, 53, 69);

            this.btnEliminar.FlatAppearance.BorderSize = 0;

            this.btnEliminar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnEliminar.ForeColor =
                System.Drawing.Color.White;

            this.btnEliminar.Location =
                new System.Drawing.Point(1040, 15);

            this.btnEliminar.Name =
                "btnEliminar";

            this.btnEliminar.Size =
                new System.Drawing.Size(120, 32);

            this.btnEliminar.TabIndex = 4;

            this.btnEliminar.Text =
                "Eliminar";

            this.btnEliminar.UseVisualStyleBackColor =
                false;

            this.btnEliminar.Click +=
                new System.EventHandler(
                    this.btnEliminar_Click);

        

            this.panelFormulario.BackColor =
                System.Drawing.Color.White;

            this.panelFormulario.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelFormulario.Controls.Add(this.btnCancelar);
            this.panelFormulario.Controls.Add(this.btnGuardar);
            this.panelFormulario.Controls.Add(this.lblObservaciones);
            this.panelFormulario.Controls.Add(this.txtObservaciones);
            this.panelFormulario.Controls.Add(this.dtpFecha);
            this.panelFormulario.Controls.Add(this.lblFecha);
            this.panelFormulario.Controls.Add(this.txtCosto);
            this.panelFormulario.Controls.Add(this.lblCosto);
            this.panelFormulario.Controls.Add(this.txtSolucion);
            this.panelFormulario.Controls.Add(this.lblSolucion);
            this.panelFormulario.Controls.Add(this.txtDiagnostico);
            this.panelFormulario.Controls.Add(this.lblDiagnostico);
            this.panelFormulario.Controls.Add(this.txtProblema);
            this.panelFormulario.Controls.Add(this.lblProblema);
            this.panelFormulario.Controls.Add(this.cmbTipo);
            this.panelFormulario.Controls.Add(this.lblTipo);
            this.panelFormulario.Controls.Add(this.cmbEquipo);
            this.panelFormulario.Controls.Add(this.lblEquipo);

            this.panelFormulario.Location =
                new System.Drawing.Point(30, 165);

            this.panelFormulario.Name =
                "panelFormulario";

            this.panelFormulario.Size =
                new System.Drawing.Size(1140, 300);

            this.panelFormulario.TabIndex = 2;

            this.panelFormulario.Visible = false;


            this.lblEquipo.AutoSize = true;

            this.lblEquipo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblEquipo.ForeColor =
                System.Drawing.Color.FromArgb(50, 55, 60);

            this.lblEquipo.Location =
                new System.Drawing.Point(20, 18);

            this.lblEquipo.Name =
                "lblEquipo";

            this.lblEquipo.Size =
                new System.Drawing.Size(45, 15);

            this.lblEquipo.TabIndex = 0;

            this.lblEquipo.Text =
                "Equipo";

            this.cmbEquipo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbEquipo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.cmbEquipo.FormattingEnabled = true;

            this.cmbEquipo.Location =
                new System.Drawing.Point(20, 40);

            this.cmbEquipo.Name =
                "cmbEquipo";

            this.cmbEquipo.Size =
                new System.Drawing.Size(250, 25);

            this.cmbEquipo.TabIndex = 1;


            this.lblTipo.AutoSize = true;

            this.lblTipo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblTipo.Location =
                new System.Drawing.Point(290, 18);

            this.lblTipo.Name =
                "lblTipo";

            this.lblTipo.Size =
                new System.Drawing.Size(30, 15);

            this.lblTipo.TabIndex = 2;

            this.lblTipo.Text =
                "Tipo";

            this.cmbTipo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbTipo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.cmbTipo.FormattingEnabled = true;

            this.cmbTipo.Items.AddRange(
                new object[]
                {
                    "Preventivo",
                    "Correctivo",
                    "Predictivo",
                    "Emergencia"
                });

            this.cmbTipo.Location =
                new System.Drawing.Point(290, 40);

            this.cmbTipo.Name =
                "cmbTipo";

            this.cmbTipo.Size =
                new System.Drawing.Size(180, 25);

            this.cmbTipo.TabIndex = 3;


            this.lblProblema.AutoSize = true;

            this.lblProblema.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblProblema.Location =
                new System.Drawing.Point(490, 18);

            this.lblProblema.Name =
                "lblProblema";

            this.lblProblema.Size =
                new System.Drawing.Size(60, 15);

            this.lblProblema.TabIndex = 4;

            this.lblProblema.Text =
                "Problema";

            this.txtProblema.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtProblema.Location =
                new System.Drawing.Point(490, 40);

            this.txtProblema.Name =
                "txtProblema";

            this.txtProblema.Size =
                new System.Drawing.Size(300, 25);

            this.txtProblema.TabIndex = 5;

         

            this.lblDiagnostico.AutoSize = true;

            this.lblDiagnostico.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblDiagnostico.Location =
                new System.Drawing.Point(810, 18);

            this.lblDiagnostico.Name =
                "lblDiagnostico";

            this.lblDiagnostico.Size =
                new System.Drawing.Size(71, 15);

            this.lblDiagnostico.TabIndex = 6;

            this.lblDiagnostico.Text =
                "Diagnóstico";

            this.txtDiagnostico.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtDiagnostico.Location =
                new System.Drawing.Point(810, 40);

            this.txtDiagnostico.Name =
                "txtDiagnostico";

            this.txtDiagnostico.Size =
                new System.Drawing.Size(300, 25);

            this.txtDiagnostico.TabIndex = 7;

            

            this.lblSolucion.AutoSize = true;

            this.lblSolucion.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblSolucion.Location =
                new System.Drawing.Point(20, 90);

            this.lblSolucion.Name =
                "lblSolucion";

            this.lblSolucion.Size =
                new System.Drawing.Size(51, 15);

            this.lblSolucion.TabIndex = 8;

            this.lblSolucion.Text =
                "Solución";

            this.txtSolucion.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtSolucion.Location =
                new System.Drawing.Point(20, 112);

            this.txtSolucion.Multiline = true;

            this.txtSolucion.Name =
                "txtSolucion";

            this.txtSolucion.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtSolucion.Size =
                new System.Drawing.Size(450, 65);

            this.txtSolucion.TabIndex = 9;

            
            this.lblCosto.AutoSize = true;

            this.lblCosto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblCosto.Location =
                new System.Drawing.Point(490, 90);

            this.lblCosto.Name =
                "lblCosto";

            this.lblCosto.Size =
                new System.Drawing.Size(35, 15);

            this.lblCosto.TabIndex = 10;

            this.lblCosto.Text =
                "Costo";

            this.txtCosto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtCosto.Location =
                new System.Drawing.Point(490, 112);

            this.txtCosto.Name =
                "txtCosto";

            this.txtCosto.Size =
                new System.Drawing.Size(140, 25);

            this.txtCosto.TabIndex = 11;

            this.txtCosto.Text = "0";


            this.lblFecha.AutoSize = true;

            this.lblFecha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblFecha.Location =
                new System.Drawing.Point(650, 90);

            this.lblFecha.Name =
                "lblFecha";

            this.lblFecha.Size =
                new System.Drawing.Size(37, 15);

            this.lblFecha.TabIndex = 12;

            this.lblFecha.Text =
                "Fecha";

            this.dtpFecha.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.dtpFecha.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpFecha.Location =
                new System.Drawing.Point(650, 112);

            this.dtpFecha.Name =
                "dtpFecha";

            this.dtpFecha.Size =
                new System.Drawing.Size(150, 23);

            this.dtpFecha.TabIndex = 13;


            this.lblObservaciones.AutoSize = true;

            this.lblObservaciones.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblObservaciones.Location =
                new System.Drawing.Point(820, 90);

            this.lblObservaciones.Name =
                "lblObservaciones";

            this.lblObservaciones.Size =
                new System.Drawing.Size(88, 15);

            this.lblObservaciones.TabIndex = 14;

            this.lblObservaciones.Text =
                "Observaciones";

            this.txtObservaciones.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.txtObservaciones.Location =
                new System.Drawing.Point(820, 112);

            this.txtObservaciones.Multiline = true;

            this.txtObservaciones.Name =
                "txtObservaciones";

            this.txtObservaciones.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtObservaciones.Size =
                new System.Drawing.Size(290, 65);

            this.txtObservaciones.TabIndex = 15;


            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.btnGuardar.FlatAppearance.BorderSize = 0;

            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnGuardar.ForeColor =
                System.Drawing.Color.White;

            this.btnGuardar.Location =
                new System.Drawing.Point(820, 225);

            this.btnGuardar.Name =
                "btnGuardar";

            this.btnGuardar.Size =
                new System.Drawing.Size(130, 35);

            this.btnGuardar.TabIndex = 16;

            this.btnGuardar.Text =
                "Guardar";

            this.btnGuardar.UseVisualStyleBackColor =
                false;

            this.btnGuardar.Click +=
                new System.EventHandler(
                    this.btnGuardar_Click);

         

            this.btnCancelar.BackColor =
                System.Drawing.Color.FromArgb(235, 238, 242);

            this.btnCancelar.FlatAppearance.BorderSize = 0;

            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.btnCancelar.ForeColor =
                System.Drawing.Color.FromArgb(60, 65, 70);

            this.btnCancelar.Location =
                new System.Drawing.Point(970, 225);

            this.btnCancelar.Name =
                "btnCancelar";

            this.btnCancelar.Size =
                new System.Drawing.Size(130, 35);

            this.btnCancelar.TabIndex = 17;

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.UseVisualStyleBackColor =
                false;

            this.btnCancelar.Click +=
                new System.EventHandler(
                    this.btnCancelar_Click);


            this.panelTabla.BackColor =
                System.Drawing.Color.White;

            this.panelTabla.Controls.Add(this.dgvMantenimientos);
            this.panelTabla.Controls.Add(this.lblRegistros);

            this.panelTabla.Location =
                new System.Drawing.Point(30, 165);

            this.panelTabla.Name =
                "panelTabla";

            this.panelTabla.Size =
                new System.Drawing.Size(1140, 500);

            this.panelTabla.TabIndex = 3;


            this.lblRegistros.AutoSize = true;

            this.lblRegistros.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblRegistros.ForeColor =
                System.Drawing.Color.FromArgb(70, 75, 80);

            this.lblRegistros.Location =
                new System.Drawing.Point(15, 12);

            this.lblRegistros.Name =
                "lblRegistros";

            this.lblRegistros.Size =
                new System.Drawing.Size(166, 15);

            this.lblRegistros.TabIndex = 0;

            this.lblRegistros.Text =
                "Mantenimientos registrados";

       

            this.dgvMantenimientos.AllowUserToAddRows = false;

            this.dgvMantenimientos.AllowUserToDeleteRows = false;

            this.dgvMantenimientos.AllowUserToResizeRows = false;

            this.dgvMantenimientos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvMantenimientos.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvMantenimientos.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvMantenimientos.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvMantenimientos.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvMantenimientos.ColumnHeadersHeight = 38;

            this.dgvMantenimientos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvMantenimientos.EnableHeadersVisualStyles = false;

            this.dgvMantenimientos.Location =
                new System.Drawing.Point(15, 40);

            this.dgvMantenimientos.MultiSelect = false;

            this.dgvMantenimientos.Name =
                "dgvMantenimientos";

            this.dgvMantenimientos.ReadOnly = true;

            this.dgvMantenimientos.RowHeadersVisible = false;

            this.dgvMantenimientos.RowTemplate.Height = 32;

            this.dgvMantenimientos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvMantenimientos.Size =
                new System.Drawing.Size(1110, 440);

            this.dgvMantenimientos.TabIndex = 1;

            this.dgvMantenimientos.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvMantenimientos_CellDoubleClick);

      

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);

            this.MinimumSize =
                new System.Drawing.Size(1000, 650);

            this.Name =
                "MantenimientosForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestor de Mantenimiento - Mantenimientos";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.Load +=
                new System.EventHandler(
                    this.MantenimientosForm_Load);

            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();

            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMantenimientos)).EndInit();

            this.ResumeLayout(false);
        }
    }
}