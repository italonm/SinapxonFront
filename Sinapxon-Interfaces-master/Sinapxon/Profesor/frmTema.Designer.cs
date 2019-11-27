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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTema));
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
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.panelTituloArchivosClassroom = new System.Windows.Forms.Panel();
            this.lblArchivosTema = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panelDatosTema.SuspendLayout();
            this.panelTituloTema.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelTituloVideo.SuspendLayout();
            this.panelArchivosClassroom.SuspendLayout();
            this.panelTituloArchivosClassroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.Black;
            this.lblTema.Location = new System.Drawing.Point(53, 20);
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
            this.lblNombre.Location = new System.Drawing.Point(18, 60);
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
            this.lblDescripcion.Location = new System.Drawing.Point(327, 47);
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
            this.lblLinkVideo.Location = new System.Drawing.Point(20, 54);
            this.lblLinkVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkVideo.Name = "lblLinkVideo";
            this.lblLinkVideo.Size = new System.Drawing.Size(108, 20);
            this.lblLinkVideo.TabIndex = 3;
            this.lblLinkVideo.Text = "URL del video";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(306, 68);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 52);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtLinkVideo
            // 
            this.txtLinkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkVideo.Location = new System.Drawing.Point(21, 80);
            this.txtLinkVideo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinkVideo.Name = "txtLinkVideo";
            this.txtLinkVideo.Size = new System.Drawing.Size(582, 22);
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
            this.btnAniadirArchivo.Location = new System.Drawing.Point(344, 52);
            this.btnAniadirArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAniadirArchivo.Name = "btnAniadirArchivo";
            this.btnAniadirArchivo.Size = new System.Drawing.Size(109, 50);
            this.btnAniadirArchivo.TabIndex = 3;
            this.btnAniadirArchivo.Text = "Añadir";
            this.btnAniadirArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAniadirArchivo.UseVisualStyleBackColor = false;
            this.btnAniadirArchivo.Click += new System.EventHandler(this.btnAniadirArchivo_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.Location = new System.Drawing.Point(254, 63);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(31, 17);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarArchivo
            // 
            this.txtBuscarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarArchivo.Location = new System.Drawing.Point(21, 63);
            this.txtBuscarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarArchivo.Name = "txtBuscarArchivo";
            this.txtBuscarArchivo.Size = new System.Drawing.Size(230, 22);
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
            this.panelDatosTema.Location = new System.Drawing.Point(10, 70);
            this.panelDatosTema.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosTema.Name = "panelDatosTema";
            this.panelDatosTema.Size = new System.Drawing.Size(624, 129);
            this.panelDatosTema.TabIndex = 8;
            // 
            // cbTemas
            // 
            this.cbTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(22, 84);
            this.cbTemas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(213, 28);
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
            this.panelTituloTema.Size = new System.Drawing.Size(624, 44);
            this.panelTituloTema.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 12);
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
            this.panelVideo.Location = new System.Drawing.Point(9, 203);
            this.panelVideo.Margin = new System.Windows.Forms.Padding(2);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(624, 116);
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
            this.panelTituloVideo.Size = new System.Drawing.Size(624, 44);
            this.panelTituloVideo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Video";
            // 
            // panelArchivosClassroom
            // 
            this.panelArchivosClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelArchivosClassroom.Controls.Add(this.txtArchivo);
            this.panelArchivosClassroom.Controls.Add(this.btnQuitarArchivo);
            this.panelArchivosClassroom.Controls.Add(this.btnAniadirArchivo);
            this.panelArchivosClassroom.Controls.Add(this.panelTituloArchivosClassroom);
            this.panelArchivosClassroom.Controls.Add(this.btnExaminar);
            this.panelArchivosClassroom.Controls.Add(this.txtBuscarArchivo);
            this.panelArchivosClassroom.Location = new System.Drawing.Point(10, 325);
            this.panelArchivosClassroom.Margin = new System.Windows.Forms.Padding(2);
            this.panelArchivosClassroom.Name = "panelArchivosClassroom";
            this.panelArchivosClassroom.Size = new System.Drawing.Size(624, 170);
            this.panelArchivosClassroom.TabIndex = 10;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(21, 111);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(230, 22);
            this.txtArchivo.TabIndex = 6;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuitarArchivo.FlatAppearance.BorderSize = 0;
            this.btnQuitarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarArchivo.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarArchivo.Location = new System.Drawing.Point(494, 52);
            this.btnQuitarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(108, 50);
            this.btnQuitarArchivo.TabIndex = 5;
            this.btnQuitarArchivo.Text = "Quitar";
            this.btnQuitarArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarArchivo.UseVisualStyleBackColor = false;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // panelTituloArchivosClassroom
            // 
            this.panelTituloArchivosClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloArchivosClassroom.Controls.Add(this.lblArchivosTema);
            this.panelTituloArchivosClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloArchivosClassroom.Location = new System.Drawing.Point(0, 0);
            this.panelTituloArchivosClassroom.Margin = new System.Windows.Forms.Padding(2);
            this.panelTituloArchivosClassroom.Name = "panelTituloArchivosClassroom";
            this.panelTituloArchivosClassroom.Size = new System.Drawing.Size(624, 44);
            this.panelTituloArchivosClassroom.TabIndex = 0;
            // 
            // lblArchivosTema
            // 
            this.lblArchivosTema.AutoSize = true;
            this.lblArchivosTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivosTema.ForeColor = System.Drawing.Color.White;
            this.lblArchivosTema.Location = new System.Drawing.Point(14, 14);
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
            this.btnGuardar.Location = new System.Drawing.Point(483, 13);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 53);
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
            this.btnAtras.Location = new System.Drawing.Point(10, 15);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(38, 38);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofdPortada";
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(643, 521);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelArchivosClassroom);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.panelDatosTema);
            this.Controls.Add(this.lblTema);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ComboBox cbTemas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}