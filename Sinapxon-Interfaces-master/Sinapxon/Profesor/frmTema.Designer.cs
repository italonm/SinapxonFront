namespace Sinapxon.Profesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLinkVideo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLinkVideo = new System.Windows.Forms.TextBox();
            this.btnAniadirArchivo = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtBuscarArchivo = new System.Windows.Forms.TextBox();
            this.panelDatosTema = new System.Windows.Forms.Panel();
            this.cbTemas = new System.Windows.Forms.ComboBox();
            this.panelTituloTema = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.panelTituloVideo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelArchivosClassroom = new System.Windows.Forms.Panel();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.panelTituloArchivosClassroom = new System.Windows.Forms.Panel();
            this.lblArchivosTema = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panelDatosTema.SuspendLayout();
            this.panelTituloTema.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelTituloVideo.SuspendLayout();
            this.panelArchivosClassroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panelTituloArchivosClassroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.Black;
            this.lblTema.Location = new System.Drawing.Point(71, 31);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(80, 29);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del tema";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(436, 62);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblLinkVideo
            // 
            this.lblLinkVideo.AutoSize = true;
            this.lblLinkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkVideo.Location = new System.Drawing.Point(26, 71);
            this.lblLinkVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkVideo.Name = "lblLinkVideo";
            this.lblLinkVideo.Size = new System.Drawing.Size(108, 20);
            this.lblLinkVideo.TabIndex = 3;
            this.lblLinkVideo.Text = "URL del video";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(408, 84);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(394, 67);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtLinkVideo
            // 
            this.txtLinkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkVideo.Location = new System.Drawing.Point(28, 93);
            this.txtLinkVideo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinkVideo.Name = "txtLinkVideo";
            this.txtLinkVideo.Size = new System.Drawing.Size(774, 22);
            this.txtLinkVideo.TabIndex = 4;
            // 
            // btnAniadirArchivo
            // 
            this.btnAniadirArchivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAniadirArchivo.FlatAppearance.BorderSize = 0;
            this.btnAniadirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAniadirArchivo.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirArchivo.Location = new System.Drawing.Point(458, 68);
            this.btnAniadirArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(145, 47);
            this.btnAniadirArchivo.TabIndex = 3;
            this.btnAniadirArchivo.Text = "Añadir";
            this.btnAniadirArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAniadirArchivo.UseVisualStyleBackColor = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(338, 82);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(41, 22);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarArchivo
            // 
            this.txtBuscarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarArchivo.Location = new System.Drawing.Point(28, 82);
            this.txtBuscarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarArchivo.Name = "txtBuscarArchivo";
            this.txtBuscarArchivo.Size = new System.Drawing.Size(306, 22);
            this.txtBuscarArchivo.TabIndex = 1;
            // 
            // panelDatosTema
            // 
            this.panelDatosTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosTema.Controls.Add(this.cbTemas);
            this.panelDatosTema.Controls.Add(this.txtDescripcion);
            this.panelDatosTema.Controls.Add(this.panelTituloTema);
            this.panelDatosTema.Controls.Add(this.lblDescripcion);
            this.panelDatosTema.Controls.Add(this.lblNombre);
            this.panelDatosTema.Location = new System.Drawing.Point(14, 91);
            this.panelDatosTema.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosTema.Name = "panelDatosTema";
            this.panelDatosTema.Size = new System.Drawing.Size(832, 169);
            this.panelDatosTema.TabIndex = 8;
            // 
            // cbTemas
            // 
            this.cbTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(30, 105);
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(283, 28);
            this.cbTemas.TabIndex = 17;
            // 
            // panelTituloTema
            // 
            this.panelTituloTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloTema.Controls.Add(this.label1);
            this.panelTituloTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloTema.Location = new System.Drawing.Point(0, 0);
            this.panelTituloTema.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloTema.Name = "panelTituloTema";
            this.panelTituloTema.Size = new System.Drawing.Size(832, 58);
            this.panelTituloTema.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos generales del tema";
            // 
            // panelVideo
            // 
            this.panelVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelVideo.Controls.Add(this.txtLinkVideo);
            this.panelVideo.Controls.Add(this.panelTituloVideo);
            this.panelVideo.Controls.Add(this.lblLinkVideo);
            this.panelVideo.Location = new System.Drawing.Point(14, 274);
            this.panelVideo.Margin = new System.Windows.Forms.Padding(2);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(832, 133);
            this.panelVideo.TabIndex = 9;
            // 
            // panelTituloVideo
            // 
            this.panelTituloVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloVideo.Controls.Add(this.label2);
            this.panelTituloVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloVideo.Location = new System.Drawing.Point(0, 0);
            this.panelTituloVideo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloVideo.Name = "panelTituloVideo";
            this.panelTituloVideo.Size = new System.Drawing.Size(832, 58);
            this.panelTituloVideo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Video";
            // 
            // panelArchivosClassroom
            // 
            this.panelArchivosClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelArchivosClassroom.Controls.Add(this.btnQuitarArchivo);
            this.panelArchivosClassroom.Controls.Add(this.dgvArchivos);
            this.panelArchivosClassroom.Controls.Add(this.btnAniadirArchivo);
            this.panelArchivosClassroom.Controls.Add(this.panelTituloArchivosClassroom);
            this.panelArchivosClassroom.Controls.Add(this.btnExaminar);
            this.panelArchivosClassroom.Controls.Add(this.txtBuscarArchivo);
            this.panelArchivosClassroom.Location = new System.Drawing.Point(14, 425);
            this.panelArchivosClassroom.Margin = new System.Windows.Forms.Padding(2);
            this.panelArchivosClassroom.Name = "panelArchivosClassroom";
            this.panelArchivosClassroom.Size = new System.Drawing.Size(832, 222);
            this.panelArchivosClassroom.TabIndex = 10;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuitarArchivo.FlatAppearance.BorderSize = 0;
            this.btnQuitarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarArchivo.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarArchivo.Location = new System.Drawing.Point(658, 68);
            this.btnQuitarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(144, 47);
            this.btnQuitarArchivo.TabIndex = 5;
            this.btnQuitarArchivo.Text = "Quitar";
            this.btnQuitarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarArchivo.UseVisualStyleBackColor = false;
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArchivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArchivos.Location = new System.Drawing.Point(28, 131);
            this.dgvArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(774, 78);
            this.dgvArchivos.TabIndex = 4;
            // 
            // panelTituloArchivosClassroom
            // 
            this.panelTituloArchivosClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloArchivosClassroom.Controls.Add(this.lblArchivosTema);
            this.panelTituloArchivosClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloArchivosClassroom.Location = new System.Drawing.Point(0, 0);
            this.panelTituloArchivosClassroom.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloArchivosClassroom.Name = "panelTituloArchivosClassroom";
            this.panelTituloArchivosClassroom.Size = new System.Drawing.Size(832, 58);
            this.panelTituloArchivosClassroom.TabIndex = 0;
            // 
            // lblArchivosTema
            // 
            this.lblArchivosTema.AutoSize = true;
            this.lblArchivosTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivosTema.ForeColor = System.Drawing.Color.White;
            this.lblArchivosTema.Location = new System.Drawing.Point(19, 18);
            this.lblArchivosTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArchivosTema.Name = "lblArchivosTema";
            this.lblArchivosTema.Size = new System.Drawing.Size(200, 25);
            this.lblArchivosTema.TabIndex = 0;
            this.lblArchivosTema.Text = "Archivos del tema";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.btnGuardar.Location = new System.Drawing.Point(660, 17);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 48);
            this.btnGuardar.TabIndex = 6;
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
            this.btnAtras.Location = new System.Drawing.Point(14, 19);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(857, 681);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelArchivosClassroom);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panelDatosTema);
            this.Controls.Add(this.lblTema);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Tema";
            this.panelDatosTema.ResumeLayout(false);
            this.panelDatosTema.PerformLayout();
            this.panelTituloTema.ResumeLayout(false);
            this.panelTituloTema.PerformLayout();
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            this.panelTituloVideo.ResumeLayout(false);
            this.panelTituloVideo.PerformLayout();
            this.panelArchivosClassroom.ResumeLayout(false);
            this.panelArchivosClassroom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panelTituloArchivosClassroom.ResumeLayout(false);
            this.panelTituloArchivosClassroom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLinkVideo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtLinkVideo;
        private System.Windows.Forms.Button btnAniadirArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtBuscarArchivo;
        private System.Windows.Forms.Panel panelDatosTema;
        private System.Windows.Forms.Panel panelTituloTema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Panel panelTituloVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelArchivosClassroom;
        private System.Windows.Forms.Panel panelTituloArchivosClassroom;
        private System.Windows.Forms.Label lblArchivosTema;
        private System.Windows.Forms.Button btnQuitarArchivo;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.ComboBox cbTemas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
    }
}