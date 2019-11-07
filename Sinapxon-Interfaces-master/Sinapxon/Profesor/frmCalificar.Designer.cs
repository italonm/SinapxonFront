namespace Sinapxon.Profesor
{
    partial class frmCalificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelAlumnos = new System.Windows.Forms.Panel();
            this.panelTituloAlumnos = new System.Windows.Forms.Panel();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.panelEntregables = new System.Windows.Forms.Panel();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.lblEntregables = new System.Windows.Forms.Label();
            this.panelArchivos = new System.Windows.Forms.Panel();
            this.panelTituloArchivos = new System.Windows.Forms.Panel();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAsignarPuntaje = new System.Windows.Forms.Button();
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelAlumnos.SuspendLayout();
            this.panelTituloAlumnos.SuspendLayout();
            this.panelEntregables.SuspendLayout();
            this.panelTituloEntregables.SuspendLayout();
            this.panelArchivos.SuspendLayout();
            this.panelTituloArchivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificacion - Nombre de la evaluación";
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelAlumnos.Controls.Add(this.dataGridView1);
            this.panelAlumnos.Controls.Add(this.panelTituloAlumnos);
            this.panelAlumnos.Location = new System.Drawing.Point(17, 81);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(420, 539);
            this.panelAlumnos.TabIndex = 1;
            // 
            // panelTituloAlumnos
            // 
            this.panelTituloAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloAlumnos.Controls.Add(this.lblAlumnos);
            this.panelTituloAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAlumnos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAlumnos.Name = "panelTituloAlumnos";
            this.panelTituloAlumnos.Size = new System.Drawing.Size(420, 45);
            this.panelTituloAlumnos.TabIndex = 0;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(13, 10);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(97, 25);
            this.lblAlumnos.TabIndex = 0;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // panelEntregables
            // 
            this.panelEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelEntregables.Controls.Add(this.label2);
            this.panelEntregables.Controls.Add(this.textBox1);
            this.panelEntregables.Controls.Add(this.btnAsignarPuntaje);
            this.panelEntregables.Controls.Add(this.dataGridView2);
            this.panelEntregables.Controls.Add(this.panelTituloEntregables);
            this.panelEntregables.Location = new System.Drawing.Point(470, 81);
            this.panelEntregables.Name = "panelEntregables";
            this.panelEntregables.Size = new System.Drawing.Size(440, 236);
            this.panelEntregables.TabIndex = 2;
            // 
            // panelTituloEntregables
            // 
            this.panelTituloEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloEntregables.Controls.Add(this.lblEntregables);
            this.panelTituloEntregables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEntregables.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEntregables.Name = "panelTituloEntregables";
            this.panelTituloEntregables.Size = new System.Drawing.Size(440, 45);
            this.panelTituloEntregables.TabIndex = 0;
            // 
            // lblEntregables
            // 
            this.lblEntregables.AutoSize = true;
            this.lblEntregables.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregables.ForeColor = System.Drawing.Color.White;
            this.lblEntregables.Location = new System.Drawing.Point(14, 10);
            this.lblEntregables.Name = "lblEntregables";
            this.lblEntregables.Size = new System.Drawing.Size(125, 25);
            this.lblEntregables.TabIndex = 1;
            this.lblEntregables.Text = "Entregables";
            // 
            // panelArchivos
            // 
            this.panelArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelArchivos.Controls.Add(this.btnDescargarArchivo);
            this.panelArchivos.Controls.Add(this.dataGridView3);
            this.panelArchivos.Controls.Add(this.panelTituloArchivos);
            this.panelArchivos.Location = new System.Drawing.Point(470, 323);
            this.panelArchivos.Name = "panelArchivos";
            this.panelArchivos.Size = new System.Drawing.Size(440, 297);
            this.panelArchivos.TabIndex = 2;
            // 
            // panelTituloArchivos
            // 
            this.panelTituloArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloArchivos.Controls.Add(this.lblArchivos);
            this.panelTituloArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloArchivos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloArchivos.Name = "panelTituloArchivos";
            this.panelTituloArchivos.Size = new System.Drawing.Size(440, 45);
            this.panelTituloArchivos.TabIndex = 0;
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivos.ForeColor = System.Drawing.Color.White;
            this.lblArchivos.Location = new System.Drawing.Point(14, 10);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(97, 25);
            this.lblArchivos.TabIndex = 2;
            this.lblArchivos.Text = "Archivos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(410, 119);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 114);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(410, 160);
            this.dataGridView3.TabIndex = 3;
            // 
            // btnAsignarPuntaje
            // 
            this.btnAsignarPuntaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAsignarPuntaje.FlatAppearance.BorderSize = 0;
            this.btnAsignarPuntaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPuntaje.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPuntaje.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPuntaje.Location = new System.Drawing.Point(277, 51);
            this.btnAsignarPuntaje.Name = "btnAsignarPuntaje";
            this.btnAsignarPuntaje.Size = new System.Drawing.Size(148, 45);
            this.btnAsignarPuntaje.TabIndex = 3;
            this.btnAsignarPuntaje.Text = "Asignar puntaje";
            this.btnAsignarPuntaje.UseVisualStyleBackColor = false;
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnDescargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnDescargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarArchivo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnDescargarArchivo.Location = new System.Drawing.Point(277, 60);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(148, 45);
            this.btnDescargarArchivo.TabIndex = 4;
            this.btnDescargarArchivo.Text = "Descargar archivo";
            this.btnDescargarArchivo.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntaje";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(751, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 44);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelArchivos);
            this.Controls.Add(this.panelEntregables);
            this.Controls.Add(this.panelAlumnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCalificar";
            this.Text = "frmCalificar";
            this.panelAlumnos.ResumeLayout(false);
            this.panelTituloAlumnos.ResumeLayout(false);
            this.panelTituloAlumnos.PerformLayout();
            this.panelEntregables.ResumeLayout(false);
            this.panelEntregables.PerformLayout();
            this.panelTituloEntregables.ResumeLayout(false);
            this.panelTituloEntregables.PerformLayout();
            this.panelArchivos.ResumeLayout(false);
            this.panelTituloArchivos.ResumeLayout(false);
            this.panelTituloArchivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAlumnos;
        private System.Windows.Forms.Panel panelTituloAlumnos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Panel panelEntregables;
        private System.Windows.Forms.Panel panelTituloEntregables;
        private System.Windows.Forms.Label lblEntregables;
        private System.Windows.Forms.Panel panelArchivos;
        private System.Windows.Forms.Panel panelTituloArchivos;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAsignarPuntaje;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDescargarArchivo;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGuardar;
    }
}