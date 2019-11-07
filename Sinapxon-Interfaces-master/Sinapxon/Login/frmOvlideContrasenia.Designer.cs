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
            this.lblOlvideContrasenia = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.textNickName = new System.Windows.Forms.TextBox();
            this.gbMetodoRecuparacion = new System.Windows.Forms.GroupBox();
            this.rbNickname = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pbLineNickname = new System.Windows.Forms.PictureBox();
            this.pbLineEmail = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbMetodoRecuparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineNickname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOlvideContrasenia
            // 
            this.lblOlvideContrasenia.AutoSize = true;
            this.lblOlvideContrasenia.Font = new System.Drawing.Font("Roboto Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideContrasenia.ForeColor = System.Drawing.Color.White;
            this.lblOlvideContrasenia.Location = new System.Drawing.Point(12, 9);
            this.lblOlvideContrasenia.Name = "lblOlvideContrasenia";
            this.lblOlvideContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOlvideContrasenia.Size = new System.Drawing.Size(244, 29);
            this.lblOlvideContrasenia.TabIndex = 0;
            this.lblOlvideContrasenia.Text = "Olvidé mi contraseña";
            this.lblOlvideContrasenia.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(163, 50);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(386, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // textNickName
            // 
            this.textNickName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.textNickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNickName.ForeColor = System.Drawing.Color.White;
            this.textNickName.Location = new System.Drawing.Point(163, 128);
            this.textNickName.Name = "textNickName";
            this.textNickName.Size = new System.Drawing.Size(386, 20);
            this.textNickName.TabIndex = 7;
            // 
            // gbMetodoRecuparacion
            // 
            this.gbMetodoRecuparacion.Controls.Add(this.pbLineNickname);
            this.gbMetodoRecuparacion.Controls.Add(this.pbLineEmail);
            this.gbMetodoRecuparacion.Controls.Add(this.rbNickname);
            this.gbMetodoRecuparacion.Controls.Add(this.rbEmail);
            this.gbMetodoRecuparacion.Controls.Add(this.txtCorreo);
            this.gbMetodoRecuparacion.Controls.Add(this.textNickName);
            this.gbMetodoRecuparacion.Controls.Add(this.pictureBox1);
            this.gbMetodoRecuparacion.Controls.Add(this.pictureBox2);
            this.gbMetodoRecuparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMetodoRecuparacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMetodoRecuparacion.ForeColor = System.Drawing.Color.White;
            this.gbMetodoRecuparacion.Location = new System.Drawing.Point(12, 70);
            this.gbMetodoRecuparacion.Name = "gbMetodoRecuparacion";
            this.gbMetodoRecuparacion.Size = new System.Drawing.Size(604, 186);
            this.gbMetodoRecuparacion.TabIndex = 8;
            this.gbMetodoRecuparacion.TabStop = false;
            this.gbMetodoRecuparacion.Text = "Metodo de recuperación";
            // 
            // rbNickname
            // 
            this.rbNickname.AutoSize = true;
            this.rbNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rbNickname.Location = new System.Drawing.Point(30, 126);
            this.rbNickname.Name = "rbNickname";
            this.rbNickname.Size = new System.Drawing.Size(132, 23);
            this.rbNickname.TabIndex = 9;
            this.rbNickname.TabStop = true;
            this.rbNickname.Text = "Usar nickname";
            this.rbNickname.UseVisualStyleBackColor = false;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rbEmail.Location = new System.Drawing.Point(30, 48);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(106, 23);
            this.rbEmail.TabIndex = 8;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Usar e-mail";
            this.rbEmail.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(466, 286);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(150, 45);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar contraseña";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // pbLineNickname
            // 
            this.pbLineNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.pbLineNickname.Image = global::Sinapxon.Properties.Resources.Barra_P_Blanco;
            this.pbLineNickname.Location = new System.Drawing.Point(163, 146);
            this.pbLineNickname.Name = "pbLineNickname";
            this.pbLineNickname.Size = new System.Drawing.Size(386, 3);
            this.pbLineNickname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLineNickname.TabIndex = 12;
            this.pbLineNickname.TabStop = false;
            // 
            // pbLineEmail
            // 
            this.pbLineEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.pbLineEmail.Image = global::Sinapxon.Properties.Resources.Barra_P_Blanco;
            this.pbLineEmail.Location = new System.Drawing.Point(163, 68);
            this.pbLineEmail.Name = "pbLineEmail";
            this.pbLineEmail.Size = new System.Drawing.Size(386, 3);
            this.pbLineEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLineEmail.TabIndex = 10;
            this.pbLineEmail.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinapxon.Properties.Resources.ContenedorTXT;
            this.pictureBox1.Location = new System.Drawing.Point(4, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sinapxon.Properties.Resources.ContenedorTXT;
            this.pictureBox2.Location = new System.Drawing.Point(4, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmOvlideContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbMetodoRecuparacion);
            this.Controls.Add(this.lblOlvideContrasenia);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "frmOvlideContrasenia";
            this.Text = "frmOvlideContrasenia";
            this.gbMetodoRecuparacion.ResumeLayout(false);
            this.gbMetodoRecuparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineNickname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOlvideContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textNickName;
        private System.Windows.Forms.GroupBox gbMetodoRecuparacion;
        private System.Windows.Forms.RadioButton rbNickname;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLineEmail;
        private System.Windows.Forms.PictureBox pbLineNickname;
    }
}