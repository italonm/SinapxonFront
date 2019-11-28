namespace Sinapxon.Alumno
{
    partial class frmMisClassrooms
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pbSinCursos = new System.Windows.Forms.PictureBox();
            this.lblSincursos = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cbPerido = new System.Windows.Forms.ComboBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mis Classrooms";
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelContenido.Controls.Add(this.pbSinCursos);
            this.panelContenido.Controls.Add(this.lblSincursos);
            this.panelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenido.Location = new System.Drawing.Point(33, 73);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(882, 579);
            this.panelContenido.TabIndex = 11;
            // 
            // pbSinCursos
            // 
            this.pbSinCursos.Image = global::Sinapxon.Properties.Resources.round_mood_bad_white_48dp;
            this.pbSinCursos.Location = new System.Drawing.Point(143, 171);
            this.pbSinCursos.Name = "pbSinCursos";
            this.pbSinCursos.Size = new System.Drawing.Size(96, 96);
            this.pbSinCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSinCursos.TabIndex = 1;
            this.pbSinCursos.TabStop = false;
            // 
            // lblSincursos
            // 
            this.lblSincursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSincursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSincursos.ForeColor = System.Drawing.Color.White;
            this.lblSincursos.Location = new System.Drawing.Point(245, 168);
            this.lblSincursos.Name = "lblSincursos";
            this.lblSincursos.Size = new System.Drawing.Size(527, 114);
            this.lblSincursos.TabIndex = 0;
            this.lblSincursos.Text = "Oh! parece que no tienes classroom, ve a la ventana explorar cursos para poder in" +
    "gresar a un classroom";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(33, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cbPerido
            // 
            this.cbPerido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerido.FormattingEnabled = true;
            this.cbPerido.Location = new System.Drawing.Point(730, 13);
            this.cbPerido.Name = "cbPerido";
            this.cbPerido.Size = new System.Drawing.Size(133, 28);
            this.cbPerido.TabIndex = 25;
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.BackColor = System.Drawing.Color.SlateBlue;
            this.btnIr.FlatAppearance.BorderSize = 0;
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.ForeColor = System.Drawing.Color.White;
            this.btnIr.Location = new System.Drawing.Point(869, 13);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(46, 27);
            this.btnIr.TabIndex = 26;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // frmMisClassrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.cbPerido);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMisClassrooms";
            this.Text = "frmMisCursos";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pbSinCursos;
        private System.Windows.Forms.Label lblSincursos;
        private System.Windows.Forms.ComboBox cbPerido;
        private System.Windows.Forms.Button btnIr;
    }
}