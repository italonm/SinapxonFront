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
<<<<<<< HEAD
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> etoile3
            this.lblClassroom = new System.Windows.Forms.Label();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.btnQuitarTema = new System.Windows.Forms.Button();
            this.panelTituloTema = new System.Windows.Forms.Panel();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnAniadirTema = new System.Windows.Forms.Button();
            this.btnEditarTema = new System.Windows.Forms.Button();
            this.panelEvaluaciones = new System.Windows.Forms.Panel();
            this.btnCalificarEvaluacion = new System.Windows.Forms.Button();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.btnQuitarEvaluacion = new System.Windows.Forms.Button();
            this.panelTituloEvaluacion = new System.Windows.Forms.Panel();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.btnAniadirEvaluacion = new System.Windows.Forms.Button();
            this.btnEditarEvaluacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassroom.ForeColor = System.Drawing.Color.Black;
            this.lblClassroom.Location = new System.Drawing.Point(85, 28);
            this.lblClassroom.Name = "lblClassroom";
<<<<<<< HEAD
            this.lblClassroom.Size = new System.Drawing.Size(165, 36);
=======
            this.lblClassroom.Size = new System.Drawing.Size(138, 29);
>>>>>>> etoile3
            this.lblClassroom.TabIndex = 0;
            this.lblClassroom.Text = "Classroom";
            // 
            // panelTemas
            // 
            this.panelTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelTemas.Controls.Add(this.dgvTemas);
            this.panelTemas.Controls.Add(this.btnQuitarTema);
            this.panelTemas.Controls.Add(this.panelTituloTema);
            this.panelTemas.Controls.Add(this.btnAniadirTema);
            this.panelTemas.Controls.Add(this.btnEditarTema);
            this.panelTemas.Location = new System.Drawing.Point(24, 76);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(450, 570);
            this.panelTemas.TabIndex = 5;
            // 
            // dgvTemas
            // 
            this.dgvTemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
