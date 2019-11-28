namespace Sinapxon.Profesor
{
    partial class frmProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesor));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubGestionarUsr = new System.Windows.Forms.Panel();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnVerSolicitudes = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnGestionarMisClassrooms = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubGestionarUsr.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.panelSubGestionarUsr);
            this.panelMenu.Controls.Add(this.btnSolicitud);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnGestionarMisClassrooms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubGestionarUsr
            // 
            this.panelSubGestionarUsr.Controls.Add(this.btnSolicitar);
            this.panelSubGestionarUsr.Controls.Add(this.btnVerSolicitudes);
            this.panelSubGestionarUsr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestionarUsr.Location = new System.Drawing.Point(0, 306);
            this.panelSubGestionarUsr.Name = "panelSubGestionarUsr";
            this.panelSubGestionarUsr.Size = new System.Drawing.Size(300, 130);
            this.panelSubGestionarUsr.TabIndex = 7;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.btnSolicitar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitar.FlatAppearance.BorderSize = 0;
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.Black;
            this.btnSolicitar.Location = new System.Drawing.Point(0, 63);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnSolicitar.Size = new System.Drawing.Size(300, 63);
            this.btnSolicitar.TabIndex = 1;
            this.btnSolicitar.Text = "    Crear solicitud";
            this.btnSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnVerSolicitudes
            // 
            this.btnVerSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.btnVerSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSolicitudes.ForeColor = System.Drawing.Color.Black;
            this.btnVerSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.btnVerSolicitudes.Name = "btnVerSolicitudes";
            this.btnVerSolicitudes.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnVerSolicitudes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerSolicitudes.Size = new System.Drawing.Size(300, 63);
            this.btnVerSolicitudes.TabIndex = 0;
            this.btnVerSolicitudes.Text = "Ver mis solicitudes";
            this.btnVerSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSolicitudes.UseVisualStyleBackColor = false;
            this.btnVerSolicitudes.Click += new System.EventHandler(this.btnVerSolicitudes_Click);
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitud.FlatAppearance.BorderSize = 0;
            this.btnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolicitud.Image = global::Sinapxon.Properties.Resources.baseline_collections_bookmark;
            this.btnSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitud.Location = new System.Drawing.Point(0, 243);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSolicitud.Size = new System.Drawing.Size(300, 63);
            this.btnSolicitud.TabIndex = 6;
            this.btnSolicitud.Text = "Solicitud de classroom";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Sinapxon.Properties.Resources.baseline_exit_to_app;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 634);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(300, 47);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "          Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGestionarMisClassrooms
            // 
            this.btnGestionarMisClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGestionarMisClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarMisClassrooms.FlatAppearance.BorderSize = 0;
            this.btnGestionarMisClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarMisClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarMisClassrooms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionarMisClassrooms.Image = global::Sinapxon.Properties.Resources.baseline_collections_bookmark;
            this.btnGestionarMisClassrooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarMisClassrooms.Location = new System.Drawing.Point(0, 180);
            this.btnGestionarMisClassrooms.Name = "btnGestionarMisClassrooms";
            this.btnGestionarMisClassrooms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionarMisClassrooms.Size = new System.Drawing.Size(300, 63);
            this.btnGestionarMisClassrooms.TabIndex = 1;
            this.btnGestionarMisClassrooms.Text = "Gestionar mis classrooms";
            this.btnGestionarMisClassrooms.UseVisualStyleBackColor = false;
            this.btnGestionarMisClassrooms.Click += new System.EventHandler(this.btnGestionarMisClassrooms_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelLogo.Controls.Add(this.lblRol);
            this.panelLogo.Controls.Add(this.lblNombreUsuario);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 180);
            this.panelLogo.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(119, 99);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(59, 16);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Profesor";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(114, 70);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(185, 25);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Apellido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.baseline_account_circle_Big;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(300, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(964, 681);
            this.panelContenedor.TabIndex = 1;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Profesor";
            this.panelMenu.ResumeLayout(false);
            this.panelSubGestionarUsr.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnGestionarMisClassrooms;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Panel panelSubGestionarUsr;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnVerSolicitudes;
    }
}