namespace Sinapxon.Profesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreEvaluacion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreEvaluacion = new System.Windows.Forms.Label();
            this.panelDatosEvaluacion = new System.Windows.Forms.Panel();
            this.cbTemas = new System.Windows.Forms.ComboBox();
            this.lblTemas = new System.Windows.Forms.Label();
            this.panelTituloDatosEvaluacion = new System.Windows.Forms.Panel();
            this.lblDatosEvaluacion = new System.Windows.Forms.Label();
            this.panelEntregables = new System.Windows.Forms.Panel();
            this.btnQuitarEvaluacion = new System.Windows.Forms.Button();
            this.btnAgregarEntregable = new System.Windows.Forms.Button();
            this.dgvEntregables = new System.Windows.Forms.DataGridView();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.lblEntregable = new System.Windows.Forms.Label();
            this.butGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelDatosEvaluacion.SuspendLayout();
            this.panelTituloDatosEvaluacion.SuspendLayout();
            this.panelEntregables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregables)).BeginInit();
            this.panelTituloEntregables.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.ForeColor = System.Drawing.Color.Black;
            this.lblEvaluacion.Location = new System.Drawing.Point(81, 29);
            this.lblEvaluacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(130, 29);
            this.lblEvaluacion.TabIndex = 0;
            this.lblEvaluacion.Text = "Evaluación";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(333, 72);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(44, 19);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(337, 97);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(89, 22);
            this.txtPeso.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(17, 271);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(401, 258);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombreEvaluacion
            // 
            this.txtNombreEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvaluacion.Location = new System.Drawing.Point(16, 97);
            this.txtNombreEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEvaluacion.Name = "txtNombreEvaluacion";
            this.txtNombreEvaluacion.Size = new System.Drawing.Size(317, 22);
            this.txtNombreEvaluacion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 231);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombreEvaluacion
            // 
            this.lblNombreEvaluacion.AutoSize = true;
            this.lblNombreEvaluacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvaluacion.Location = new System.Drawing.Point(13, 72);
            this.lblNombreEvaluacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEvaluacion.Name = "lblNombreEvaluacion";
            this.lblNombreEvaluacion.Size = new System.Drawing.Size(184, 19);
            this.lblNombreEvaluacion.TabIndex = 0;
            this.lblNombreEvaluacion.Text = "Nombre de la evaluación";
            // 
            // panelDatosEvaluacion
            // 
            this.panelDatosEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosEvaluacion.Controls.Add(this.cbTemas);
            this.panelDatosEvaluacion.Controls.Add(this.lblTemas);
            this.panelDatosEvaluacion.Controls.Add(this.lblDescripcion);
            this.panelDatosEvaluacion.Controls.Add(this.txtDescripcion);
            this.panelDatosEvaluacion.Controls.Add(this.panelTituloDatosEvaluacion);
            this.panelDatosEvaluacion.Controls.Add(this.txtPeso);
            this.panelDatosEvaluacion.Controls.Add(this.lblPeso);
            this.panelDatosEvaluacion.Controls.Add(this.lblNombreEvaluacion);
            this.panelDatosEvaluacion.Controls.Add(this.txtNombreEvaluacion);
            this.panelDatosEvaluacion.Location = new System.Drawing.Point(12, 84);
            this.panelDatosEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosEvaluacion.Name = "panelDatosEvaluacion";
            this.panelDatosEvaluacion.Size = new System.Drawing.Size(448, 547);
            this.panelDatosEvaluacion.TabIndex = 3;
            // 
            // cbTemas
            // 
            this.cbTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(16, 178);
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(410, 28);
            this.cbTemas.TabIndex = 17;
            // 
            // lblTemas
            // 
            this.lblTemas.AutoSize = true;
            this.lblTemas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemas.Location = new System.Drawing.Point(13, 141);
            this.lblTemas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(160, 19);
            this.lblTemas.TabIndex = 7;
            this.lblTemas.Text = "Temas del classroom";
            this.lblTemas.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTituloDatosEvaluacion
            // 
            this.panelTituloDatosEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloDatosEvaluacion.Controls.Add(this.lblDatosEvaluacion);
            this.panelTituloDatosEvaluacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDatosEvaluacion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDatosEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloDatosEvaluacion.Name = "panelTituloDatosEvaluacion";
            this.panelTituloDatosEvaluacion.Size = new System.Drawing.Size(448, 58);
            this.panelTituloDatosEvaluacion.TabIndex = 0;
            // 
            // lblDatosEvaluacion
            // 
            this.lblDatosEvaluacion.AutoSize = true;
            this.lblDatosEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblDatosEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEvaluacion.ForeColor = System.Drawing.Color.White;
            this.lblDatosEvaluacion.Location = new System.Drawing.Point(12, 18);
            this.lblDatosEvaluacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosEvaluacion.Name = "lblDatosEvaluacion";
            this.lblDatosEvaluacion.Size = new System.Drawing.Size(253, 25);
            this.lblDatosEvaluacion.TabIndex = 0;
            this.lblDatosEvaluacion.Text = "Datos de la evaluación";
            // 
            // panelEntregables
            // 
            this.panelEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelEntregables.Controls.Add(this.btnQuitarEvaluacion);
            this.panelEntregables.Controls.Add(this.btnAgregarEntregable);
            this.panelEntregables.Controls.Add(this.dgvEntregables);
            this.panelEntregables.Controls.Add(this.panelTituloEntregables);
            this.panelEntregables.Location = new System.Drawing.Point(493, 84);
            this.panelEntregables.Margin = new System.Windows.Forms.Padding(2);
            this.panelEntregables.Name = "panelEntregables";
            this.panelEntregables.Size = new System.Drawing.Size(444, 547);
            this.panelEntregables.TabIndex = 4;
            // 
            // btnQuitarEvaluacion
            // 
            this.btnQuitarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEvaluacion.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarEvaluacion.Location = new System.Drawing.Point(242, 79);
            this.btnQuitarEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarEvaluacion.Name = "btnQuitarEvaluacion";
            this.btnQuitarEvaluacion.Size = new System.Drawing.Size(186, 48);
            this.btnQuitarEvaluacion.TabIndex = 3;
            this.btnQuitarEvaluacion.Text = "Quitar";
            this.btnQuitarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEntregable
            // 
            this.btnAgregarEntregable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAgregarEntregable.FlatAppearance.BorderSize = 0;
            this.btnAgregarEntregable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEntregable.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntregable.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEntregable.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAgregarEntregable.Location = new System.Drawing.Point(13, 79);
            this.btnAgregarEntregable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEntregable.Name = "btnAgregarEntregable";
            this.btnAgregarEntregable.Size = new System.Drawing.Size(196, 48);
            this.btnAgregarEntregable.TabIndex = 2;
            this.btnAgregarEntregable.Text = "Añadir";
            this.btnAgregarEntregable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarEntregable.UseVisualStyleBackColor = false;
            // 
            // dgvEntregables
            // 
            this.dgvEntregables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntregables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntregables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntregables.Location = new System.Drawing.Point(13, 134);
            this.dgvEntregables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEntregables.Name = "dgvEntregables";
            this.dgvEntregables.Size = new System.Drawing.Size(415, 401);
            this.dgvEntregables.TabIndex = 1;
            // 
            // panelTituloEntregables
            // 
            this.panelTituloEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloEntregables.Controls.Add(this.lblEntregable);
            this.panelTituloEntregables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEntregables.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEntregables.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloEntregables.Name = "panelTituloEntregables";
            this.panelTituloEntregables.Size = new System.Drawing.Size(444, 58);
            this.panelTituloEntregables.TabIndex = 0;
            // 
            // lblEntregable
            // 
            this.lblEntregable.AutoSize = true;
            this.lblEntregable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregable.ForeColor = System.Drawing.Color.White;
            this.lblEntregable.Location = new System.Drawing.Point(18, 18);
            this.lblEntregable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntregable.Name = "lblEntregable";
            this.lblEntregable.Size = new System.Drawing.Size(138, 25);
            this.lblEntregable.TabIndex = 0;
            this.lblEntregable.Text = "Entregables";
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.butGuardar.FlatAppearance.BorderSize = 0;
            this.butGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGuardar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.ForeColor = System.Drawing.Color.White;
            this.butGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.butGuardar.Location = new System.Drawing.Point(779, 21);
            this.butGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(156, 48);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butGuardar.UseVisualStyleBackColor = false;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(12, 18);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.panelEntregables);
            this.Controls.Add(this.panelDatosEvaluacion);
            this.Controls.Add(this.lblEvaluacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Evaluación";
            this.panelDatosEvaluacion.ResumeLayout(false);
            this.panelDatosEvaluacion.PerformLayout();
            this.panelTituloDatosEvaluacion.ResumeLayout(false);
            this.panelTituloDatosEvaluacion.PerformLayout();
            this.panelEntregables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregables)).EndInit();
            this.panelTituloEntregables.ResumeLayout(false);
            this.panelTituloEntregables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreEvaluacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreEvaluacion;
        private System.Windows.Forms.Panel panelDatosEvaluacion;
        private System.Windows.Forms.Panel panelTituloDatosEvaluacion;
        private System.Windows.Forms.Label lblDatosEvaluacion;
        private System.Windows.Forms.Panel panelEntregables;
        private System.Windows.Forms.Panel panelTituloEntregables;
        private System.Windows.Forms.Label lblEntregable;
        private System.Windows.Forms.Button btnQuitarEvaluacion;
        private System.Windows.Forms.Button btnAgregarEntregable;
        private System.Windows.Forms.DataGridView dgvEntregables;
        private System.Windows.Forms.Label lblTemas;
        private System.Windows.Forms.ComboBox cbTemas;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button btnAtras;
    }
}