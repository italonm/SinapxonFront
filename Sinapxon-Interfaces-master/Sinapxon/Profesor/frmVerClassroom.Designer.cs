namespace Sinapxon.Profesor
{
    partial class frmVerClassroom
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
            this.lblClassroom = new System.Windows.Forms.Label();
            this.btnAniadirTema = new System.Windows.Forms.Button();
            this.btnEditarTema = new System.Windows.Forms.Button();
            this.btnAniadirEvaluacion = new System.Windows.Forms.Button();
            this.btnEditarEvaluacion = new System.Windows.Forms.Button();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.btnQuitarTema = new System.Windows.Forms.Button();
            this.panelTituloTema = new System.Windows.Forms.Panel();
            this.lblTema = new System.Windows.Forms.Label();
            this.panelEvaluaciones = new System.Windows.Forms.Panel();
            this.btnCalificarEvaluacion = new System.Windows.Forms.Button();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.btnQuitarEvaluacion = new System.Windows.Forms.Button();
            this.panelTituloEvaluacion = new System.Windows.Forms.Panel();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.panelTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.panelTituloTema.SuspendLayout();
            this.panelEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.panelTituloEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClassroom
            // 
            this.lblClassroom.AutoSize = true;
            this.lblClassroom.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassroom.Location = new System.Drawing.Point(12, 28);
            this.lblClassroom.Name = "lblClassroom";
            this.lblClassroom.Size = new System.Drawing.Size(130, 29);
            this.lblClassroom.TabIndex = 0;
            this.lblClassroom.Text = "Classroom";
            // 
            // btnAniadirTema
            // 
            this.btnAniadirTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirTema.FlatAppearance.BorderSize = 0;
            this.btnAniadirTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirTema.ForeColor = System.Drawing.Color.White;
            this.btnAniadirTema.Location = new System.Drawing.Point(6, 75);
            this.btnAniadirTema.Name = "btnAniadirTema";
            this.btnAniadirTema.Size = new System.Drawing.Size(140, 40);
            this.btnAniadirTema.TabIndex = 2;
            this.btnAniadirTema.Text = "Añadir";
            this.btnAniadirTema.UseVisualStyleBackColor = false;
            this.btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            // 
            // btnEditarTema
            // 
            this.btnEditarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEditarTema.FlatAppearance.BorderSize = 0;
            this.btnEditarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTema.ForeColor = System.Drawing.Color.White;
            this.btnEditarTema.Location = new System.Drawing.Point(154, 75);
            this.btnEditarTema.Name = "btnEditarTema";
            this.btnEditarTema.Size = new System.Drawing.Size(140, 40);
            this.btnEditarTema.TabIndex = 1;
            this.btnEditarTema.Text = "Editar";
            this.btnEditarTema.UseVisualStyleBackColor = false;
            this.btnEditarTema.Click += new System.EventHandler(this.btnEditarTema_Click);
            // 
            // btnAniadirEvaluacion
            // 
            this.btnAniadirEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnAniadirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirEvaluacion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnAniadirEvaluacion.Location = new System.Drawing.Point(20, 75);
            this.btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            this.btnAniadirEvaluacion.Size = new System.Drawing.Size(185, 40);
            this.btnAniadirEvaluacion.TabIndex = 1;
            this.btnAniadirEvaluacion.Text = "Añadir";
            this.btnAniadirEvaluacion.UseVisualStyleBackColor = false;
            this.btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            // 
            // btnEditarEvaluacion
            // 
            this.btnEditarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEditarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnEditarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEvaluacion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarEvaluacion.Location = new System.Drawing.Point(20, 121);
            this.btnEditarEvaluacion.Name = "btnEditarEvaluacion";
            this.btnEditarEvaluacion.Size = new System.Drawing.Size(185, 40);
            this.btnEditarEvaluacion.TabIndex = 0;
            this.btnEditarEvaluacion.Text = "Editar";
            this.btnEditarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // panelTemas
            // 
            this.panelTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelTemas.Controls.Add(this.dgvTemas);
            this.panelTemas.Controls.Add(this.btnQuitarTema);
            this.panelTemas.Controls.Add(this.panelTituloTema);
            this.panelTemas.Controls.Add(this.btnAniadirTema);
            this.panelTemas.Controls.Add(this.btnEditarTema);
            this.panelTemas.Location = new System.Drawing.Point(18, 90);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(450, 570);
            this.panelTemas.TabIndex = 5;
            // 
            // dgvTemas
            // 
            this.dgvTemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Location = new System.Drawing.Point(15, 136);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.Size = new System.Drawing.Size(420, 420);
            this.dgvTemas.TabIndex = 4;
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarTema.FlatAppearance.BorderSize = 0;
            this.btnQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTema.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTema.Location = new System.Drawing.Point(302, 75);
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(140, 40);
            this.btnQuitarTema.TabIndex = 3;
            this.btnQuitarTema.Text = "Quitar";
            this.btnQuitarTema.UseVisualStyleBackColor = false;
            // 
            // panelTituloTema
            // 
            this.panelTituloTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloTema.Controls.Add(this.lblTema);
            this.panelTituloTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloTema.Location = new System.Drawing.Point(0, 0);
            this.panelTituloTema.Name = "panelTituloTema";
            this.panelTituloTema.Size = new System.Drawing.Size(450, 60);
            this.panelTituloTema.TabIndex = 0;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(9, 17);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(75, 25);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Temas";
            // 
            // panelEvaluaciones
            // 
            this.panelEvaluaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelEvaluaciones.Controls.Add(this.btnCalificarEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.dgvEvaluaciones);
            this.panelEvaluaciones.Controls.Add(this.btnQuitarEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.panelTituloEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.btnAniadirEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.btnEditarEvaluacion);
            this.panelEvaluaciones.Location = new System.Drawing.Point(493, 90);
            this.panelEvaluaciones.Name = "panelEvaluaciones";
            this.panelEvaluaciones.Size = new System.Drawing.Size(450, 570);
            this.panelEvaluaciones.TabIndex = 6;
            // 
            // btnCalificarEvaluacion
            // 
            this.btnCalificarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnCalificarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnCalificarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificarEvaluacion.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnCalificarEvaluacion.Location = new System.Drawing.Point(249, 75);
            this.btnCalificarEvaluacion.Name = "btnCalificarEvaluacion";
            this.btnCalificarEvaluacion.Size = new System.Drawing.Size(185, 40);
            this.btnCalificarEvaluacion.TabIndex = 4;
            this.btnCalificarEvaluacion.Text = "Calificar";
            this.btnCalificarEvaluacion.UseVisualStyleBackColor = false;
            this.btnCalificarEvaluacion.Click += new System.EventHandler(this.btnCalificarEvaluacion_Click);
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Location = new System.Drawing.Point(16, 171);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.Size = new System.Drawing.Size(420, 385);
            this.dgvEvaluaciones.TabIndex = 3;
            // 
            // btnQuitarEvaluacion
            // 
            this.btnQuitarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEvaluacion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarEvaluacion.Location = new System.Drawing.Point(249, 121);
            this.btnQuitarEvaluacion.Name = "btnQuitarEvaluacion";
            this.btnQuitarEvaluacion.Size = new System.Drawing.Size(185, 40);
            this.btnQuitarEvaluacion.TabIndex = 2;
            this.btnQuitarEvaluacion.Text = "Quitar";
            this.btnQuitarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // panelTituloEvaluacion
            // 
            this.panelTituloEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloEvaluacion.Controls.Add(this.lblEvaluacion);
            this.panelTituloEvaluacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloEvaluacion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEvaluacion.Name = "panelTituloEvaluacion";
            this.panelTituloEvaluacion.Size = new System.Drawing.Size(450, 60);
            this.panelTituloEvaluacion.TabIndex = 0;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.ForeColor = System.Drawing.Color.White;
            this.lblEvaluacion.Location = new System.Drawing.Point(24, 17);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(138, 25);
            this.lblEvaluacion.TabIndex = 0;
            this.lblEvaluacion.Text = "Evaluaciones";
            // 
            // frmVerClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.panelEvaluaciones);
            this.Controls.Add(this.panelTemas);
            this.Controls.Add(this.lblClassroom);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerClassroom";
            this.Text = "frmEditarClassroom";
            this.panelTemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.panelTituloTema.ResumeLayout(false);
            this.panelTituloTema.PerformLayout();
            this.panelEvaluaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.panelTituloEvaluacion.ResumeLayout(false);
            this.panelTituloEvaluacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassroom;
        private System.Windows.Forms.Button btnAniadirTema;
        private System.Windows.Forms.Button btnEditarTema;
        private System.Windows.Forms.Button btnAniadirEvaluacion;
        private System.Windows.Forms.Button btnEditarEvaluacion;
        private System.Windows.Forms.Panel panelTemas;
        private System.Windows.Forms.Panel panelEvaluaciones;
        private System.Windows.Forms.Panel panelTituloTema;
        private System.Windows.Forms.Button btnQuitarTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Panel panelTituloEvaluacion;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.Button btnCalificarEvaluacion;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.Button btnQuitarEvaluacion;
    }
}