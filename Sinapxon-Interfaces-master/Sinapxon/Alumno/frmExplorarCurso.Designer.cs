namespace Sinapxon.Alumno
{
    partial class frmExplorarCurso
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
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.panelRequisitos = new System.Windows.Forms.Panel();
            this.panelClassrooms = new System.Windows.Forms.Panel();
            this.lblNumeroAlumnos = new System.Windows.Forms.Label();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.btnVerClassroom = new System.Windows.Forms.Button();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClasrooms = new System.Windows.Forms.Label();
            this.panelTituloRequisitos = new System.Windows.Forms.Panel();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.panelTituloClassrooms = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelRequisitos.SuspendLayout();
            this.panelClassrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTituloRequisitos.SuspendLayout();
            this.panelTituloClassrooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblNombreCurso.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCurso.Location = new System.Drawing.Point(95, 40);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(207, 29);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // panelRequisitos
            // 
            this.panelRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelRequisitos.Controls.Add(this.panelTituloRequisitos);
            this.panelRequisitos.Location = new System.Drawing.Point(17, 94);
            this.panelRequisitos.Name = "panelRequisitos";
            this.panelRequisitos.Size = new System.Drawing.Size(363, 553);
            this.panelRequisitos.TabIndex = 3;
            // 
            // panelClassrooms
            // 
            this.panelClassrooms.AutoScroll = true;
            this.panelClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelClassrooms.Controls.Add(this.panelTituloClassrooms);
            this.panelClassrooms.Controls.Add(this.lblNumeroAlumnos);
            this.panelClassrooms.Controls.Add(this.pbUsuarios);
            this.panelClassrooms.Controls.Add(this.btnVerClassroom);
            this.panelClassrooms.Controls.Add(this.lblNombreProfesor);
            this.panelClassrooms.Controls.Add(this.pictureBox1);
            this.panelClassrooms.Location = new System.Drawing.Point(395, 94);
            this.panelClassrooms.Name = "panelClassrooms";
            this.panelClassrooms.Size = new System.Drawing.Size(537, 553);
            this.panelClassrooms.TabIndex = 4;
            // 
            // lblNumeroAlumnos
            // 
            this.lblNumeroAlumnos.AutoSize = true;
            this.lblNumeroAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblNumeroAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblNumeroAlumnos.Location = new System.Drawing.Point(106, 126);
            this.lblNumeroAlumnos.Name = "lblNumeroAlumnos";
            this.lblNumeroAlumnos.Size = new System.Drawing.Size(84, 20);
            this.lblNumeroAlumnos.TabIndex = 4;
            this.lblNumeroAlumnos.Text = "0 Alumnos";
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.pbUsuarios.Image = global::Sinapxon.Properties.Resources.baseline_group_white_18dp;
            this.pbUsuarios.Location = new System.Drawing.Point(63, 117);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(36, 36);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuarios.TabIndex = 3;
            this.pbUsuarios.TabStop = false;
            // 
            // btnVerClassroom
            // 
            this.btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnVerClassroom.FlatAppearance.BorderSize = 0;
            this.btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClassroom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClassroom.ForeColor = System.Drawing.Color.White;
            this.btnVerClassroom.Image = global::Sinapxon.Properties.Resources.ver;
            this.btnVerClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClassroom.Location = new System.Drawing.Point(325, 96);
            this.btnVerClassroom.Name = "btnVerClassroom";
            this.btnVerClassroom.Size = new System.Drawing.Size(162, 41);
            this.btnVerClassroom.TabIndex = 2;
            this.btnVerClassroom.Text = "Ver classroom";
            this.btnVerClassroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerClassroom.UseVisualStyleBackColor = false;
            this.btnVerClassroom.Click += new System.EventHandler(this.BtnVerClassroom_Click);
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblNombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesor.Location = new System.Drawing.Point(59, 83);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(184, 24);
            this.lblNombreProfesor.TabIndex = 2;
            this.lblNombreProfesor.Text = "Nombre del profesor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            this.pictureBox1.Location = new System.Drawing.Point(19, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblClasrooms
            // 
            this.lblClasrooms.AutoSize = true;
            this.lblClasrooms.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasrooms.ForeColor = System.Drawing.Color.White;
            this.lblClasrooms.Location = new System.Drawing.Point(25, 17);
            this.lblClasrooms.Name = "lblClasrooms";
            this.lblClasrooms.Size = new System.Drawing.Size(126, 25);
            this.lblClasrooms.TabIndex = 0;
            this.lblClasrooms.Text = "Classrooms";
            // 
            // panelTituloRequisitos
            // 
            this.panelTituloRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloRequisitos.Controls.Add(this.lblRequisitos);
            this.panelTituloRequisitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloRequisitos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloRequisitos.Name = "panelTituloRequisitos";
            this.panelTituloRequisitos.Size = new System.Drawing.Size(363, 58);
            this.panelTituloRequisitos.TabIndex = 0;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.ForeColor = System.Drawing.Color.White;
            this.lblRequisitos.Location = new System.Drawing.Point(18, 17);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(113, 25);
            this.lblRequisitos.TabIndex = 5;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // panelTituloClassrooms
            // 
            this.panelTituloClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloClassrooms.Controls.Add(this.lblClasrooms);
            this.panelTituloClassrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloClassrooms.Location = new System.Drawing.Point(0, 0);
            this.panelTituloClassrooms.Name = "panelTituloClassrooms";
            this.panelTituloClassrooms.Size = new System.Drawing.Size(537, 58);
            this.panelTituloClassrooms.TabIndex = 5;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(17, 28);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 23;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // frmExplorarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelClassrooms);
            this.Controls.Add(this.panelRequisitos);
            this.Controls.Add(this.lblNombreCurso);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExplorarCurso";
            this.Text = "frmExplorarCurso";
            this.panelRequisitos.ResumeLayout(false);
            this.panelClassrooms.ResumeLayout(false);
            this.panelClassrooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTituloRequisitos.ResumeLayout(false);
            this.panelTituloRequisitos.PerformLayout();
            this.panelTituloClassrooms.ResumeLayout(false);
            this.panelTituloClassrooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Button btnVerClassroom;
        private System.Windows.Forms.Panel panelRequisitos;
        private System.Windows.Forms.Panel panelClassrooms;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClasrooms;
        private System.Windows.Forms.Label lblNumeroAlumnos;
        private System.Windows.Forms.Panel panelTituloRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Panel panelTituloClassrooms;
        private System.Windows.Forms.Button btnAtras;
    }
}