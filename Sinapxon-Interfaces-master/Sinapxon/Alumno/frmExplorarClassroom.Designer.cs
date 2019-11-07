namespace Sinapxon.Alumno
{
    partial class frmExplorarClassroom
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDescripcion = new System.Windows.Forms.Panel();
            this.panelDatosProfesor = new System.Windows.Forms.Panel();
            this.panelTituloDescripcion = new System.Windows.Forms.Panel();
            this.panelTituloDatosProfesor = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panelDescripcion.SuspendLayout();
            this.panelDatosProfesor.SuspendLayout();
            this.panelTituloDescripcion.SuspendLayout();
            this.panelTituloDatosProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(12, 9);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(207, 29);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Nombre del curso";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(728, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar al classroom";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDescripcion.Controls.Add(this.panelTituloDescripcion);
            this.panelDescripcion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDescripcion.Location = new System.Drawing.Point(17, 78);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(398, 539);
            this.panelDescripcion.TabIndex = 6;
            // 
            // panelDatosProfesor
            // 
            this.panelDatosProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosProfesor.Controls.Add(this.txtApellido);
            this.panelDatosProfesor.Controls.Add(this.txtNombre);
            this.panelDatosProfesor.Controls.Add(this.lblApellido);
            this.panelDatosProfesor.Controls.Add(this.lblNombre);
            this.panelDatosProfesor.Controls.Add(this.pictureBox1);
            this.panelDatosProfesor.Controls.Add(this.panelTituloDatosProfesor);
            this.panelDatosProfesor.Location = new System.Drawing.Point(443, 78);
            this.panelDatosProfesor.Name = "panelDatosProfesor";
            this.panelDatosProfesor.Size = new System.Drawing.Size(470, 539);
            this.panelDatosProfesor.TabIndex = 7;
            // 
            // panelTituloDescripcion
            // 
            this.panelTituloDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloDescripcion.Controls.Add(this.lblDescripcion);
            this.panelTituloDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDescripcion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDescripcion.Name = "panelTituloDescripcion";
            this.panelTituloDescripcion.Size = new System.Drawing.Size(398, 100);
            this.panelTituloDescripcion.TabIndex = 0;
            // 
            // panelTituloDatosProfesor
            // 
            this.panelTituloDatosProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloDatosProfesor.Controls.Add(this.label1);
            this.panelTituloDatosProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDatosProfesor.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDatosProfesor.Name = "panelTituloDatosProfesor";
            this.panelTituloDatosProfesor.Size = new System.Drawing.Size(470, 100);
            this.panelTituloDatosProfesor.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(42, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 25);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del profosor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.baseline_account_circle_Big;
            this.pictureBox1.Location = new System.Drawing.Point(192, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(41, 282);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(41, 373);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 23);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(45, 322);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(45, 414);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(376, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // frmExplorarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.panelDatosProfesor);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExplorarClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExplorarClassroom";
            this.panelDescripcion.ResumeLayout(false);
            this.panelDatosProfesor.ResumeLayout(false);
            this.panelDatosProfesor.PerformLayout();
            this.panelTituloDescripcion.ResumeLayout(false);
            this.panelTituloDescripcion.PerformLayout();
            this.panelTituloDatosProfesor.ResumeLayout(false);
            this.panelTituloDatosProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDescripcion;
        private System.Windows.Forms.Panel panelTituloDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panelDatosProfesor;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTituloDatosProfesor;
        private System.Windows.Forms.Label label1;
    }
}