<<<<<<< HEAD
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Video});
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTemas.DefaultCellStyle = dataGridViewCellStyle2;
>>>>>>> etoile3
            this.dgvTemas.Location = new System.Drawing.Point(15, 136);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.Size = new System.Drawing.Size(420, 420);
            this.dgvTemas.TabIndex = 4;
            this.dgvTemas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemas_CellFormatting);
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarTema.FlatAppearance.BorderSize = 0;
            this.btnQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTema.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTema.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarTema.Location = new System.Drawing.Point(295, 75);
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(140, 55);
            this.btnQuitarTema.TabIndex = 3;
            this.btnQuitarTema.Text = "Quitar";
            this.btnQuitarTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarTema.UseVisualStyleBackColor = false;
            // 
            // panelTituloTema
            // 
            this.panelTituloTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
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
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(9, 17);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(102, 31);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Temas";
            // 
            // btnAniadirTema
            // 
            this.btnAniadirTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirTema.FlatAppearance.BorderSize = 0;
            this.btnAniadirTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirTema.ForeColor = System.Drawing.Color.White;
            this.btnAniadirTema.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirTema.Location = new System.Drawing.Point(15, 75);
            this.btnAniadirTema.Name = "btnAniadirTema";
            this.btnAniadirTema.Size = new System.Drawing.Size(133, 55);
            this.btnAniadirTema.TabIndex = 2;
            this.btnAniadirTema.Text = "Añadir";
            this.btnAniadirTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAniadirTema.UseVisualStyleBackColor = false;
            this.btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            // 
            // btnEditarTema
            // 
            this.btnEditarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEditarTema.FlatAppearance.BorderSize = 0;
            this.btnEditarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTema.ForeColor = System.Drawing.Color.White;
            this.btnEditarTema.Image = global::Sinapxon.Properties.Resources.round_edit_white_18dp;
            this.btnEditarTema.Location = new System.Drawing.Point(150, 75);
            this.btnEditarTema.Name = "btnEditarTema";
            this.btnEditarTema.Size = new System.Drawing.Size(140, 55);
            this.btnEditarTema.TabIndex = 1;
            this.btnEditarTema.Text = "Editar";
            this.btnEditarTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarTema.UseVisualStyleBackColor = false;
            this.btnEditarTema.Click += new System.EventHandler(this.btnEditarTema_Click);
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
            this.panelEvaluaciones.Location = new System.Drawing.Point(491, 76);
            this.panelEvaluaciones.Name = "panelEvaluaciones";
            this.panelEvaluaciones.Size = new System.Drawing.Size(450, 570);
            this.panelEvaluaciones.TabIndex = 6;
            // 
            // btnCalificarEvaluacion
            // 
            this.btnCalificarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnCalificarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnCalificarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnCalificarEvaluacion.Image = global::Sinapxon.Properties.Resources.round_assignment;
            this.btnCalificarEvaluacion.Location = new System.Drawing.Point(249, 66);
            this.btnCalificarEvaluacion.Name = "btnCalificarEvaluacion";
            this.btnCalificarEvaluacion.Size = new System.Drawing.Size(185, 49);
            this.btnCalificarEvaluacion.TabIndex = 4;
            this.btnCalificarEvaluacion.Text = "Calificar";
            this.btnCalificarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalificarEvaluacion.UseVisualStyleBackColor = false;
            this.btnCalificarEvaluacion.Click += new System.EventHandler(this.btnCalificarEvaluacion_Click);
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
<<<<<<< HEAD
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Peso,
            this.Description});
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvaluaciones.DefaultCellStyle = dataGridViewCellStyle4;
>>>>>>> etoile3
            this.dgvEvaluaciones.Location = new System.Drawing.Point(16, 180);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.Size = new System.Drawing.Size(420, 376);
            this.dgvEvaluaciones.TabIndex = 3;
            this.dgvEvaluaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvaluaciones_CellFormatting);
            // 
            // btnQuitarEvaluacion
            // 
            this.btnQuitarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarEvaluacion.Location = new System.Drawing.Point(249, 121);
            this.btnQuitarEvaluacion.Name = "btnQuitarEvaluacion";
            this.btnQuitarEvaluacion.Size = new System.Drawing.Size(187, 53);
            this.btnQuitarEvaluacion.TabIndex = 2;
            this.btnQuitarEvaluacion.Text = "Quitar";
            this.btnQuitarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.ForeColor = System.Drawing.Color.White;
            this.lblEvaluacion.Location = new System.Drawing.Point(24, 17);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(188, 31);
            this.lblEvaluacion.TabIndex = 0;
            this.lblEvaluacion.Text = "Evaluaciones";
            // 
            // btnAniadirEvaluacion
            // 
            this.btnAniadirEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnAniadirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnAniadirEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirEvaluacion.Location = new System.Drawing.Point(16, 66);
            this.btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            this.btnAniadirEvaluacion.Size = new System.Drawing.Size(185, 50);
            this.btnAniadirEvaluacion.TabIndex = 1;
            this.btnAniadirEvaluacion.Text = "Añadir";
            this.btnAniadirEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAniadirEvaluacion.UseVisualStyleBackColor = false;
            this.btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            // 
            // btnEditarEvaluacion
            // 
            this.btnEditarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnEditarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnEditarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarEvaluacion.Image = global::Sinapxon.Properties.Resources.round_edit_white_18dp;
            this.btnEditarEvaluacion.Location = new System.Drawing.Point(16, 121);
            this.btnEditarEvaluacion.Name = "btnEditarEvaluacion";
            this.btnEditarEvaluacion.Size = new System.Drawing.Size(185, 53);
            this.btnEditarEvaluacion.TabIndex = 0;
            this.btnEditarEvaluacion.Text = "Editar";
            this.btnEditarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.btnGuardar.Location = new System.Drawing.Point(758, 19);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 48);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(29, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Video
            // 
            this.Video.HeaderText = "VIdeo";
            this.Video.Name = "Video";
            this.Video.Width = 130;
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Nombre";
            this.Namee.Name = "Namee";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.Width = 180;
            // 
            // frmVerClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelEvaluaciones);
            this.Controls.Add(this.panelTemas);
            this.Controls.Add(this.lblClassroom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerClassroom";
            this.Text = "Editar Classroom";
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}