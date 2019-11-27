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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClassroom = new System.Windows.Forms.Label();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarTema = new System.Windows.Forms.Button();
            this.panelTituloTema = new System.Windows.Forms.Panel();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnAniadirTema = new System.Windows.Forms.Button();
            this.panelEvaluaciones = new System.Windows.Forms.Panel();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.btnQuitarEvaluacion = new System.Windows.Forms.Button();
            this.panelTituloEvaluacion = new System.Windows.Forms.Panel();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.btnAniadirEvaluacion = new System.Windows.Forms.Button();
            this.btnEditarEvaluacion = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
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
            this.lblClassroom.Size = new System.Drawing.Size(161, 29);
            this.lblClassroom.TabIndex = 0;
            this.lblClassroom.Text = "Classroom - ";
            // 
            // panelTemas
            // 
            this.panelTemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTemas.AutoSize = true;
            this.panelTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelTemas.Controls.Add(this.dgvTemas);
            this.panelTemas.Controls.Add(this.btnQuitarTema);
            this.panelTemas.Controls.Add(this.panelTituloTema);
            this.panelTemas.Controls.Add(this.btnAniadirTema);
            this.panelTemas.Location = new System.Drawing.Point(12, 76);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(507, 570);
            this.panelTemas.TabIndex = 5;
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvTemas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.dgvTemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Video});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTemas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTemas.EnableHeadersVisualStyles = false;
            this.dgvTemas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgvTemas.Location = new System.Drawing.Point(15, 139);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTemas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvTemas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTemas.Size = new System.Drawing.Size(476, 395);
            this.dgvTemas.TabIndex = 4;
            this.dgvTemas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemas_CellFormatting);
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
            this.Descripcion.Width = 120;
            // 
            // Video
            // 
            this.Video.HeaderText = "VIdeo";
            this.Video.Name = "Video";
            this.Video.Width = 500;
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarTema.FlatAppearance.BorderSize = 0;
            this.btnQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTema.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTema.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarTema.Location = new System.Drawing.Point(130, 73);
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(109, 45);
            this.btnQuitarTema.TabIndex = 3;
            this.btnQuitarTema.Text = "Quitar";
            this.btnQuitarTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarTema.UseVisualStyleBackColor = false;
            this.btnQuitarTema.Click += new System.EventHandler(this.btnQuitarTema_Click);
            // 
            // panelTituloTema
            // 
            this.panelTituloTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloTema.Controls.Add(this.lblTema);
            this.panelTituloTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloTema.Location = new System.Drawing.Point(0, 0);
            this.panelTituloTema.Name = "panelTituloTema";
            this.panelTituloTema.Size = new System.Drawing.Size(507, 60);
            this.panelTituloTema.TabIndex = 0;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(9, 17);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(82, 25);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Temas";
            // 
            // btnAniadirTema
            // 
            this.btnAniadirTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirTema.FlatAppearance.BorderSize = 0;
            this.btnAniadirTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirTema.ForeColor = System.Drawing.Color.White;
            this.btnAniadirTema.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirTema.Location = new System.Drawing.Point(15, 73);
            this.btnAniadirTema.Name = "btnAniadirTema";
            this.btnAniadirTema.Size = new System.Drawing.Size(109, 45);
            this.btnAniadirTema.TabIndex = 2;
            this.btnAniadirTema.Text = "Añadir";
            this.btnAniadirTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAniadirTema.UseVisualStyleBackColor = false;
            this.btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            // 
            // panelEvaluaciones
            // 
            this.panelEvaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEvaluaciones.AutoSize = true;
            this.panelEvaluaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelEvaluaciones.Controls.Add(this.dgvEvaluaciones);
            this.panelEvaluaciones.Controls.Add(this.btnQuitarEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.panelTituloEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.btnAniadirEvaluacion);
            this.panelEvaluaciones.Controls.Add(this.btnEditarEvaluacion);
            this.panelEvaluaciones.Location = new System.Drawing.Point(539, 76);
            this.panelEvaluaciones.Name = "panelEvaluaciones";
            this.panelEvaluaciones.Size = new System.Drawing.Size(403, 570);
            this.panelEvaluaciones.TabIndex = 6;
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvEvaluaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEvaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvaluaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.dgvEvaluaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Peso,
            this.Description});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvaluaciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEvaluaciones.EnableHeadersVisualStyles = false;
            this.dgvEvaluaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgvEvaluaciones.Location = new System.Drawing.Point(26, 139);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEvaluaciones.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvEvaluaciones.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(360, 418);
            this.dgvEvaluaciones.TabIndex = 3;
            this.dgvEvaluaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvaluaciones_CellFormatting);
            // 
            // btnQuitarEvaluacion
            // 
            this.btnQuitarEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarEvaluacion.Location = new System.Drawing.Point(274, 73);
            this.btnQuitarEvaluacion.Name = "btnQuitarEvaluacion";
            this.btnQuitarEvaluacion.Size = new System.Drawing.Size(109, 45);
            this.btnQuitarEvaluacion.TabIndex = 2;
            this.btnQuitarEvaluacion.Text = "Quitar";
            this.btnQuitarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarEvaluacion.UseVisualStyleBackColor = false;
            this.btnQuitarEvaluacion.Click += new System.EventHandler(this.btnQuitarEvaluacion_Click);
            // 
            // panelTituloEvaluacion
            // 
            this.panelTituloEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelTituloEvaluacion.Controls.Add(this.lblEvaluacion);
            this.panelTituloEvaluacion.Location = new System.Drawing.Point(0, 0);
            this.panelTituloEvaluacion.Name = "panelTituloEvaluacion";
            this.panelTituloEvaluacion.Size = new System.Drawing.Size(400, 60);
            this.panelTituloEvaluacion.TabIndex = 0;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluacion.ForeColor = System.Drawing.Color.White;
            this.lblEvaluacion.Location = new System.Drawing.Point(24, 17);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(153, 25);
            this.lblEvaluacion.TabIndex = 0;
            this.lblEvaluacion.Text = "Evaluaciones";
            // 
            // btnAniadirEvaluacion
            // 
            this.btnAniadirEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAniadirEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnAniadirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadirEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnAniadirEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAniadirEvaluacion.Location = new System.Drawing.Point(23, 73);
            this.btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            this.btnAniadirEvaluacion.Size = new System.Drawing.Size(109, 45);
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
            this.btnEditarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvaluacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarEvaluacion.Image = global::Sinapxon.Properties.Resources.modificar;
            this.btnEditarEvaluacion.Location = new System.Drawing.Point(138, 73);
            this.btnEditarEvaluacion.Name = "btnEditarEvaluacion";
            this.btnEditarEvaluacion.Size = new System.Drawing.Size(130, 45);
            this.btnEditarEvaluacion.TabIndex = 0;
            this.btnEditarEvaluacion.Text = "Calificar";
            this.btnEditarEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEvaluacion.UseVisualStyleBackColor = false;
            this.btnEditarEvaluacion.Click += new System.EventHandler(this.btnEditarEvaluacion_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(55, 50);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Nombre";
            this.Namee.Name = "Namee";
            this.Namee.Width = 150;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.Width = 400;
            // 
            // frmVerClassroom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnAtras);
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
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.Button btnQuitarEvaluacion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}