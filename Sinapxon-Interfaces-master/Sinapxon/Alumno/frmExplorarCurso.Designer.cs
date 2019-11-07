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
            this.btnVerClassroom = new System.Windows.Forms.Button();
            this.panelRequisitos = new System.Windows.Forms.Panel();
            this.panelClassrooms = new System.Windows.Forms.Panel();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.lblClasrooms = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumeroAlumnos = new System.Windows.Forms.Label();
            this.panelRequisitos.SuspendLayout();
            this.panelClassrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(12, 9);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(207, 29);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // btnVerClassroom
            // 
            this.btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnVerClassroom.FlatAppearance.BorderSize = 0;
            this.btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClassroom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClassroom.ForeColor = System.Drawing.Color.White;
            this.btnVerClassroom.Location = new System.Drawing.Point(358, 92);
            this.btnVerClassroom.Name = "btnVerClassroom";
            this.btnVerClassroom.Size = new System.Drawing.Size(125, 41);
            this.btnVerClassroom.TabIndex = 2;
            this.btnVerClassroom.Text = "Ver classroom";
            this.btnVerClassroom.UseVisualStyleBackColor = false;
            this.btnVerClassroom.Click += new System.EventHandler(this.BtnVerClassroom_Click);
            // 
            // panelRequisitos
            // 
            this.panelRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelRequisitos.Controls.Add(this.lblRequisitos);
            this.panelRequisitos.Location = new System.Drawing.Point(17, 89);
            this.panelRequisitos.Name = "panelRequisitos";
            this.panelRequisitos.Size = new System.Drawing.Size(360, 541);
            this.panelRequisitos.TabIndex = 3;
            // 
            // panelClassrooms
            // 
            this.panelClassrooms.AutoScroll = true;
            this.panelClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelClassrooms.Controls.Add(this.lblNumeroAlumnos);
            this.panelClassrooms.Controls.Add(this.pbUsuarios);
            this.panelClassrooms.Controls.Add(this.btnVerClassroom);
            this.panelClassrooms.Controls.Add(this.lblNombreProfesor);
            this.panelClassrooms.Controls.Add(this.pictureBox1);
            this.panelClassrooms.Controls.Add(this.lblClasrooms);
            this.panelClassrooms.Location = new System.Drawing.Point(395, 89);
            this.panelClassrooms.Name = "panelClassrooms";
            this.panelClassrooms.Size = new System.Drawing.Size(537, 541);
            this.panelClassrooms.TabIndex = 4;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.ForeColor = System.Drawing.Color.White;
            this.lblRequisitos.Location = new System.Drawing.Point(12, 11);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(113, 25);
            this.lblRequisitos.TabIndex = 0;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // lblClasrooms
            // 
            this.lblClasrooms.AutoSize = true;
            this.lblClasrooms.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasrooms.ForeColor = System.Drawing.Color.White;
            this.lblClasrooms.Location = new System.Drawing.Point(17, 11);
            this.lblClasrooms.Name = "lblClasrooms";
            this.lblClasrooms.Size = new System.Drawing.Size(126, 25);
            this.lblClasrooms.TabIndex = 0;
            this.lblClasrooms.Text = "Classrooms";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblNombreProfesor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesor.Location = new System.Drawing.Point(62, 83);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(187, 23);
            this.lblNombreProfesor.TabIndex = 2;
            this.lblNombreProfesor.Text = "Nombre del profesor";
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.pbUsuarios.Image = global::Sinapxon.Properties.Resources.baseline_group_white_18dp;
            this.pbUsuarios.Location = new System.Drawing.Point(66, 117);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(36, 36);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuarios.TabIndex = 3;
            this.pbUsuarios.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            this.pictureBox1.Location = new System.Drawing.Point(22, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumeroAlumnos
            // 
            this.lblNumeroAlumnos.AutoSize = true;
            this.lblNumeroAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblNumeroAlumnos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblNumeroAlumnos.Location = new System.Drawing.Point(109, 126);
            this.lblNumeroAlumnos.Name = "lblNumeroAlumnos";
            this.lblNumeroAlumnos.Size = new System.Drawing.Size(85, 19);
            this.lblNumeroAlumnos.TabIndex = 4;
            this.lblNumeroAlumnos.Text = "0 Alumnos";
            // 
            // frmExplorarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.panelClassrooms);
            this.Controls.Add(this.panelRequisitos);
            this.Controls.Add(this.lblNombreCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExplorarCurso";
            this.Text = "frmExplorarCurso";
            this.panelRequisitos.ResumeLayout(false);
            this.panelRequisitos.PerformLayout();
            this.panelClassrooms.ResumeLayout(false);
            this.panelClassrooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Button btnVerClassroom;
        private System.Windows.Forms.Panel panelRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Panel panelClassrooms;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClasrooms;
        private System.Windows.Forms.Label lblNumeroAlumnos;
    }
}