namespace Sinapxon.Administrador
{
    partial class frmCurso
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelDatosCurso = new System.Windows.Forms.Panel();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.panelTituloCurso = new System.Windows.Forms.Panel();
            this.lblDatosCurso = new System.Windows.Forms.Label();
            this.panelRequisitos = new System.Windows.Forms.Panel();
            this.panelTituloRequisitos = new System.Windows.Forms.Panel();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitarRequisito = new System.Windows.Forms.Button();
            this.btnAgregarRequisito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
            this.panelDatosCurso.SuspendLayout();
            this.panelTituloCurso.SuspendLayout();
            this.panelRequisitos.SuspendLayout();
            this.panelTituloRequisitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(47, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(77, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Curso";
            // 
            // btnCodigoCurso
            // 
            this.btnCodigoCurso.AutoSize = true;
            this.btnCodigoCurso.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigoCurso.Location = new System.Drawing.Point(32, 72);
            this.btnCodigoCurso.Name = "btnCodigoCurso";
            this.btnCodigoCurso.Size = new System.Drawing.Size(127, 19);
            this.btnCodigoCurso.TabIndex = 1;
            this.btnCodigoCurso.Text = "Codigo del curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(33, 131);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(133, 19);
            this.lblNombreCurso.TabIndex = 2;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(32, 340);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(160, 19);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción del curso";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(34, 270);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(99, 19);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(33, 196);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(58, 19);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.BackColor = System.Drawing.Color.White;
            this.txtCodigoCurso.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCurso.Location = new System.Drawing.Point(36, 94);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(348, 27);
            this.txtCodigoCurso.TabIndex = 7;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.Color.White;
            this.txtNombreCurso.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCurso.Location = new System.Drawing.Point(36, 153);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(348, 27);
            this.txtNombreCurso.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(36, 370);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(348, 189);
            this.txtDescripcion.TabIndex = 9;
            // 
            // dgvRequisitos
            // 
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Location = new System.Drawing.Point(20, 153);
            this.dgvRequisitos.Name = "dgvRequisitos";
            this.dgvRequisitos.Size = new System.Drawing.Size(410, 396);
            this.dgvRequisitos.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(746, 16);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 52);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelDatosCurso
            // 
            this.panelDatosCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosCurso.Controls.Add(this.cbEspecialidad);
            this.panelDatosCurso.Controls.Add(this.cbIdioma);
            this.panelDatosCurso.Controls.Add(this.panelTituloCurso);
            this.panelDatosCurso.Controls.Add(this.lblIdioma);
            this.panelDatosCurso.Controls.Add(this.lblNombreCurso);
            this.panelDatosCurso.Controls.Add(this.txtDescripcion);
            this.panelDatosCurso.Controls.Add(this.txtNombreCurso);
            this.panelDatosCurso.Controls.Add(this.btnCodigoCurso);
            this.panelDatosCurso.Controls.Add(this.lblDescripcion);
            this.panelDatosCurso.Controls.Add(this.txtCodigoCurso);
            this.panelDatosCurso.Controls.Add(this.lblEspecialidad);
            this.panelDatosCurso.Location = new System.Drawing.Point(27, 74);
            this.panelDatosCurso.Name = "panelDatosCurso";
            this.panelDatosCurso.Size = new System.Drawing.Size(405, 580);
            this.panelDatosCurso.TabIndex = 16;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(36, 292);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(348, 27);
            this.cbEspecialidad.TabIndex = 10;
            // 
            // cbIdioma
            // 
            this.cbIdioma.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(36, 218);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(348, 27);
            this.cbIdioma.TabIndex = 9;
            // 
            // panelTituloCurso
            // 
            this.panelTituloCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloCurso.Controls.Add(this.lblDatosCurso);
            this.panelTituloCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCurso.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCurso.Name = "panelTituloCurso";
            this.panelTituloCurso.Size = new System.Drawing.Size(405, 58);
            this.panelTituloCurso.TabIndex = 0;
            // 
            // lblDatosCurso
            // 
            this.lblDatosCurso.AutoSize = true;
            this.lblDatosCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCurso.ForeColor = System.Drawing.Color.White;
            this.lblDatosCurso.Location = new System.Drawing.Point(20, 19);
            this.lblDatosCurso.Name = "lblDatosCurso";
            this.lblDatosCurso.Size = new System.Drawing.Size(160, 25);
            this.lblDatosCurso.TabIndex = 0;
            this.lblDatosCurso.Text = "Datos del curso";
            // 
            // panelRequisitos
            // 
            this.panelRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelRequisitos.Controls.Add(this.btnQuitarRequisito);
            this.panelRequisitos.Controls.Add(this.panelTituloRequisitos);
            this.panelRequisitos.Controls.Add(this.dgvRequisitos);
            this.panelRequisitos.Controls.Add(this.btnAgregarRequisito);
            this.panelRequisitos.Location = new System.Drawing.Point(473, 74);
            this.panelRequisitos.Name = "panelRequisitos";
            this.panelRequisitos.Size = new System.Drawing.Size(450, 580);
            this.panelRequisitos.TabIndex = 17;
            // 
            // panelTituloRequisitos
            // 
            this.panelTituloRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloRequisitos.Controls.Add(this.lblRequisitos);
            this.panelTituloRequisitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloRequisitos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloRequisitos.Name = "panelTituloRequisitos";
            this.panelTituloRequisitos.Size = new System.Drawing.Size(450, 58);
            this.panelTituloRequisitos.TabIndex = 0;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.ForeColor = System.Drawing.Color.White;
            this.lblRequisitos.Location = new System.Drawing.Point(15, 19);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(113, 25);
            this.lblRequisitos.TabIndex = 1;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Sinapxon.Properties.Resources.round_cancel_white_18dp;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(546, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 52);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnQuitarRequisito
            // 
            this.btnQuitarRequisito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarRequisito.FlatAppearance.BorderSize = 0;
            this.btnQuitarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRequisito.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRequisito.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRequisito.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarRequisito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarRequisito.Location = new System.Drawing.Point(230, 93);
            this.btnQuitarRequisito.Name = "btnQuitarRequisito";
            this.btnQuitarRequisito.Size = new System.Drawing.Size(200, 45);
            this.btnQuitarRequisito.TabIndex = 12;
            this.btnQuitarRequisito.Text = "Quitar";
            this.btnQuitarRequisito.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRequisito
            // 
            this.btnAgregarRequisito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAgregarRequisito.FlatAppearance.BorderSize = 0;
            this.btnAgregarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRequisito.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRequisito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRequisito.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAgregarRequisito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRequisito.Location = new System.Drawing.Point(20, 93);
            this.btnAgregarRequisito.Name = "btnAgregarRequisito";
            this.btnAgregarRequisito.Size = new System.Drawing.Size(200, 45);
            this.btnAgregarRequisito.TabIndex = 11;
            this.btnAgregarRequisito.Text = "Agregar";
            this.btnAgregarRequisito.UseVisualStyleBackColor = false;
            this.btnAgregarRequisito.Click += new System.EventHandler(this.btnAgregarRequisito_Click);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelRequisitos);
            this.Controls.Add(this.panelDatosCurso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurso";
            this.Text = "frmAgregarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            this.panelDatosCurso.ResumeLayout(false);
            this.panelDatosCurso.PerformLayout();
            this.panelTituloCurso.ResumeLayout(false);
            this.panelTituloCurso.PerformLayout();
            this.panelRequisitos.ResumeLayout(false);
            this.panelTituloRequisitos.ResumeLayout(false);
            this.panelTituloRequisitos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label btnCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.Button btnAgregarRequisito;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelDatosCurso;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Panel panelTituloCurso;
        private System.Windows.Forms.Label lblDatosCurso;
        private System.Windows.Forms.Panel panelRequisitos;
        private System.Windows.Forms.Button btnQuitarRequisito;
        private System.Windows.Forms.Panel panelTituloRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.Button btnCancelar;
    }
}