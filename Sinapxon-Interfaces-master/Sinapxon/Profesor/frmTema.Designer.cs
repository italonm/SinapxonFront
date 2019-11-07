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
            this.lblTema = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLinkVideo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLinkVideo = new System.Windows.Forms.TextBox();
            this.btnAniadirArchivo = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtBuscarArchivo = new System.Windows.Forms.TextBox();
            this.btnGuardarTema = new System.Windows.Forms.Button();
            this.panelDatosTema = new System.Windows.Forms.Panel();
            this.panelTituloTema = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.panelTituloVideo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelArchivosClassroom = new System.Windows.Forms.Panel();
            this.panelTituloArchivosClassroom = new System.Windows.Forms.Panel();
            this.lblArchivosTema = new System.Windows.Forms.Label();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.panelDatosTema.SuspendLayout();
            this.panelTituloTema.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelTituloVideo.SuspendLayout();
            this.panelArchivosClassroom.SuspendLayout();
            this.panelTituloArchivosClassroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(13, 19);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(74, 29);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del tema";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(34, 102);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblLinkVideo
            // 
            this.lblLinkVideo.AutoSize = true;
            this.lblLinkVideo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkVideo.Location = new System.Drawing.Point(34, 56);
            this.lblLinkVideo.Name = "lblLinkVideo";
            this.lblLinkVideo.Size = new System.Drawing.Size(108, 19);
            this.lblLinkVideo.TabIndex = 3;
            this.lblLinkVideo.Text = "URL del video";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(38, 124);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(831, 55);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(38, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(831, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtLinkVideo
            // 
            this.txtLinkVideo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkVideo.Location = new System.Drawing.Point(38, 81);
            this.txtLinkVideo.Name = "txtLinkVideo";
            this.txtLinkVideo.Size = new System.Drawing.Size(831, 23);
            this.txtLinkVideo.TabIndex = 4;
            // 
            // btnAniadirArchivo
            // 
            this.btnAniadirArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirArchivo.FlatAppearance.BorderSize = 0;
            this.btnAniadirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirArchivo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAniadirArchivo.Location = new System.Drawing.Point(533, 52);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(160, 35);
            this.btnAniadirArchivo.TabIndex = 3;
            this.btnAniadirArchivo.Text = "Añadir archivo";
            this.btnAniadirArchivo.UseVisualStyleBackColor = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(450, 58);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(42, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarArchivo
            // 
            this.txtBuscarArchivo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarArchivo.Location = new System.Drawing.Point(38, 58);
            this.txtBuscarArchivo.Name = "txtBuscarArchivo";
            this.txtBuscarArchivo.Size = new System.Drawing.Size(406, 23);
            this.txtBuscarArchivo.TabIndex = 1;
            // 
            // btnGuardarTema
            // 
            this.btnGuardarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardarTema.FlatAppearance.BorderSize = 0;
            this.btnGuardarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTema.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTema.Location = new System.Drawing.Point(714, 19);
            this.btnGuardarTema.Name = "btnGuardarTema";
            this.btnGuardarTema.Size = new System.Drawing.Size(206, 38);
            this.btnGuardarTema.TabIndex = 7;
            this.btnGuardarTema.Text = "Guardar tema";
            this.btnGuardarTema.UseVisualStyleBackColor = false;
            this.btnGuardarTema.Click += new System.EventHandler(this.btnGuardarTema_Click);
            // 
            // panelDatosTema
            // 
            this.panelDatosTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosTema.Controls.Add(this.txtDescripcion);
            this.panelDatosTema.Controls.Add(this.panelTituloTema);
            this.panelDatosTema.Controls.Add(this.lblDescripcion);
            this.panelDatosTema.Controls.Add(this.txtNombre);
            this.panelDatosTema.Controls.Add(this.lblNombre);
            this.panelDatosTema.Location = new System.Drawing.Point(18, 63);
            this.panelDatosTema.Name = "panelDatosTema";
            this.panelDatosTema.Size = new System.Drawing.Size(902, 194);
            this.panelDatosTema.TabIndex = 8;
            // 
            // panelTituloTema
            // 
            this.panelTituloTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloTema.Controls.Add(this.label1);
            this.panelTituloTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloTema.Location = new System.Drawing.Point(0, 0);
            this.panelTituloTema.Name = "panelTituloTema";
            this.panelTituloTema.Size = new System.Drawing.Size(902, 45);
            this.panelTituloTema.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos generales del tema";
            // 
            // panelVideo
            // 
            this.panelVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelVideo.Controls.Add(this.txtLinkVideo);
            this.panelVideo.Controls.Add(this.panelTituloVideo);
            this.panelVideo.Controls.Add(this.lblLinkVideo);
            this.panelVideo.Location = new System.Drawing.Point(18, 278);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(902, 116);
            this.panelVideo.TabIndex = 9;
            // 
            // panelTituloVideo
            // 
            this.panelTituloVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloVideo.Controls.Add(this.label2);
            this.panelTituloVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloVideo.Location = new System.Drawing.Point(0, 0);
            this.panelTituloVideo.Name = "panelTituloVideo";
            this.panelTituloVideo.Size = new System.Drawing.Size(902, 45);
            this.panelTituloVideo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
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
            this.panelArchivosClassroom.Location = new System.Drawing.Point(18, 414);
            this.panelArchivosClassroom.Name = "panelArchivosClassroom";
            this.panelArchivosClassroom.Size = new System.Drawing.Size(902, 216);
            this.panelArchivosClassroom.TabIndex = 10;
            // 
            // panelTituloArchivosClassroom
            // 
            this.panelTituloArchivosClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloArchivosClassroom.Controls.Add(this.lblArchivosTema);
            this.panelTituloArchivosClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloArchivosClassroom.Location = new System.Drawing.Point(0, 0);
            this.panelTituloArchivosClassroom.Name = "panelTituloArchivosClassroom";
            this.panelTituloArchivosClassroom.Size = new System.Drawing.Size(902, 45);
            this.panelTituloArchivosClassroom.TabIndex = 0;
            // 
            // lblArchivosTema
            // 
            this.lblArchivosTema.AutoSize = true;
            this.lblArchivosTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivosTema.ForeColor = System.Drawing.Color.White;
            this.lblArchivosTema.Location = new System.Drawing.Point(15, 11);
            this.lblArchivosTema.Name = "lblArchivosTema";
            this.lblArchivosTema.Size = new System.Drawing.Size(183, 25);
            this.lblArchivosTema.TabIndex = 0;
            this.lblArchivosTema.Text = "Archivos del tema";
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Location = new System.Drawing.Point(38, 96);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.Size = new System.Drawing.Size(831, 104);
            this.dgvArchivos.TabIndex = 4;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarArchivo.FlatAppearance.BorderSize = 0;
            this.btnQuitarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarArchivo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarArchivo.Location = new System.Drawing.Point(709, 52);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(160, 35);
            this.btnQuitarArchivo.TabIndex = 5;
            this.btnQuitarArchivo.Text = "Quitar arrchivo";
            this.btnQuitarArchivo.UseVisualStyleBackColor = false;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(948, 642);
            this.Controls.Add(this.panelArchivosClassroom);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panelDatosTema);
            this.Controls.Add(this.btnGuardarTema);
            this.Controls.Add(this.lblTema);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAniadirTema";
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
            this.panelTituloArchivosClassroom.ResumeLayout(false);
            this.panelTituloArchivosClassroom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLinkVideo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLinkVideo;
        private System.Windows.Forms.Button btnAniadirArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtBuscarArchivo;
        private System.Windows.Forms.Button btnGuardarTema;
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
    }
}