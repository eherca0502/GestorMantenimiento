namespace GestorMantenimiento
{
    partial class UsuariosForm
    {
       
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        
        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(0, 32, 74);
            this.panelSuperior.Controls.Add(this.lblSubtitulo);
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1100, 100);
            this.panelSuperior.TabIndex = 0;

          
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                20F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Usuarios";

           
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 62);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(280, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Administración de usuarios del sistema";

            
            this.panelBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblBuscar);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 100);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1100, 65);
            this.panelBusqueda.TabIndex = 1;

            
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(30, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(54, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";

           
            this.txtBuscar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(95, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

           
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.btnCerrar);
            this.panelFormulario.Controls.Add(this.btnCambiarEstado);
            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.btnGuardar);
            this.panelFormulario.Controls.Add(this.btnNuevo);
            this.panelFormulario.Controls.Add(this.chkActivo);
            this.panelFormulario.Controls.Add(this.lblActivo);
            this.panelFormulario.Controls.Add(this.cmbRol);
            this.panelFormulario.Controls.Add(this.lblRol);
            this.panelFormulario.Controls.Add(this.txtContrasena);
            this.panelFormulario.Controls.Add(this.lblContrasena);
            this.panelFormulario.Controls.Add(this.txtNombreUsuario);
            this.panelFormulario.Controls.Add(this.lblNombreUsuario);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormulario.Location = new System.Drawing.Point(0, 165);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1100, 170);
            this.panelFormulario.TabIndex = 2;

          
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 20);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(126, 17);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario";

            this.txtNombreUsuario.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(30, 43);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(240, 25);
            this.txtNombreUsuario.TabIndex = 1;

            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(295, 20);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 17);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña";

           
            this.txtContrasena.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(295, 43);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(240, 25);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.UseSystemPasswordChar = true;

           
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(560, 20);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 17);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol";

            
            this.cmbRol.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(560, 42);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(180, 25);
            this.cmbRol.TabIndex = 5;

           
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font(
                "Segoe UI",
                9.5F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(765, 20);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(47, 17);
            this.lblActivo.TabIndex = 6;
            this.lblActivo.Text = "Estado";

          
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(765, 44);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(64, 23);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;

            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(0, 32, 74);
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(30, 105);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 35);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(150, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(270, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

           
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarEstado.Location = new System.Drawing.Point(390, 105);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(145, 35);
            this.btnCambiarEstado.TabIndex = 11;
            this.btnCambiarEstado.Text = "Cambiar estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);

          
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(550, 105);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            
            this.panelTabla.BackColor = System.Drawing.Color.White;
            this.panelTabla.Controls.Add(this.dgvUsuarios);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 335);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Padding = new System.Windows.Forms.Padding(30, 15, 30, 25);
            this.panelTabla.Size = new System.Drawing.Size(1100, 365);
            this.panelTabla.TabIndex = 3;

         
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 15);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1040, 325);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(1100, 700);

            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelSuperior);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = true;

            this.Name = "UsuariosForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestor de Mantenimiento - Usuarios";

            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();

            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();

            this.panelTabla.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Panel panelFormulario;

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;

        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;

        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chkActivo;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnCerrar;

        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}