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
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblClasrooms = new System.Windows.Forms.Label();
            this.gbRequisitos = new System.Windows.Forms.GroupBox();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.btnVerClassroom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRequisitos.SuspendLayout();
            this.panelClassrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNombreCurso.Location = new System.Drawing.Point(12, 29);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(222, 29);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // panelRequisitos
            // 
            this.panelRequisitos.BackColor = System.Drawing.Color.SlateBlue;
            this.panelRequisitos.Controls.Add(this.gbRequisitos);
            this.panelRequisitos.Location = new System.Drawing.Point(17, 72);
            this.panelRequisitos.Name = "panelRequisitos";
            this.panelRequisitos.Size = new System.Drawing.Size(363, 558);
            this.panelRequisitos.TabIndex = 3;
            // 
            // panelClassrooms
            // 
            this.panelClassrooms.AutoScroll = true;
            this.panelClassrooms.BackColor = System.Drawing.Color.SlateBlue;
            this.panelClassrooms.Controls.Add(this.lblNumeroAlumnos);
            this.panelClassrooms.Controls.Add(this.pbUsuarios);
            this.panelClassrooms.Controls.Add(this.btnVerClassroom);
            this.panelClassrooms.Controls.Add(this.lblNombreProfesor);
            this.panelClassrooms.Controls.Add(this.pictureBox1);
            this.panelClassrooms.Controls.Add(this.lblClasrooms);
            this.panelClassrooms.Location = new System.Drawing.Point(395, 72);
            this.panelClassrooms.Name = "panelClassrooms";
            this.panelClassrooms.Size = new System.Drawing.Size(537, 558);
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
            // lblClasrooms
            // 
            this.lblClasrooms.AutoSize = true;
            this.lblClasrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasrooms.ForeColor = System.Drawing.Color.White;
            this.lblClasrooms.Location = new System.Drawing.Point(17, 11);
            this.lblClasrooms.Name = "lblClasrooms";
            this.lblClasrooms.Size = new System.Drawing.Size(135, 25);
            this.lblClasrooms.TabIndex = 0;
            this.lblClasrooms.Text = "Classrooms";
            // 
            // gbRequisitos
            // 
            this.gbRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRequisitos.ForeColor = System.Drawing.Color.White;
            this.gbRequisitos.Location = new System.Drawing.Point(3, 7);
            this.gbRequisitos.Name = "gbRequisitos";
            this.gbRequisitos.Size = new System.Drawing.Size(357, 538);
            this.gbRequisitos.TabIndex = 1;
            this.gbRequisitos.TabStop = false;
            this.gbRequisitos.Text = "Requisitos";
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
            this.btnVerClassroom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerClassroom.FlatAppearance.BorderSize = 0;
            this.btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // frmExplorarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.panelClassrooms);
            this.Controls.Add(this.panelRequisitos);
            this.Controls.Add(this.lblNombreCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExplorarCurso";
            this.Text = "frmExplorarCurso";
            this.panelRequisitos.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelClassrooms;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClasrooms;
        private System.Windows.Forms.Label lblNumeroAlumnos;
        private System.Windows.Forms.GroupBox gbRequisitos;
    }
}