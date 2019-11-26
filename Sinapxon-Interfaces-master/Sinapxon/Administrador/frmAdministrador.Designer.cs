namespace Sinapxon.Administrador
{
    partial class frmAdministrador
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelSubGestionarUsr = new System.Windows.Forms.Panel();
            this.btnGestionarAlumno = new System.Windows.Forms.Button();
            this.btnGestionarProfesor = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarClassrooms = new System.Windows.Forms.Button();
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelSubGestionarUsr.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.btnEspecialidad);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panelSubGestionarUsr);
            this.panelMenu.Controls.Add(this.btnGestionarUsuarios);
            this.panelMenu.Controls.Add(this.btnGestionarClassrooms);
            this.panelMenu.Controls.Add(this.btnGestionarCursos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 681);
            this.panelMenu.TabIndex = 0;
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 631);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(300, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "          Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelSubGestionarUsr
            // 
            this.panelSubGestionarUsr.Controls.Add(this.btnGestionarAlumno);
            this.panelSubGestionarUsr.Controls.Add(this.btnGestionarProfesor);
            this.panelSubGestionarUsr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestionarUsr.Location = new System.Drawing.Point(0, 390);
            this.panelSubGestionarUsr.Name = "panelSubGestionarUsr";
            this.panelSubGestionarUsr.Size = new System.Drawing.Size(300, 144);
            this.panelSubGestionarUsr.TabIndex = 4;
            // 
            // btnGestionarAlumno
            // 
            this.btnGestionarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.btnGestionarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarAlumno.FlatAppearance.BorderSize = 0;
            this.btnGestionarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarAlumno.ForeColor = System.Drawing.Color.Black;
            this.btnGestionarAlumno.Location = new System.Drawing.Point(0, 70);
            this.btnGestionarAlumno.Name = "btnGestionarAlumno";
            this.btnGestionarAlumno.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnGestionarAlumno.Size = new System.Drawing.Size(300, 70);
            this.btnGestionarAlumno.TabIndex = 1;
            this.btnGestionarAlumno.Text = "Gestionar alumno";
            this.btnGestionarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarAlumno.UseVisualStyleBackColor = false;
            this.btnGestionarAlumno.Click += new System.EventHandler(this.btnGestionarAlumno_Click);
            // 
            // btnGestionarProfesor
            // 
            this.btnGestionarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.btnGestionarProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarProfesor.FlatAppearance.BorderSize = 0;
            this.btnGestionarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProfesor.ForeColor = System.Drawing.Color.Black;
            this.btnGestionarProfesor.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarProfesor.Name = "btnGestionarProfesor";
            this.btnGestionarProfesor.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnGestionarProfesor.Size = new System.Drawing.Size(300, 70);
            this.btnGestionarProfesor.TabIndex = 0;
            this.btnGestionarProfesor.Text = "Gestionar profesor";
            this.btnGestionarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarProfesor.UseVisualStyleBackColor = false;
            this.btnGestionarProfesor.Click += new System.EventHandler(this.btnGestionarProfesor_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarUsuarios.Image = global::Sinapxon.Properties.Resources.baseline_group_white_18dp;
            this.btnGestionarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 320);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(300, 70);
            this.btnGestionarUsuarios.TabIndex = 3;
            this.btnGestionarUsuarios.Text = "          Gestionar usuarios";
            this.btnGestionarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarClassrooms
            // 
            this.btnGestionarClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGestionarClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarClassrooms.FlatAppearance.BorderSize = 0;
            this.btnGestionarClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarClassrooms.ForeColor = System.Drawing.Color.White;
            this.btnGestionarClassrooms.Image = global::Sinapxon.Properties.Resources.baseline_inbox_white_18dp;
            this.btnGestionarClassrooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarClassrooms.Location = new System.Drawing.Point(0, 250);
            this.btnGestionarClassrooms.Name = "btnGestionarClassrooms";
            this.btnGestionarClassrooms.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGestionarClassrooms.Size = new System.Drawing.Size(300, 70);
            this.btnGestionarClassrooms.TabIndex = 2;
            this.btnGestionarClassrooms.Text = "          Gestionar Classrooms";
            this.btnGestionarClassrooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarClassrooms.UseVisualStyleBackColor = false;
            this.btnGestionarClassrooms.Click += new System.EventHandler(this.btnGestionarClassrooms_Click);
            // 
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGestionarCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarCursos.FlatAppearance.BorderSize = 0;
            this.btnGestionarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarCursos.ForeColor = System.Drawing.Color.White;
            this.btnGestionarCursos.Image = global::Sinapxon.Properties.Resources.baseline_book;
            this.btnGestionarCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCursos.Location = new System.Drawing.Point(0, 180);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGestionarCursos.Size = new System.Drawing.Size(300, 70);
            this.btnGestionarCursos.TabIndex = 1;
            this.btnGestionarCursos.Text = "          Gestionar cursos";
            this.btnGestionarCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarCursos.UseVisualStyleBackColor = false;
            this.btnGestionarCursos.Click += new System.EventHandler(this.btnGestionarCursos_Click);
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
            this.lblRol.Size = new System.Drawing.Size(91, 16);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Administrador";
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
            this.panelContenedor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(300, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(964, 681);
            this.panelContenedor.TabIndex = 1;
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidad.FlatAppearance.BorderSize = 0;
            this.btnEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidad.ForeColor = System.Drawing.Color.White;
            this.btnEspecialidad.Image = global::Sinapxon.Properties.Resources.baseline_book;
            this.btnEspecialidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidad.Location = new System.Drawing.Point(0, 534);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEspecialidad.Size = new System.Drawing.Size(300, 70);
            this.btnEspecialidad.TabIndex = 6;
            this.btnEspecialidad.Text = "          Gestionar Especialidad";
            this.btnEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidad.UseVisualStyleBackColor = false;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelSubGestionarUsr.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnGestionarClassrooms;
        private System.Windows.Forms.Button btnGestionarCursos;
        private System.Windows.Forms.Panel panelSubGestionarUsr;
        private System.Windows.Forms.Button btnGestionarAlumno;
        private System.Windows.Forms.Button btnGestionarProfesor;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEspecialidad;
    }
}