namespace Sinapxon.Alumno
{
    partial class frmEvaluacion
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
            this.lblNombreEvaluacion = new System.Windows.Forms.Label();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.btnRemoverArchivo = new System.Windows.Forms.Button();
            this.btnAniadirArchivo = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedorEntregables = new System.Windows.Forms.Panel();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panelContenedorEntregables.SuspendLayout();
            this.panelTituloEntregables.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEvaluacion
            // 
            this.lblNombreEvaluacion.AutoSize = true;
            this.lblNombreEvaluacion.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvaluacion.Location = new System.Drawing.Point(96, 31);
            this.lblNombreEvaluacion.Name = "lblNombreEvaluacion";
            this.lblNombreEvaluacion.Size = new System.Drawing.Size(281, 29);
            this.lblNombreEvaluacion.TabIndex = 0;
            this.lblNombreEvaluacion.Text = "Nombre de la evaluación";
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Location = new System.Drawing.Point(20, 148);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(423, 403);
            this.dgvArchivos.TabIndex = 3;
            // 
            // btnRemoverArchivo
            // 
            this.btnRemoverArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnRemoverArchivo.FlatAppearance.BorderSize = 0;
            this.btnRemoverArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverArchivo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverArchivo.ForeColor = System.Drawing.Color.White;
            this.btnRemoverArchivo.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnRemoverArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverArchivo.Location = new System.Drawing.Point(236, 79);
            this.btnRemoverArchivo.Name = "btnRemoverArchivo";
            this.btnRemoverArchivo.Size = new System.Drawing.Size(210, 50);
            this.btnRemoverArchivo.TabIndex = 6;
            this.btnRemoverArchivo.Text = "Remover";
            this.btnRemoverArchivo.UseVisualStyleBackColor = false;
            // 
            // btnAniadirArchivo
            // 
            this.btnAniadirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirArchivo.FlatAppearance.BorderSize = 0;
            this.btnAniadirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirArchivo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAniadirArchivo.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniadirArchivo.Location = new System.Drawing.Point(20, 79);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(210, 50);
            this.btnAniadirArchivo.TabIndex = 2;
            this.btnAniadirArchivo.Text = "Añadir";
            this.btnAniadirArchivo.UseVisualStyleBackColor = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 17);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 25);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Archivos";
            // 
            // panelContenedorEntregables
            // 
            this.panelContenedorEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedorEntregables.Controls.Add(this.txtDescripcion);
            this.panelContenedorEntregables.Controls.Add(this.panelTituloEntregables);
            this.panelContenedorEntregables.Location = new System.Drawing.Point(12, 77);
            this.panelContenedorEntregables.Name = "panelContenedorEntregables";
            this.panelContenedorEntregables.Size = new System.Drawing.Size(463, 574);
            this.panelContenedorEntregables.TabIndex = 9;
            // 
            // panelTituloEntregables
            // 
            this.panelTituloEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloEntregables.Controls.Add(this.lblDescripcion);
            this.panelTituloEntregables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEntregables.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEntregables.Name = "panelTituloEntregables";
            this.panelTituloEntregables.Size = new System.Drawing.Size(463, 58);
            this.panelTituloEntregables.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 58);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnAniadirArchivo);
            this.panel2.Controls.Add(this.dgvArchivos);
            this.panel2.Controls.Add(this.btnRemoverArchivo);
            this.panel2.Location = new System.Drawing.Point(481, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 574);
            this.panel2.TabIndex = 10;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(12, 20);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(15, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(434, 472);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(647, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(229, 25);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso de la evaluacion: ";
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContenedorEntregables);
            this.Controls.Add(this.lblNombreEvaluacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvaluacion";
            this.Text = "frmEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panelContenedorEntregables.ResumeLayout(false);
            this.panelContenedorEntregables.PerformLayout();
            this.panelTituloEntregables.ResumeLayout(false);
            this.panelTituloEntregables.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEvaluacion;
        private System.Windows.Forms.Button btnAniadirArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Button btnRemoverArchivo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContenedorEntregables;
        private System.Windows.Forms.Panel panelTituloEntregables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPeso;
    }
}