namespace GestorMantenimiento
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenido;

        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Button btnGarantias;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardEquipos;
        private System.Windows.Forms.Panel cardActivos;
        private System.Windows.Forms.Panel cardMantenimientos;
        private System.Windows.Forms.Panel cardGarantias;

        private System.Windows.Forms.Label lblNumeroEquipos;
        private System.Windows.Forms.Label lblNumeroActivos;
        private System.Windows.Forms.Label lblNumeroMantenimientos;
        private System.Windows.Forms.Label lblNumeroGarantias;

        private System.Windows.Forms.Label lblTextoEquipos;
        private System.Windows.Forms.Label lblTextoActivos;
        private System.Windows.Forms.Label lblTextoMantenimientos;
        private System.Windows.Forms.Label lblTextoGarantias;

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Panel panelActividad;

        private System.Windows.Forms.Label lblNumeroTickets;
        private System.Windows.Forms.Label lblTextoTickets;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnGarantias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();

            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.cardEquipos = new System.Windows.Forms.Panel();
            this.lblNumeroEquipos = new System.Windows.Forms.Label();
            this.lblTextoEquipos = new System.Windows.Forms.Label();

            this.cardActivos = new System.Windows.Forms.Panel();
            this.lblNumeroActivos = new System.Windows.Forms.Label();
            this.lblTextoActivos = new System.Windows.Forms.Label();

            this.cardMantenimientos = new System.Windows.Forms.Panel();
            this.lblNumeroMantenimientos = new System.Windows.Forms.Label();
            this.lblTextoMantenimientos = new System.Windows.Forms.Label();

            this.cardGarantias = new System.Windows.Forms.Panel();
            this.lblNumeroGarantias = new System.Windows.Forms.Label();
            this.lblTextoGarantias = new System.Windows.Forms.Label();

            this.lblActividad = new System.Windows.Forms.Label();
            this.panelActividad = new System.Windows.Forms.Panel();

            this.lblNumeroTickets = new System.Windows.Forms.Label();
            this.lblTextoTickets = new System.Windows.Forms.Label();

            this.panelMenu.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.cardEquipos.SuspendLayout();
            this.cardActivos.SuspendLayout();
            this.cardMantenimientos.SuspendLayout();
            this.cardGarantias.SuspendLayout();
            this.SuspendLayout();

           
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(24, 30, 38);

            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnGarantias);
            this.panelMenu.Controls.Add(this.btnMantenimientos);
            this.panelMenu.Controls.Add(this.btnEquipos);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblNombreSistema);

            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 700);
            this.panelMenu.TabIndex = 0;

            
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.Font = new System.Drawing.Font(
                "Segoe UI",
                12F,
                System.Drawing.FontStyle.Bold);

            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.Location = new System.Drawing.Point(28, 28);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(160, 42);
            this.lblNombreSistema.TabIndex = 0;
            this.lblNombreSistema.Text = "GESTOR DE\r\nMANTENIMIENTO";

            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(25, 32, 42);
            this.btnInicio.Location = new System.Drawing.Point(15, 92);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(185, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;

            this.btnInicio.Click +=
                new System.EventHandler(this.btnInicio_Click);

         
            this.btnEquipos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnEquipos.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.btnEquipos.ForeColor =
                System.Drawing.Color.FromArgb(190, 198, 208);

            this.btnEquipos.Location =
                new System.Drawing.Point(15, 140);

            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size =
                new System.Drawing.Size(185, 40);

            this.btnEquipos.TabIndex = 2;
            this.btnEquipos.Text = "   Equipos";

            this.btnEquipos.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnEquipos.UseVisualStyleBackColor = false;

            this.btnEquipos.Click +=
                new System.EventHandler(this.btnEquipos_Click);

           
            this.btnMantenimientos.BackColor =
                System.Drawing.Color.Transparent;

            this.btnMantenimientos.FlatAppearance.BorderSize = 0;

            this.btnMantenimientos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnMantenimientos.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.btnMantenimientos.ForeColor =
                System.Drawing.Color.FromArgb(190, 198, 208);

            this.btnMantenimientos.Location =
                new System.Drawing.Point(15, 188);

            this.btnMantenimientos.Name =
                "btnMantenimientos";

            this.btnMantenimientos.Size =
                new System.Drawing.Size(185, 40);

            this.btnMantenimientos.TabIndex = 3;

            this.btnMantenimientos.Text =
                "   Mantenimientos";

            this.btnMantenimientos.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnMantenimientos.UseVisualStyleBackColor = false;

            this.btnMantenimientos.Click +=
                new System.EventHandler(
                    this.btnMantenimientos_Click);

           
            this.btnGarantias.BackColor =
                System.Drawing.Color.Transparent;

            this.btnGarantias.FlatAppearance.BorderSize = 0;

            this.btnGarantias.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGarantias.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.btnGarantias.ForeColor =
                System.Drawing.Color.FromArgb(190, 198, 208);

            this.btnGarantias.Location =
                new System.Drawing.Point(15, 236);

            this.btnGarantias.Name =
                "btnGarantias";

            this.btnGarantias.Size =
                new System.Drawing.Size(185, 40);

            this.btnGarantias.TabIndex = 4;

            this.btnGarantias.Text =
                "   Garantías";

            this.btnGarantias.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnGarantias.UseVisualStyleBackColor = false;

            this.btnGarantias.Click +=
                new System.EventHandler(
                    this.btnGarantias_Click);

            this.btnUsuarios.BackColor =
                System.Drawing.Color.Transparent;

            this.btnUsuarios.FlatAppearance.BorderSize = 0;

            this.btnUsuarios.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnUsuarios.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.btnUsuarios.ForeColor =
                System.Drawing.Color.FromArgb(190, 198, 208);

            this.btnUsuarios.Location =
                new System.Drawing.Point(15, 284);

            this.btnUsuarios.Name =
                "btnUsuarios";

            this.btnUsuarios.Size =
                new System.Drawing.Size(185, 40);

            this.btnUsuarios.TabIndex = 5;

            this.btnUsuarios.Text =
                "   Usuarios";

            this.btnUsuarios.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnUsuarios.UseVisualStyleBackColor = false;

            this.btnUsuarios.Click +=
                new System.EventHandler(
                    this.btnUsuarios_Click);

           
            this.btnReportes.BackColor =
                System.Drawing.Color.Transparent;

            this.btnReportes.FlatAppearance.BorderSize = 0;

            this.btnReportes.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnReportes.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.btnReportes.ForeColor =
                System.Drawing.Color.FromArgb(190, 198, 208);

            this.btnReportes.Location =
                new System.Drawing.Point(15, 332);

            this.btnReportes.Name =
                "btnReportes";

            this.btnReportes.Size =
                new System.Drawing.Size(185, 40);

            this.btnReportes.TabIndex = 6;

            this.btnReportes.Text =
                "   Reportes";

            this.btnReportes.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnReportes.UseVisualStyleBackColor = false;

            this.btnReportes.Click +=
                new System.EventHandler(
                    this.btnReportes_Click);

            
            this.btnCerrarSesion.BackColor =
                System.Drawing.Color.Transparent;

            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;

            this.btnCerrarSesion.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnCerrarSesion.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.btnCerrarSesion.ForeColor =
                System.Drawing.Color.FromArgb(150, 158, 168);

            this.btnCerrarSesion.Location =
                new System.Drawing.Point(15, 500);

            this.btnCerrarSesion.Name =
                "btnCerrarSesion";

            this.btnCerrarSesion.Size =
                new System.Drawing.Size(185, 38);

            this.btnCerrarSesion.TabIndex = 7;

            this.btnCerrarSesion.Text =
                "   Cerrar sesión";

            this.btnCerrarSesion.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnCerrarSesion.UseVisualStyleBackColor = false;

            this.btnCerrarSesion.Click +=
                new System.EventHandler(
                    this.btnCerrarSesion_Click);

           
            this.btnSalir.BackColor =
                System.Drawing.Color.Transparent;

            this.btnSalir.FlatAppearance.BorderSize = 0;

            this.btnSalir.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSalir.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.btnSalir.ForeColor =
                System.Drawing.Color.FromArgb(150, 158, 168);

            this.btnSalir.Location =
                new System.Drawing.Point(15, 545);

            this.btnSalir.Name =
                "btnSalir";

            this.btnSalir.Size =
                new System.Drawing.Size(185, 38);

            this.btnSalir.TabIndex = 8;

            this.btnSalir.Text =
                "   Salir";

            this.btnSalir.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            this.btnSalir.UseVisualStyleBackColor = false;

            this.btnSalir.Click +=
                new System.EventHandler(
                    this.btnSalir_Click);

            this.panelSuperior.BackColor =
                System.Drawing.Color.White;

            this.panelSuperior.Controls.Add(
                this.lblRol);

            this.panelSuperior.Controls.Add(
                this.lblUsuario);

            this.panelSuperior.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelSuperior.Location =
                new System.Drawing.Point(215, 0);

            this.panelSuperior.Name =
                "panelSuperior";

            this.panelSuperior.Size =
                new System.Drawing.Size(985, 75);

            this.panelSuperior.TabIndex = 1;

           
            this.lblUsuario.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblUsuario.ForeColor =
                System.Drawing.Color.FromArgb(35, 40, 45);

            this.lblUsuario.Location =
                new System.Drawing.Point(850, 17);

            this.lblUsuario.Name =
                "lblUsuario";

            this.lblUsuario.Size =
                new System.Drawing.Size(58, 19);

            this.lblUsuario.TabIndex = 0;

            this.lblUsuario.Text =
                "Usuario";

           
            this.lblRol.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblRol.AutoSize = true;

            this.lblRol.Font =
                new System.Drawing.Font("Segoe UI", 8F);

            this.lblRol.ForeColor =
                System.Drawing.Color.Gray;

            this.lblRol.Location =
                new System.Drawing.Point(850, 40);

            this.lblRol.Name =
                "lblRol";

            this.lblRol.Size =
                new System.Drawing.Size(82, 13);

            this.lblRol.TabIndex = 1;

            this.lblRol.Text =
                "Administrador";

            
            this.panelContenido.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.panelContenido.Controls.Add(
                this.panelActividad);

            this.panelContenido.Controls.Add(
                this.lblActividad);

            this.panelContenido.Controls.Add(
                this.cardGarantias);

            this.panelContenido.Controls.Add(
                this.cardMantenimientos);

            this.panelContenido.Controls.Add(
                this.cardActivos);

            this.panelContenido.Controls.Add(
                this.cardEquipos);

            this.panelContenido.Controls.Add(
                this.lblSubtitulo);

            this.panelContenido.Controls.Add(
                this.lblTitulo);

            this.panelContenido.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.panelContenido.Location =
                new System.Drawing.Point(215, 75);

            this.panelContenido.Name =
                "panelContenido";

            this.panelContenido.Size =
                new System.Drawing.Size(985, 625);

            this.panelContenido.TabIndex = 2;

            
            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitulo.ForeColor =
                System.Drawing.Color.FromArgb(35, 40, 45);

            this.lblTitulo.Location =
                new System.Drawing.Point(35, 25);

            this.lblTitulo.Name =
                "lblTitulo";

            this.lblTitulo.Size =
                new System.Drawing.Size(166, 45);

            this.lblTitulo.TabIndex = 0;

            this.lblTitulo.Text =
                "Dashboard";

          
            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.Gray;

            this.lblSubtitulo.Location =
                new System.Drawing.Point(38, 70);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Size =
                new System.Drawing.Size(184, 19);

            this.lblSubtitulo.TabIndex = 1;

            this.lblSubtitulo.Text =
                "Resumen general del sistema";

           
            this.cardEquipos.BackColor =
                System.Drawing.Color.White;

            this.cardEquipos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardEquipos.Controls.Add(
                this.lblTextoEquipos);

            this.cardEquipos.Controls.Add(
                this.lblNumeroEquipos);

            this.cardEquipos.Location =
                new System.Drawing.Point(35, 110);

            this.cardEquipos.Name =
                "cardEquipos";

            this.cardEquipos.Size =
                new System.Drawing.Size(180, 85);

            this.cardEquipos.TabIndex = 2;

            
            this.lblNumeroEquipos.AutoSize = true;

            this.lblNumeroEquipos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroEquipos.ForeColor =
                System.Drawing.Color.FromArgb(25, 32, 42);

            this.lblNumeroEquipos.Location =
                new System.Drawing.Point(15, 7);

            this.lblNumeroEquipos.Name =
                "lblNumeroEquipos";

            this.lblNumeroEquipos.Size =
                new System.Drawing.Size(38, 45);

            this.lblNumeroEquipos.TabIndex = 0;

            this.lblNumeroEquipos.Text =
                "0";

            this.lblTextoEquipos.AutoSize = true;

            this.lblTextoEquipos.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTextoEquipos.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoEquipos.Location =
                new System.Drawing.Point(17, 58);

            this.lblTextoEquipos.Name =
                "lblTextoEquipos";

            this.lblTextoEquipos.Size =
                new System.Drawing.Size(113, 15);

            this.lblTextoEquipos.TabIndex = 1;

            this.lblTextoEquipos.Text =
                "Equipos registrados";

            
            this.cardActivos.BackColor =
                System.Drawing.Color.White;

            this.cardActivos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardActivos.Controls.Add(
                this.lblTextoActivos);

            this.cardActivos.Controls.Add(
                this.lblNumeroActivos);

            this.cardActivos.Location =
                new System.Drawing.Point(225, 110);

            this.cardActivos.Name =
                "cardActivos";

            this.cardActivos.Size =
                new System.Drawing.Size(180, 85);

            this.cardActivos.TabIndex = 3;

            
            this.lblNumeroActivos.AutoSize = true;

            this.lblNumeroActivos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroActivos.ForeColor =
                System.Drawing.Color.FromArgb(40, 140, 80);

            this.lblNumeroActivos.Location =
                new System.Drawing.Point(15, 7);

            this.lblNumeroActivos.Name =
                "lblNumeroActivos";

            this.lblNumeroActivos.Size =
                new System.Drawing.Size(38, 45);

            this.lblNumeroActivos.TabIndex = 0;

            this.lblNumeroActivos.Text =
                "0";

            
            this.lblTextoActivos.AutoSize = true;

            this.lblTextoActivos.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTextoActivos.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoActivos.Location =
                new System.Drawing.Point(17, 58);

            this.lblTextoActivos.Name =
                "lblTextoActivos";

            this.lblTextoActivos.Size =
                new System.Drawing.Size(93, 15);

            this.lblTextoActivos.TabIndex = 1;

            this.lblTextoActivos.Text =
                "Equipos activos";

            
            this.cardMantenimientos.BackColor =
                System.Drawing.Color.White;

            this.cardMantenimientos.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardMantenimientos.Controls.Add(
                this.lblTextoMantenimientos);

            this.cardMantenimientos.Controls.Add(
                this.lblNumeroMantenimientos);

            this.cardMantenimientos.Location =
                new System.Drawing.Point(415, 110);

            this.cardMantenimientos.Name =
                "cardMantenimientos";

            this.cardMantenimientos.Size =
                new System.Drawing.Size(180, 85);

            this.cardMantenimientos.TabIndex = 4;

           
            this.lblNumeroMantenimientos.AutoSize = true;

            this.lblNumeroMantenimientos.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroMantenimientos.ForeColor =
                System.Drawing.Color.FromArgb(220, 150, 30);

            this.lblNumeroMantenimientos.Location =
                new System.Drawing.Point(15, 7);

            this.lblNumeroMantenimientos.Name =
                "lblNumeroMantenimientos";

            this.lblNumeroMantenimientos.Size =
                new System.Drawing.Size(38, 45);

            this.lblNumeroMantenimientos.TabIndex = 0;

            this.lblNumeroMantenimientos.Text =
                "0";

           
            this.lblTextoMantenimientos.AutoSize = true;

            this.lblTextoMantenimientos.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTextoMantenimientos.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoMantenimientos.Location =
                new System.Drawing.Point(17, 58);

            this.lblTextoMantenimientos.Name =
                "lblTextoMantenimientos";

            this.lblTextoMantenimientos.Size =
                new System.Drawing.Size(148, 15);

            this.lblTextoMantenimientos.TabIndex = 1;

            this.lblTextoMantenimientos.Text =
                "Mantenimientos este mes";

            
            this.cardGarantias.BackColor =
                System.Drawing.Color.White;

            this.cardGarantias.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardGarantias.Controls.Add(
                this.lblTextoGarantias);

            this.cardGarantias.Controls.Add(
                this.lblNumeroGarantias);

            this.cardGarantias.Location =
                new System.Drawing.Point(605, 110);

            this.cardGarantias.Name =
                "cardGarantias";

            this.cardGarantias.Size =
                new System.Drawing.Size(180, 85);

            this.cardGarantias.TabIndex = 5;

           
            this.lblNumeroGarantias.AutoSize = true;

            this.lblNumeroGarantias.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    24F,
                    System.Drawing.FontStyle.Bold);

            this.lblNumeroGarantias.ForeColor =
                System.Drawing.Color.FromArgb(190, 130, 30);

            this.lblNumeroGarantias.Location =
                new System.Drawing.Point(15, 7);

            this.lblNumeroGarantias.Name =
                "lblNumeroGarantias";

            this.lblNumeroGarantias.Size =
                new System.Drawing.Size(38, 45);

            this.lblNumeroGarantias.TabIndex = 0;

            this.lblNumeroGarantias.Text =
                "0";

            
            this.lblTextoGarantias.AutoSize = true;

            this.lblTextoGarantias.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblTextoGarantias.ForeColor =
                System.Drawing.Color.Gray;

            this.lblTextoGarantias.Location =
                new System.Drawing.Point(17, 58);

            this.lblTextoGarantias.Name =
                "lblTextoGarantias";

            this.lblTextoGarantias.Size =
                new System.Drawing.Size(108, 15);

            this.lblTextoGarantias.TabIndex = 1;

            this.lblTextoGarantias.Text =
                "Garantías próximas";

            this.lblActividad.AutoSize = true;

            this.lblActividad.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    15F,
                    System.Drawing.FontStyle.Bold);

            this.lblActividad.ForeColor =
                System.Drawing.Color.FromArgb(40, 45, 50);

            this.lblActividad.Location =
                new System.Drawing.Point(35, 225);

            this.lblActividad.Name =
                "lblActividad";

            this.lblActividad.Size =
                new System.Drawing.Size(171, 28);

            this.lblActividad.TabIndex = 6;

            this.lblActividad.Text =
                "Actividad reciente";

            
            this.panelActividad.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.panelActividad.BackColor =
                System.Drawing.Color.White;

            this.panelActividad.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelActividad.Location =
                new System.Drawing.Point(35, 265);

            this.panelActividad.Name =
                "panelActividad";

            this.panelActividad.Size =
                new System.Drawing.Size(900, 300);

            this.panelActividad.TabIndex = 7;

            
            this.lblNumeroTickets.AutoSize = true;
            this.lblNumeroTickets.Name =
                "lblNumeroTickets";

            this.lblNumeroTickets.Text = "0";
            this.lblNumeroTickets.Visible = false;

           
            this.lblTextoTickets.AutoSize = true;
            this.lblTextoTickets.Name =
                "lblTextoTickets";

            this.lblTextoTickets.Text =
                "Tickets abiertos";

            this.lblTextoTickets.Visible = false;

           
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(
                this.panelContenido);

            this.Controls.Add(
                this.panelSuperior);

            this.Controls.Add(
                this.panelMenu);

            this.Name =
                "MainForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestor de Mantenimiento";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();

            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();

            this.cardEquipos.ResumeLayout(false);
            this.cardEquipos.PerformLayout();

            this.cardActivos.ResumeLayout(false);
            this.cardActivos.PerformLayout();

            this.cardMantenimientos.ResumeLayout(false);
            this.cardMantenimientos.PerformLayout();

            this.cardGarantias.ResumeLayout(false);
            this.cardGarantias.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}