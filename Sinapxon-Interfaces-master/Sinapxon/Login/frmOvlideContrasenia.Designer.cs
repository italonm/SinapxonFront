namespace Sinapxon.Login
{
    partial class frmOvlideContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOvlideContrasenia));
            this.lblOlvideContrasenia = new System.Windows.Forms.Label();
            this.gbMetodoRecuparacion = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbLineEmail = new System.Windows.Forms.PictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbMetodoRecuparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOlvideContrasenia
            // 
            this.lblOlvideContrasenia.AutoSize = true;
            this.lblOlvideContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideContrasenia.ForeColor = System.Drawing.Color.White;
            this.lblOlvideContrasenia.Location = new System.Drawing.Point(12, 21);
            this.lblOlvideContrasenia.Name = "lblOlvideContrasenia";
            this.lblOlvideContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOlvideContrasenia.Size = new System.Drawing.Size(259, 29);
            this.lblOlvideContrasenia.TabIndex = 0;
            this.lblOlvideContrasenia.Text = "Olvidé mi contraseña";
            // 
            // gbMetodoRecuparacion
            // 
            this.gbMetodoRecuparacion.Controls.Add(this.lblEmail);
            this.gbMetodoRecuparacion.Controls.Add(this.pbLineEmail);
            this.gbMetodoRecuparacion.Controls.Add(this.txtCorreo);
            this.gbMetodoRecuparacion.Controls.Add(this.pictureBox2);
            this.gbMetodoRecuparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMetodoRecuparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMetodoRecuparacion.ForeColor = System.Drawing.Color.White;
            this.gbMetodoRecuparacion.Location = new System.Drawing.Point(12, 70);
            this.gbMetodoRecuparacion.Name = "gbMetodoRecuparacion";
            this.gbMetodoRecuparacion.Size = new System.Drawing.Size(604, 111);
            this.gbMetodoRecuparacion.TabIndex = 8;
            this.gbMetodoRecuparacion.TabStop = false;
            this.gbMetodoRecuparacion.Text = "Metodo de recuperación";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblEmail.Image")));
            this.lblEmail.Location = new System.Drawing.Point(35, 50);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail registrado";
            // 
            // pbLineEmail
            // 
            this.pbLineEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.pbLineEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbLineEmail.Image")));
            this.pbLineEmail.Location = new System.Drawing.Point(170, 68);
            this.pbLineEmail.Name = "pbLineEmail";
            this.pbLineEmail.Size = new System.Drawing.Size(386, 3);
            this.pbLineEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLineEmail.TabIndex = 10;
            this.pbLineEmail.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(182, 48);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(386, 19);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorreo_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(297, 209);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(150, 45);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(466, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmOvlideContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(632, 276);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbMetodoRecuparacion);
            this.Controls.Add(this.lblOlvideContrasenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(648, 315);
            this.MinimumSize = new System.Drawing.Size(648, 315);
            this.Name = "frmOvlideContrasenia";
            this.Text = "Recuperación de contraseña";
            this.Load += new System.EventHandler(this.frmOvlideContrasenia_Load);
            this.gbMetodoRecuparacion.ResumeLayout(false);
            this.gbMetodoRecuparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOlvideContrasenia;
        private System.Windows.Forms.GroupBox gbMetodoRecuparacion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLineEmail;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEmail;
    }
}