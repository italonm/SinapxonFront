namespace Sinapxon.Profesor
{
    partial class frmDatosClassroom
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
            this.lblDatosClassroom = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviarSolicitud = new System.Windows.Forms.Button();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cbIdiomas = new System.Windows.Forms.ComboBox();
            this.panelContenedorCursos = new System.Windows.Forms.Panel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBucador = new System.Windows.Forms.Panel();
            this.lblCursos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbContenedorBuscador = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIdioma = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelContenedorCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.panelBucador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContenedorBuscador)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelIdioma.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosClassroom
            // 
            this.lblDatosClassroom.AutoSize = true;
            this.lblDatosClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosClassroom.Location = new System.Drawing.Point(16, 11);
            this.lblDatosClassroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosClassroom.Name = "lblDatosClassroom";
            this.lblDatosClassroom.Size = new System.Drawing.Size(302, 36);
            this.lblDatosClassroom.TabIndex = 0;
            this.lblDatosClassroom.Text = "Datos del classroom";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 20);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(168, 31);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(37, 21);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(114, 31);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(40, 92);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(511, 219);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnEnviarSolicitud
            // 
            this.btnEnviarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEnviarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnEnviarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnEnviarSolicitud.Location = new System.Drawing.Point(989, 22);
            this.btnEnviarSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviarSolicitud.Name = "btnEnviarSolicitud";
            this.btnEnviarSolicitud.Size = new System.Drawing.Size(263, 52);
            this.btnEnviarSolicitud.TabIndex = 9;
            this.btnEnviarSolicitud.Text = "Enviar solicitud";
            this.btnEnviarSolicitud.UseVisualStyleBackColor = false;
            this.btnEnviarSolicitud.Click += new System.EventHandler(this.BtnEnviarSolicitud_Click);
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Location = new System.Drawing.Point(40, 97);
            this.cbPeriodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(511, 33);
            this.cbPeriodos.TabIndex = 10;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(37, 20);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(101, 31);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "Idioma";
            // 
            // cbIdiomas
            // 
            this.cbIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdiomas.FormattingEnabled = true;
            this.cbIdiomas.Location = new System.Drawing.Point(40, 97);
            this.cbIdiomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdiomas.Name = "cbIdiomas";
            this.cbIdiomas.Size = new System.Drawing.Size(511, 33);
            this.cbIdiomas.TabIndex = 16;
            // 
            // panelContenedorCursos
            // 
            this.panelContenedorCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedorCursos.Controls.Add(this.dgvCursos);
            this.panelContenedorCursos.Controls.Add(this.panelBucador);
            this.panelContenedorCursos.Location = new System.Drawing.Point(23, 91);
            this.panelContenedorCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedorCursos.Name = "panelContenedorCursos";
            this.panelContenedorCursos.Size = new System.Drawing.Size(611, 720);
            this.panelContenedorCursos.TabIndex = 17;
            // 
            // dgvCursos
            // 
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.dgvCursos.Location = new System.Drawing.Point(29, 191);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(547, 505);
            this.dgvCursos.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // panelBucador
            // 
            this.panelBucador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelBucador.Controls.Add(this.lblCursos);
            this.panelBucador.Controls.Add(this.btnBuscar);
            this.panelBucador.Controls.Add(this.textBox1);
            this.panelBucador.Controls.Add(this.pbBuscar);
            this.panelBucador.Controls.Add(this.pbContenedorBuscador);
            this.panelBucador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBucador.Location = new System.Drawing.Point(0, 0);
            this.panelBucador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBucador.Name = "panelBucador";
            this.panelBucador.Size = new System.Drawing.Size(611, 161);
            this.panelBucador.TabIndex = 0;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.ForeColor = System.Drawing.Color.White;
            this.lblCursos.Location = new System.Drawing.Point(23, 20);
            this.lblCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(107, 31);
            this.lblCursos.TabIndex = 4;
            this.lblCursos.Text = "Cursos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(492, 75);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 55);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(85, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 23);
            this.textBox1.TabIndex = 2;
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbBuscar.Image = global::Sinapxon.Properties.Resources.round_search;
            this.pbBuscar.Location = new System.Drawing.Point(29, 81);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 36);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBuscar.TabIndex = 1;
            this.pbBuscar.TabStop = false;
            // 
            // pbContenedorBuscador
            // 
            this.pbContenedorBuscador.Image = global::Sinapxon.Properties.Resources.Barra_G4;
            this.pbContenedorBuscador.Location = new System.Drawing.Point(5, 73);
            this.pbContenedorBuscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbContenedorBuscador.Name = "pbContenedorBuscador";
            this.pbContenedorBuscador.Size = new System.Drawing.Size(479, 62);
            this.pbContenedorBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContenedorBuscador.TabIndex = 0;
            this.pbContenedorBuscador.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panelIdioma);
            this.panel1.Controls.Add(this.cbIdiomas);
            this.panel1.Location = new System.Drawing.Point(656, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 161);
            this.panel1.TabIndex = 18;
            // 
            // panelIdioma
            // 
            this.panelIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelIdioma.Controls.Add(this.lblIdioma);
            this.panelIdioma.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIdioma.Location = new System.Drawing.Point(0, 0);
            this.panelIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIdioma.Name = "panelIdioma";
            this.panelIdioma.Size = new System.Drawing.Size(596, 71);
            this.panelIdioma.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbPeriodos);
            this.panel2.Location = new System.Drawing.Point(656, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 159);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.lblPeriodo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 71);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Location = new System.Drawing.Point(656, 474);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 337);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panel5.Controls.Add(this.lblDescripcion);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 71);
            this.panel5.TabIndex = 0;
            // 
            // frmDatosClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1285, 838);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedorCursos);
            this.Controls.Add(this.btnEnviarSolicitud);
            this.Controls.Add(this.lblDatosClassroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatosClassroom";
            this.Text = "frmDatosClassroom";
            this.panelContenedorCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.panelBucador.ResumeLayout(false);
            this.panelBucador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContenedorBuscador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelIdioma.ResumeLayout(false);
            this.panelIdioma.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosClassroom;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEnviarSolicitud;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cbIdiomas;
        private System.Windows.Forms.Panel panelContenedorCursos;
        private System.Windows.Forms.Panel panelBucador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbContenedorBuscador;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelIdioma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}