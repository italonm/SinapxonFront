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
            this.panelTituloDescripcion = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelDatosProfesor = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTituloDatosProfesor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblApellidosProfesor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelDescripcion.SuspendLayout();
            this.panelTituloDescripcion.SuspendLayout();
            this.panelDatosProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTituloDatosProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(86, 22);
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
            this.button1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(606, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar al classroom";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDescripcion.Controls.Add(this.txtDescripcion);
            this.panelDescripcion.Controls.Add(this.panelTituloDescripcion);
            this.panelDescripcion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDescripcion.Location = new System.Drawing.Point(17, 78);
            this.panelDescripcion.Name = "panelDescripcion";
            this.panelDescripcion.Size = new System.Drawing.Size(398, 539);
            this.panelDescripcion.TabIndex = 6;
            // 
            // panelTituloDescripcion
            // 
            this.panelTituloDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloDescripcion.Controls.Add(this.lblDescripcion);
            this.panelTituloDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDescripcion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDescripcion.Name = "panelTituloDescripcion";
            this.panelTituloDescripcion.Size = new System.Drawing.Size(398, 58);
            this.panelTituloDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 18);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 25);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // panelDatosProfesor
            // 
            this.panelDatosProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosProfesor.Controls.Add(this.textBox1);
            this.panelDatosProfesor.Controls.Add(this.label2);
            this.panelDatosProfesor.Controls.Add(this.lblApellidosProfesor);
            this.panelDatosProfesor.Controls.Add(this.lblNombreProfesor);
            this.panelDatosProfesor.Controls.Add(this.lblApellido);
            this.panelDatosProfesor.Controls.Add(this.lblNombre);
            this.panelDatosProfesor.Controls.Add(this.pictureBox1);
            this.panelDatosProfesor.Controls.Add(this.panelTituloDatosProfesor);
            this.panelDatosProfesor.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatosProfesor.Location = new System.Drawing.Point(443, 78);
            this.panelDatosProfesor.Name = "panelDatosProfesor";
            this.panelDatosProfesor.Size = new System.Drawing.Size(470, 539);
            this.panelDatosProfesor.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(41, 313);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 23);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(41, 252);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.baseline_account_circle_Big;
            this.pictureBox1.Location = new System.Drawing.Point(179, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTituloDatosProfesor
            // 
            this.panelTituloDatosProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloDatosProfesor.Controls.Add(this.label1);
            this.panelTituloDatosProfesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDatosProfesor.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDatosProfesor.Name = "panelTituloDatosProfesor";
            this.panelTituloDatosProfesor.Size = new System.Drawing.Size(470, 58);
            this.panelTituloDatosProfesor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del profosor";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProfesor.Location = new System.Drawing.Point(159, 253);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(197, 23);
            this.lblNombreProfesor.TabIndex = 6;
            this.lblNombreProfesor.Text = "Nombres del profesor";
            // 
            // lblApellidosProfesor
            // 
            this.lblApellidosProfesor.AutoSize = true;
            this.lblApellidosProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidosProfesor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosProfesor.ForeColor = System.Drawing.Color.White;
            this.lblApellidosProfesor.Location = new System.Drawing.Point(159, 311);
            this.lblApellidosProfesor.Name = "lblApellidosProfesor";
            this.lblApellidosProfesor.Size = new System.Drawing.Size(198, 23);
            this.lblApellidosProfesor.TabIndex = 7;
            this.lblApellidosProfesor.Text = "Apellidos del profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resumen";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(23, 76);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(347, 449);
            this.txtDescripcion.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 390);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 135);
            this.textBox1.TabIndex = 2;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(17, 11);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 25;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // frmExplorarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelDatosProfesor);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExplorarClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExplorarClassroom";
            this.panelDescripcion.ResumeLayout(false);
            this.panelDescripcion.PerformLayout();
            this.panelTituloDescripcion.ResumeLayout(false);
            this.panelTituloDescripcion.PerformLayout();
            this.panelDatosProfesor.ResumeLayout(false);
            this.panelDatosProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTituloDatosProfesor.ResumeLayout(false);
            this.panelTituloDatosProfesor.PerformLayout();
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTituloDatosProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellidosProfesor;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Button btnAtras;
    }
}