namespace GestorMantenimiento
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblSubtituloLogin;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Label lblVersion;

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
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSubtituloLogin = new System.Windows.Forms.Label();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
          
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelPrincipal.Controls.Add(this.panelDerecho);
            this.panelPrincipal.Controls.Add(this.panelIzquierdo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(857, 520);
            this.panelPrincipal.TabIndex = 0;
          
            this.panelDerecho.BackColor = System.Drawing.Color.White;
            this.panelDerecho.Controls.Add(this.lblVersion);
            this.panelDerecho.Controls.Add(this.btnSalir);
            this.panelDerecho.Controls.Add(this.btnIniciarSesion);
            this.panelDerecho.Controls.Add(this.txtContrasena);
            this.panelDerecho.Controls.Add(this.txtUsuario);
            this.panelDerecho.Controls.Add(this.lblContrasena);
            this.panelDerecho.Controls.Add(this.lblUsuario);
            this.panelDerecho.Controls.Add(this.lblSubtituloLogin);
            this.panelDerecho.Controls.Add(this.lblTituloLogin);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(403, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(454, 520);
            this.panelDerecho.TabIndex = 1;
           
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.lblVersion.Location = new System.Drawing.Point(197, 459);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 13);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Versión 1.0.0";
            
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.btnSalir.Location = new System.Drawing.Point(184, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 26);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
          
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(75, 321);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(300, 39);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
          
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtContrasena.Location = new System.Drawing.Point(75, 277);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(300, 27);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyDown);
          
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtUsuario.Location = new System.Drawing.Point(75, 217);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 27);
            this.txtUsuario.TabIndex = 3;
           
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.lblContrasena.Location = new System.Drawing.Point(75, 256);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(84, 19);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
           
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.lblUsuario.Location = new System.Drawing.Point(75, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
           
            this.lblSubtituloLogin.AutoSize = true;
            this.lblSubtituloLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.lblSubtituloLogin.Location = new System.Drawing.Point(75, 147);
            this.lblSubtituloLogin.Name = "lblSubtituloLogin";
            this.lblSubtituloLogin.Size = new System.Drawing.Size(208, 19);
            this.lblSubtituloLogin.TabIndex = 1;
            this.lblSubtituloLogin.Text = "Ingresa tus datos para continuar";
           
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lblTituloLogin.Location = new System.Drawing.Point(73, 104);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(200, 46);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "Bienvenido";
            
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panelIzquierdo.Controls.Add(this.lblDescripcion);
            this.panelIzquierdo.Controls.Add(this.lblNombreSistema);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(403, 520);
            this.panelIzquierdo.TabIndex = 0;
           
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.lblDescripcion.Location = new System.Drawing.Point(50, 247);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(300, 95);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Administra tus equipos de TI,\nmantenimientos e historial de servicio\ndesde un sol" +
    "o lugar.";
            
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.Location = new System.Drawing.Point(47, 186);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(182, 48);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "Gestor de";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 520);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Mantenimiento";
            this.panelPrincipal.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}