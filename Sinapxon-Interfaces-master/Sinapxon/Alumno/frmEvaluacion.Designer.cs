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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreEvaluacion = new System.Windows.Forms.Label();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoverArchivo = new System.Windows.Forms.Button();
            this.btnAniadirArchivo = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedorEntregables = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.lblNombreEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvaluacion.Location = new System.Drawing.Point(96, 31);
            this.lblNombreEvaluacion.Name = "lblNombreEvaluacion";
            this.lblNombreEvaluacion.Size = new System.Drawing.Size(304, 29);
            this.lblNombreEvaluacion.TabIndex = 0;
            this.lblNombreEvaluacion.Text = "Nombre de la evaluación";
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvArchivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.dgvArchivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchivos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArchivos.EnableHeadersVisualStyles = false;
            this.dgvArchivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgvArchivos.Location = new System.Drawing.Point(20, 148);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArchivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArchivos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvArchivos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArchivos.Size = new System.Drawing.Size(423, 403);
            this.dgvArchivos.TabIndex = 3;
            this.dgvArchivos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArchivos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // btnRemoverArchivo
            // 
            this.btnRemoverArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnRemoverArchivo.FlatAppearance.BorderSize = 0;
            this.btnRemoverArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAniadirArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAniadirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirArchivo.FlatAppearance.BorderSize = 0;
            this.btnAniadirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAniadirArchivo.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniadirArchivo.Location = new System.Drawing.Point(20, 79);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(426, 50);
            this.btnAniadirArchivo.TabIndex = 2;
            this.btnAniadirArchivo.Text = "Añadir";
            this.btnAniadirArchivo.UseVisualStyleBackColor = false;
            this.btnAniadirArchivo.Click += new System.EventHandler(this.btnAniadirArchivo_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 17);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(136, 25);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Archivos";
            // 
            // panelContenedorEntregables
            // 
            this.panelContenedorEntregables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedorEntregables.Controls.Add(this.txtDescripcion);
            this.panelContenedorEntregables.Controls.Add(this.lblPeso);
            this.panelContenedorEntregables.Controls.Add(this.panelTituloEntregables);
            this.panelContenedorEntregables.Location = new System.Drawing.Point(12, 77);
            this.panelContenedorEntregables.Name = "panelContenedorEntregables";
            this.panelContenedorEntregables.Size = new System.Drawing.Size(463, 574);
            this.panelContenedorEntregables.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(15, 127);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(434, 424);
            this.txtDescripcion.TabIndex = 3;
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(20, 79);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(171, 16);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso de la evaluacion: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(734, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnGuardar);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnGuardar;
    }
}