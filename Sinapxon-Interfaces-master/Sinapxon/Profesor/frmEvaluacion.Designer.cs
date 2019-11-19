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
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreEvaluacion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreEvaluacion = new System.Windows.Forms.Label();
            this.btnGuardarEvaluacion = new System.Windows.Forms.Button();
            this.panelDatosEvaluacion = new System.Windows.Forms.Panel();
            this.lblTemas = new System.Windows.Forms.Label();
            this.panelTituloDatosEvaluacion = new System.Windows.Forms.Panel();
            this.lblDatosEvaluacion = new System.Windows.Forms.Label();
            this.panelEntregables = new System.Windows.Forms.Panel();
            this.btnQuitarEvaluacion = new System.Windows.Forms.Button();
            this.btnAgregarEntregable = new System.Windows.Forms.Button();
            this.dgvEntregables = new System.Windows.Forms.DataGridView();
            this.panelTituloEntregables = new System.Windows.Forms.Panel();
            this.lblEntregable = new System.Windows.Forms.Label();
            this.cbTemas = new System.Windows.Forms.ComboBox();
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
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.Location = new System.Drawing.Point(13, 13);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(172, 36);
            this.lblEvaluacion.TabIndex = 0;
            this.lblEvaluacion.Text = "Evaluación";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(324, 63);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 25);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(328, 96);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(107, 26);
            this.txtPeso.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 181);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(413, 103);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombreEvaluacion
            // 
            this.txtNombreEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvaluacion.Location = new System.Drawing.Point(21, 96);
            this.txtNombreEvaluacion.Name = "txtNombreEvaluacion";
            this.txtNombreEvaluacion.Size = new System.Drawing.Size(291, 26);
            this.txtNombreEvaluacion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(17, 143);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombreEvaluacion
            // 
            this.lblNombreEvaluacion.AutoSize = true;
            this.lblNombreEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvaluacion.Location = new System.Drawing.Point(17, 63);
            this.lblNombreEvaluacion.Name = "lblNombreEvaluacion";
            this.lblNombreEvaluacion.Size = new System.Drawing.Size(250, 25);
            this.lblNombreEvaluacion.TabIndex = 0;
            this.lblNombreEvaluacion.Text = "Nombre de la evaluación";
            // 
            // btnGuardarEvaluacion
            // 
            this.btnGuardarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEvaluacion.Location = new System.Drawing.Point(700, 13);
            this.btnGuardarEvaluacion.Name = "btnGuardarEvaluacion";
            this.btnGuardarEvaluacion.Size = new System.Drawing.Size(228, 52);
            this.btnGuardarEvaluacion.TabIndex = 2;
            this.btnGuardarEvaluacion.Text = "Guardar evaluación";
            this.btnGuardarEvaluacion.UseVisualStyleBackColor = false;
            this.btnGuardarEvaluacion.Click += new System.EventHandler(this.btnGuardarEvaluacion_Click);
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
            this.panelDatosEvaluacion.Location = new System.Drawing.Point(18, 86);
            this.panelDatosEvaluacion.Name = "panelDatosEvaluacion";
            this.panelDatosEvaluacion.Size = new System.Drawing.Size(460, 519);
            this.panelDatosEvaluacion.TabIndex = 3;
            // 
            // lblTemas
            // 
            this.lblTemas.AutoSize = true;
            this.lblTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemas.Location = new System.Drawing.Point(17, 326);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(217, 25);
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
            this.panelTituloDatosEvaluacion.Name = "panelTituloDatosEvaluacion";
            this.panelTituloDatosEvaluacion.Size = new System.Drawing.Size(460, 45);
            this.panelTituloDatosEvaluacion.TabIndex = 0;
            // 
            // lblDatosEvaluacion
            // 
            this.lblDatosEvaluacion.AutoSize = true;
            this.lblDatosEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEvaluacion.ForeColor = System.Drawing.Color.White;
            this.lblDatosEvaluacion.Location = new System.Drawing.Point(16, 8);
            this.lblDatosEvaluacion.Name = "lblDatosEvaluacion";
            this.lblDatosEvaluacion.Size = new System.Drawing.Size(310, 31);
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
            this.panelEntregables.Location = new System.Drawing.Point(508, 86);
            this.panelEntregables.Name = "panelEntregables";
            this.panelEntregables.Size = new System.Drawing.Size(420, 519);
            this.panelEntregables.TabIndex = 4;
            // 
            // btnQuitarEvaluacion
            // 
            this.btnQuitarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarEvaluacion.Location = new System.Drawing.Point(234, 74);
            this.btnQuitarEvaluacion.Name = "btnQuitarEvaluacion";
            this.btnQuitarEvaluacion.Size = new System.Drawing.Size(171, 45);
            this.btnQuitarEvaluacion.TabIndex = 3;
            this.btnQuitarEvaluacion.Text = "Quitar";
            this.btnQuitarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEntregable
            // 
            this.btnAgregarEntregable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAgregarEntregable.FlatAppearance.BorderSize = 0;
            this.btnAgregarEntregable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEntregable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntregable.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEntregable.Location = new System.Drawing.Point(15, 74);
            this.btnAgregarEntregable.Name = "btnAgregarEntregable";
            this.btnAgregarEntregable.Size = new System.Drawing.Size(171, 45);
            this.btnAgregarEntregable.TabIndex = 2;
            this.btnAgregarEntregable.Text = "Añadir";
            this.btnAgregarEntregable.UseVisualStyleBackColor = false;
            // 
            // dgvEntregables
            // 
            this.dgvEntregables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEntregables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregables.Location = new System.Drawing.Point(15, 143);
            this.dgvEntregables.Name = "dgvEntregables";
            this.dgvEntregables.Size = new System.Drawing.Size(390, 357);
            this.dgvEntregables.TabIndex = 1;
            // 
            // panelTituloEntregables
            // 
            this.panelTituloEntregables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloEntregables.Controls.Add(this.lblEntregable);
            this.panelTituloEntregables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEntregables.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEntregables.Name = "panelTituloEntregables";
            this.panelTituloEntregables.Size = new System.Drawing.Size(420, 45);
            this.panelTituloEntregables.TabIndex = 0;
            // 
            // lblEntregable
            // 
            this.lblEntregable.AutoSize = true;
            this.lblEntregable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregable.ForeColor = System.Drawing.Color.White;
            this.lblEntregable.Location = new System.Drawing.Point(12, 8);
            this.lblEntregable.Name = "lblEntregable";
            this.lblEntregable.Size = new System.Drawing.Size(170, 31);
            this.lblEntregable.TabIndex = 0;
            this.lblEntregable.Text = "Entregables";
            // 
            // cbTemas
            // 
            this.cbTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(21, 377);
            this.cbTemas.Margin = new System.Windows.Forms.Padding(4);
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(414, 33);
            this.cbTemas.TabIndex = 17;
            // 
            // frmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.panelEntregables);
            this.Controls.Add(this.panelDatosEvaluacion);
            this.Controls.Add(this.btnGuardarEvaluacion);
            this.Controls.Add(this.lblEvaluacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAniadirEvaluacion";
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
        private System.Windows.Forms.Button btnGuardarEvaluacion;
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
    }
}