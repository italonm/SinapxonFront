namespace Sinapxon.Alumno
{
    partial class frmTema
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
            this.lblNombreTema = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblArchivosTema = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelContenedorDescripcion = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelTituloDescripcion = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveFileDialogArchivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panelContenedorDescripcion.SuspendLayout();
            this.panelTituloDescripcion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreTema
            // 
            this.lblNombreTema.AutoSize = true;
            this.lblNombreTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTema.Location = new System.Drawing.Point(91, 24);
            this.lblNombreTema.Name = "lblNombreTema";
            this.lblNombreTema.Size = new System.Drawing.Size(215, 29);
            this.lblNombreTema.TabIndex = 0;
            this.lblNombreTema.Text = "Nombre del tema";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(11, 70);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(546, 303);
            this.webBrowser2.TabIndex = 3;
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvArchivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.dgvArchivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchivos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArchivos.EnableHeadersVisualStyles = false;
            this.dgvArchivos.Location = new System.Drawing.Point(30, 129);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.ReadOnly = true;
            this.dgvArchivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArchivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArchivos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvArchivos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArchivos.Size = new System.Drawing.Size(838, 237);
            this.dgvArchivos.TabIndex = 10;
            this.dgvArchivos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArchivos_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 14);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(136, 25);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblVideo
            // 
            this.lblVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideo.AutoSize = true;
            this.lblVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.ForeColor = System.Drawing.Color.White;
            this.lblVideo.Location = new System.Drawing.Point(16, 14);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(72, 25);
            this.lblVideo.TabIndex = 12;
            this.lblVideo.Text = "Video";
            // 
            // lblArchivosTema
            // 
            this.lblArchivosTema.AutoSize = true;
            this.lblArchivosTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.lblArchivosTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivosTema.ForeColor = System.Drawing.Color.White;
            this.lblArchivosTema.Location = new System.Drawing.Point(20, 20);
            this.lblArchivosTema.Name = "lblArchivosTema";
            this.lblArchivosTema.Size = new System.Drawing.Size(200, 25);
            this.lblArchivosTema.TabIndex = 13;
            this.lblArchivosTema.Text = "Archivos del tema";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Image = global::Sinapxon.Properties.Resources.baseline_get_app_white_18dp;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.Location = new System.Drawing.Point(644, 68);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(224, 45);
            this.btnDescargar.TabIndex = 4;
            this.btnDescargar.Text = "     Descargar";
            this.btnDescargar.UseMnemonic = false;
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(10, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panelContenedorDescripcion
            // 
            this.panelContenedorDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenedorDescripcion.Controls.Add(this.txtDescripcion);
            this.panelContenedorDescripcion.Controls.Add(this.panelTituloDescripcion);
            this.panelContenedorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedorDescripcion.Location = new System.Drawing.Point(12, 65);
            this.panelContenedorDescripcion.Name = "panelContenedorDescripcion";
            this.panelContenedorDescripcion.Size = new System.Drawing.Size(314, 385);
            this.panelContenedorDescripcion.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(17, 70);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(259, 303);
            this.txtDescripcion.TabIndex = 1;
            // 
            // panelTituloDescripcion
            // 
            this.panelTituloDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloDescripcion.Controls.Add(this.lblDescripcion);
            this.panelTituloDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDescripcion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDescripcion.Name = "panelTituloDescripcion";
            this.panelTituloDescripcion.Size = new System.Drawing.Size(314, 58);
            this.panelTituloDescripcion.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.webBrowser2);
            this.panel1.Location = new System.Drawing.Point(346, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 385);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.lblVideo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 58);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnDescargar);
            this.panel3.Controls.Add(this.dgvArchivos);
            this.panel3.Location = new System.Drawing.Point(10, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 392);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panel4.Controls.Add(this.lblArchivosTema);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 58);
            this.panel4.TabIndex = 0;
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(981, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedorDescripcion);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblNombreTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panelContenedorDescripcion.ResumeLayout(false);
            this.panelContenedorDescripcion.PerformLayout();
            this.panelTituloDescripcion.ResumeLayout(false);
            this.panelTituloDescripcion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTema;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblArchivosTema;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panelContenedorDescripcion;
        private System.Windows.Forms.Panel panelTituloDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.SaveFileDialog saveFileDialogArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}