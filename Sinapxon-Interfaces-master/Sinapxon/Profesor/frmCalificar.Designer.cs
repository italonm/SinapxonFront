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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTituloAlumnos = new System.Windows.Forms.Panel();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.panelEntregables = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsignarPuntaje = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.lblEntregables = new System.Windows.Forms.Label();
            this.panelArchivos = new System.Windows.Forms.Panel();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panelTituloArchivos = new System.Windows.Forms.Panel();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTituloAlumnos.SuspendLayout();
            this.panelEntregables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelTituloEntregables.SuspendLayout();
            this.panelArchivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelTituloArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificación - Nombre de la evaluación";
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelAlumnos.Controls.Add(this.dataGridView1);
            this.panelAlumnos.Controls.Add(this.panelTituloAlumnos);
            this.panelAlumnos.Location = new System.Drawing.Point(22, 81);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(420, 539);
            this.panelAlumnos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 452);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelTituloAlumnos
            // 
            this.panelTituloAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloAlumnos.Controls.Add(this.lblAlumnos);
            this.panelTituloAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAlumnos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAlumnos.Name = "panelTituloAlumnos";
            this.panelTituloAlumnos.Size = new System.Drawing.Size(420, 58);
            this.panelTituloAlumnos.TabIndex = 0;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(10, 16);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(102, 25);
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
            this.panelEntregables.Location = new System.Drawing.Point(475, 81);
            this.panelEntregables.Name = "panelEntregables";
            this.panelEntregables.Size = new System.Drawing.Size(440, 236);
            this.panelEntregables.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntaje";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // btnAsignarPuntaje
            // 
            this.btnAsignarPuntaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAsignarPuntaje.FlatAppearance.BorderSize = 0;
            this.btnAsignarPuntaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPuntaje.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPuntaje.Image = global::Sinapxon.Properties.Resources.round_assignment_turned_in_white_18dp;
            this.btnAsignarPuntaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarPuntaje.Location = new System.Drawing.Point(244, 64);
            this.btnAsignarPuntaje.Name = "btnAsignarPuntaje";
            this.btnAsignarPuntaje.Size = new System.Drawing.Size(181, 45);
            this.btnAsignarPuntaje.TabIndex = 3;
            this.btnAsignarPuntaje.Text = "Asignar puntaje";
            this.btnAsignarPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarPuntaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignarPuntaje.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(410, 110);
            this.dataGridView2.TabIndex = 2;
            // 
            // panelTituloEntregables
            // 
            this.panelTituloEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloEntregables.Controls.Add(this.lblEntregables);
            this.panelTituloEntregables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEntregables.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEntregables.Name = "panelTituloEntregables";
            this.panelTituloEntregables.Size = new System.Drawing.Size(440, 58);
            this.panelTituloEntregables.TabIndex = 0;
            // 
            // lblEntregables
            // 
            this.lblEntregables.AutoSize = true;
            this.lblEntregables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregables.ForeColor = System.Drawing.Color.White;
            this.lblEntregables.Location = new System.Drawing.Point(10, 16);
            this.lblEntregables.Name = "lblEntregables";
            this.lblEntregables.Size = new System.Drawing.Size(138, 25);
            this.lblEntregables.TabIndex = 1;
            this.lblEntregables.Text = "Entregables";
            // 
            // panelArchivos
            // 
            this.panelArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelArchivos.Controls.Add(this.btnDescargar);
            this.panelArchivos.Controls.Add(this.dataGridView3);
            this.panelArchivos.Controls.Add(this.panelTituloArchivos);
            this.panelArchivos.Location = new System.Drawing.Point(474, 323);
            this.panelArchivos.Name = "panelArchivos";
            this.panelArchivos.Size = new System.Drawing.Size(440, 297);
            this.panelArchivos.TabIndex = 2;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Image = global::Sinapxon.Properties.Resources.baseline_get_app_white_18dp1;
            this.btnDescargar.Location = new System.Drawing.Point(245, 64);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(180, 45);
            this.btnDescargar.TabIndex = 6;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 116);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(410, 165);
            this.dataGridView3.TabIndex = 3;
            // 
            // panelTituloArchivos
            // 
            this.panelTituloArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloArchivos.Controls.Add(this.lblArchivos);
            this.panelTituloArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloArchivos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloArchivos.Name = "panelTituloArchivos";
            this.panelTituloArchivos.Size = new System.Drawing.Size(440, 58);
            this.panelTituloArchivos.TabIndex = 0;
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivos.ForeColor = System.Drawing.Color.White;
            this.lblArchivos.Location = new System.Drawing.Point(10, 20);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(103, 25);
            this.lblArchivos.TabIndex = 2;
            this.lblArchivos.Text = "Archivos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.baseline_save_white_24dp;
            this.btnGuardar.Location = new System.Drawing.Point(755, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 58);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(22, 25);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // frmCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelArchivos);
            this.Controls.Add(this.panelEntregables);
            this.Controls.Add(this.panelAlumnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCalificar";
            this.Text = "Registro de Calificación";
            this.panelAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTituloAlumnos.ResumeLayout(false);
            this.panelTituloAlumnos.PerformLayout();
            this.panelEntregables.ResumeLayout(false);
            this.panelEntregables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelTituloEntregables.ResumeLayout(false);
            this.panelTituloEntregables.PerformLayout();
            this.panelArchivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelTituloArchivos.ResumeLayout(false);
            this.panelTituloArchivos.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnAtras;
    }
}