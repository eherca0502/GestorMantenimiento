namespace GestorMantenimiento
{
    partial class EquipoForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelBotones;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblSerie;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblArea;

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblIp;

        private System.Windows.Forms.Label lblAdquisicion;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblEstado;

        private System.Windows.Forms.Label lblObservaciones;

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerie;

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtArea;

        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.TextBox txtIp;

        private System.Windows.Forms.DateTimePicker dtpAdquisicion;
        private System.Windows.Forms.DateTimePicker dtpGarantia;

        private System.Windows.Forms.ComboBox cmbEstado;

        private System.Windows.Forms.TextBox txtObservaciones;

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();

            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();

            this.lblSistema = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();

            this.lblAdquisicion = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            this.lblObservaciones = new System.Windows.Forms.Label();

            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();

            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();

            this.txtSistema = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();

            this.dtpAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.dtpGarantia = new System.Windows.Forms.DateTimePicker();

            this.cmbEstado = new System.Windows.Forms.ComboBox();

            this.txtObservaciones = new System.Windows.Forms.TextBox();

            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.panelPrincipal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelBotones.SuspendLayout();

            this.SuspendLayout();

          

            this.panelPrincipal.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelPrincipal.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.panelPrincipal.Controls.Add(
                this.panelContenido);

            this.panelPrincipal.Controls.Add(
                this.panelBotones);

            this.panelPrincipal.Controls.Add(
                this.panelHeader);

            this.panelHeader.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.panelHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelHeader.Height = 90;

            this.panelHeader.Controls.Add(
                this.lblSubtitulo);

            this.panelHeader.Controls.Add(
                this.lblTitulo);


            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.White;

            this.lblTitulo.Location =
                new System.Drawing.Point(30, 15);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Text =
                "Nuevo equipo";


            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(190, 195, 200);

            this.lblSubtitulo.Location =
                new System.Drawing.Point(33, 55);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Text =
                "Registra la información del equipo";


            this.panelContenido.BackColor =
                System.Drawing.Color.White;

            this.panelContenido.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.panelContenido.Padding =
                new System.Windows.Forms.Padding(30);

         

            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(35, 25);
            this.lblCodigo.Text = "Código";

            this.txtCodigo.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtCodigo.Location =
                new System.Drawing.Point(35, 47);

            this.txtCodigo.Size =
                new System.Drawing.Size(220, 25);

            this.txtCodigo.Name =
                "txtCodigo";

            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipo.Location = new System.Drawing.Point(280, 25);
            this.lblTipo.Text = "Tipo";

            this.cmbTipo.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbTipo.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cmbTipo.Location =
                new System.Drawing.Point(280, 47);

            this.cmbTipo.Size =
                new System.Drawing.Size(220, 25);

            this.cmbTipo.Name =
                "cmbTipo";

            this.cmbTipo.Items.AddRange(
                new object[]
                {
                    "Computadora",
                    "Laptop",
                    "Servidor",
                    "Impresora",
                    "Monitor",
                    "Switch",
                    "Router",
                    "Otro"
                });

      

            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMarca.Location = new System.Drawing.Point(525, 25);
            this.lblMarca.Text = "Marca";

            this.txtMarca.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtMarca.Location =
                new System.Drawing.Point(525, 47);

            this.txtMarca.Size =
                new System.Drawing.Size(220, 25);

            this.txtMarca.Name =
                "txtMarca";

         

            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblModelo.Location = new System.Drawing.Point(770, 25);
            this.lblModelo.Text = "Modelo";

            this.txtModelo.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtModelo.Location =
                new System.Drawing.Point(770, 47);

            this.txtModelo.Size =
                new System.Drawing.Size(220, 25);

            this.txtModelo.Name =
                "txtModelo";


            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSerie.Location = new System.Drawing.Point(35, 90);
            this.lblSerie.Text = "Número de serie";

            this.txtSerie.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtSerie.Location =
                new System.Drawing.Point(35, 112);

            this.txtSerie.Size =
                new System.Drawing.Size(465, 25);

            this.txtSerie.Name =
                "txtSerie";


            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.Location = new System.Drawing.Point(525, 90);
            this.lblUsuario.Text = "Usuario asignado";

            this.txtUsuario.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtUsuario.Location =
                new System.Drawing.Point(525, 112);

            this.txtUsuario.Size =
                new System.Drawing.Size(220, 25);

            this.txtUsuario.Name =
                "txtUsuario";

       

            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArea.Location = new System.Drawing.Point(770, 90);
            this.lblArea.Text = "Área";

            this.txtArea.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtArea.Location =
                new System.Drawing.Point(770, 112);

            this.txtArea.Size =
                new System.Drawing.Size(220, 25);

            this.txtArea.Name =
                "txtArea";

            

            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSistema.Location = new System.Drawing.Point(35, 155);
            this.lblSistema.Text = "Sistema operativo";

            this.txtSistema.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtSistema.Location =
                new System.Drawing.Point(35, 177);

            this.txtSistema.Size =
                new System.Drawing.Size(220, 25);

            this.txtSistema.Name =
                "txtSistema";

       

            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRam.Location = new System.Drawing.Point(280, 155);
            this.lblRam.Text = "RAM";

            this.txtRam.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtRam.Location =
                new System.Drawing.Point(280, 177);

            this.txtRam.Size =
                new System.Drawing.Size(220, 25);

            this.txtRam.Name =
                "txtRam";

            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlmacenamiento.Location = new System.Drawing.Point(525, 155);
            this.lblAlmacenamiento.Text = "Almacenamiento";

            this.txtAlmacenamiento.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtAlmacenamiento.Location =
                new System.Drawing.Point(525, 177);

            this.txtAlmacenamiento.Size =
                new System.Drawing.Size(220, 25);

            this.txtAlmacenamiento.Name =
                "txtAlmacenamiento";


            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIp.Location = new System.Drawing.Point(770, 155);
            this.lblIp.Text = "Dirección IP";

            this.txtIp.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtIp.Location =
                new System.Drawing.Point(770, 177);

            this.txtIp.Size =
                new System.Drawing.Size(220, 25);

            this.txtIp.Name =
                "txtIp";


            this.lblAdquisicion.AutoSize = true;
            this.lblAdquisicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdquisicion.Location = new System.Drawing.Point(35, 220);
            this.lblAdquisicion.Text = "Fecha de adquisición";

            this.dtpAdquisicion.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpAdquisicion.Location =
                new System.Drawing.Point(35, 242);

            this.dtpAdquisicion.Size =
                new System.Drawing.Size(220, 23);

            this.dtpAdquisicion.Name =
                "dtpAdquisicion";


            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGarantia.Location = new System.Drawing.Point(280, 220);
            this.lblGarantia.Text = "Fecha de garantía";

            this.dtpGarantia.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpGarantia.Location =
                new System.Drawing.Point(280, 242);

            this.dtpGarantia.Size =
                new System.Drawing.Size(220, 23);

            this.dtpGarantia.Name =
                "dtpGarantia";


            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.Location = new System.Drawing.Point(525, 220);
            this.lblEstado.Text = "Estado";

            this.cmbEstado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbEstado.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.cmbEstado.Location =
                new System.Drawing.Point(525, 242);

            this.cmbEstado.Size =
                new System.Drawing.Size(220, 25);

            this.cmbEstado.Name =
                "cmbEstado";

            this.cmbEstado.Items.AddRange(
                new object[]
                {
                    "Activo",
                    "En mantenimiento",
                    "Fuera de servicio",
                    "Baja"
                });


            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblObservaciones.Location =
                new System.Drawing.Point(35, 285);

            this.lblObservaciones.Text =
                "Observaciones";

            this.txtObservaciones.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.txtObservaciones.Location =
                new System.Drawing.Point(35, 307);

            this.txtObservaciones.Multiline = true;

            this.txtObservaciones.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtObservaciones.Size =
                new System.Drawing.Size(955, 90);

            this.txtObservaciones.Name =
                "txtObservaciones";

            

            this.panelContenido.Controls.Add(this.lblCodigo);
            this.panelContenido.Controls.Add(this.txtCodigo);

            this.panelContenido.Controls.Add(this.lblTipo);
            this.panelContenido.Controls.Add(this.cmbTipo);

            this.panelContenido.Controls.Add(this.lblMarca);
            this.panelContenido.Controls.Add(this.txtMarca);

            this.panelContenido.Controls.Add(this.lblModelo);
            this.panelContenido.Controls.Add(this.txtModelo);

            this.panelContenido.Controls.Add(this.lblSerie);
            this.panelContenido.Controls.Add(this.txtSerie);

            this.panelContenido.Controls.Add(this.lblUsuario);
            this.panelContenido.Controls.Add(this.txtUsuario);

            this.panelContenido.Controls.Add(this.lblArea);
            this.panelContenido.Controls.Add(this.txtArea);

            this.panelContenido.Controls.Add(this.lblSistema);
            this.panelContenido.Controls.Add(this.txtSistema);

            this.panelContenido.Controls.Add(this.lblRam);
            this.panelContenido.Controls.Add(this.txtRam);

            this.panelContenido.Controls.Add(this.lblAlmacenamiento);
            this.panelContenido.Controls.Add(this.txtAlmacenamiento);

            this.panelContenido.Controls.Add(this.lblIp);
            this.panelContenido.Controls.Add(this.txtIp);

            this.panelContenido.Controls.Add(this.lblAdquisicion);
            this.panelContenido.Controls.Add(this.dtpAdquisicion);

            this.panelContenido.Controls.Add(this.lblGarantia);
            this.panelContenido.Controls.Add(this.dtpGarantia);

            this.panelContenido.Controls.Add(this.lblEstado);
            this.panelContenido.Controls.Add(this.cmbEstado);

            this.panelContenido.Controls.Add(this.lblObservaciones);
            this.panelContenido.Controls.Add(this.txtObservaciones);


            this.panelBotones.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelBotones.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.panelBotones.Height = 75;

            this.panelBotones.Controls.Add(
                this.btnGuardar);

            this.panelBotones.Controls.Add(
                this.btnCancelar);


            this.btnCancelar.BackColor =
                System.Drawing.Color.White;

            this.btnCancelar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCancelar.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(210, 215, 220);

            this.btnCancelar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnCancelar.ForeColor =
                System.Drawing.Color.FromArgb(60, 65, 70);

            this.btnCancelar.Location =
                new System.Drawing.Point(700, 18);

            this.btnCancelar.Size =
                new System.Drawing.Size(130, 38);

            this.btnCancelar.Name =
                "btnCancelar";

            this.btnCancelar.Text =
                "Cancelar";

            this.btnCancelar.Click +=
                new System.EventHandler(
                    this.btnCancelar_Click);

            

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
                new System.Drawing.Point(845, 18);

            this.btnGuardar.Size =
                new System.Drawing.Size(145, 38);

            this.btnGuardar.Name =
                "btnGuardar";

            this.btnGuardar.Text =
                "Guardar equipo";

            this.btnGuardar.Click +=
                new System.EventHandler(
                    this.btnGuardar_Click);

         

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1030, 520);

            this.Controls.Add(
                this.panelPrincipal);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name =
                "EquipoForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Equipo";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();

            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();

            this.panelBotones.ResumeLayout(false);

            this.panelPrincipal.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}