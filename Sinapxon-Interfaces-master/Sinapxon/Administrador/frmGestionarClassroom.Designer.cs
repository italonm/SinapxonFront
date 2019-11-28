namespace Sinapxon.Administrador
{
    partial class frmGestionarClassroom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSolicitudesPendientes = new System.Windows.Forms.DataGridView();
            this.ID_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInspeccionarSolicitud = new System.Windows.Forms.Button();
            this.dgvSolicitudesAprobadas = new System.Windows.Forms.DataGridView();
            this.ID_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesDesaprobadas = new System.Windows.Forms.DataGridView();
            this.ID_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSolicitudes = new System.Windows.Forms.TabControl();
            this.tabPageSolPendientes = new System.Windows.Forms.TabPage();
            this.tabPageSolAprobadas = new System.Windows.Forms.TabPage();
            this.tabPageSolDesaprobadas = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesDesaprobadas)).BeginInit();
            this.tabControlSolicitudes.SuspendLayout();
            this.tabPageSolPendientes.SuspendLayout();
            this.tabPageSolAprobadas.SuspendLayout();
            this.tabPageSolDesaprobadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes de classrooms";
            // 
            // dgvSolicitudesPendientes
            // 
            this.dgvSolicitudesPendientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudesPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudesPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudesPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_solicitud,
            this.Codigo_curso,
            this.Nombre_curso,
            this.Profesor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudesPendientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudesPendientes.EnableHeadersVisualStyles = false;
            this.dgvSolicitudesPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgvSolicitudesPendientes.Location = new System.Drawing.Point(29, 69);
            this.dgvSolicitudesPendientes.Name = "dgvSolicitudesPendientes";
            this.dgvSolicitudesPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSolicitudesPendientes.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesPendientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitudesPendientes.Size = new System.Drawing.Size(845, 400);
            this.dgvSolicitudesPendientes.TabIndex = 1;
            this.dgvSolicitudesPendientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesPendientes_CellFormatting);
            // 
            // ID_solicitud
            // 
            this.ID_solicitud.HeaderText = "ID solicitud";
            this.ID_solicitud.Name = "ID_solicitud";
            this.ID_solicitud.Width = 200;
            // 
            // Codigo_curso
            // 
            this.Codigo_curso.HeaderText = "Codigo Curso";
            this.Codigo_curso.Name = "Codigo_curso";
            this.Codigo_curso.Width = 160;
            // 
            // Nombre_curso
            // 
            this.Nombre_curso.HeaderText = "Nombre del curso";
            this.Nombre_curso.Name = "Nombre_curso";
            this.Nombre_curso.Width = 250;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            // 
            // btnInspeccionarSolicitud
            // 
            this.btnInspeccionarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInspeccionarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnInspeccionarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnInspeccionarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccionarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccionarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnInspeccionarSolicitud.Location = new System.Drawing.Point(576, 17);
            this.btnInspeccionarSolicitud.Name = "btnInspeccionarSolicitud";
            this.btnInspeccionarSolicitud.Size = new System.Drawing.Size(298, 46);
            this.btnInspeccionarSolicitud.TabIndex = 2;
            this.btnInspeccionarSolicitud.Text = "Inspeccionar solicitud";
            this.btnInspeccionarSolicitud.UseVisualStyleBackColor = false;
            this.btnInspeccionarSolicitud.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSolicitudesAprobadas
            // 
            this.dgvSolicitudesAprobadas.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesAprobadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSolicitudesAprobadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudesAprobadas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvSolicitudesAprobadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudesAprobadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesAprobadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSolicitudesAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesAprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_aprobado,
            this.Codigo_curso_aprobado,
            this.Nombre_curso_aprobado,
            this.Profesor_aprobado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudesAprobadas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSolicitudesAprobadas.EnableHeadersVisualStyles = false;
            this.dgvSolicitudesAprobadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgvSolicitudesAprobadas.Location = new System.Drawing.Point(27, 27);
            this.dgvSolicitudesAprobadas.Name = "dgvSolicitudesAprobadas";
            this.dgvSolicitudesAprobadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSolicitudesAprobadas.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesAprobadas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSolicitudesAprobadas.Size = new System.Drawing.Size(845, 396);
            this.dgvSolicitudesAprobadas.TabIndex = 3;
            this.dgvSolicitudesAprobadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesAprobadas_CellFormatting);
            // 
            // ID_aprobado
            // 
            this.ID_aprobado.HeaderText = "ID solicitud";
            this.ID_aprobado.Name = "ID_aprobado";
            this.ID_aprobado.Width = 200;
            // 
            // Codigo_curso_aprobado
            // 
            this.Codigo_curso_aprobado.HeaderText = "Codigo del curso";
            this.Codigo_curso_aprobado.Name = "Codigo_curso_aprobado";
            this.Codigo_curso_aprobado.Width = 210;
            // 
            // Nombre_curso_aprobado
            // 
            this.Nombre_curso_aprobado.HeaderText = "Nombre del curso";
            this.Nombre_curso_aprobado.Name = "Nombre_curso_aprobado";
            this.Nombre_curso_aprobado.Width = 250;
            // 
            // Profesor_aprobado
            // 
            this.Profesor_aprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor_aprobado.HeaderText = "Profesor";
            this.Profesor_aprobado.Name = "Profesor_aprobado";
            // 
            // dgvSolicitudesDesaprobadas
            // 
            this.dgvSolicitudesDesaprobadas.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesDesaprobadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSolicitudesDesaprobadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudesDesaprobadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudesDesaprobadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudesDesaprobadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSolicitudesDesaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesDesaprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_desaprobado,
            this.Codigo_curso_desaprobado,
            this.Nombre_curso_desaprobado,
            this.Profesor_desaprobado});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudesDesaprobadas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSolicitudesDesaprobadas.EnableHeadersVisualStyles = false;
            this.dgvSolicitudesDesaprobadas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSolicitudesDesaprobadas.Location = new System.Drawing.Point(27, 31);
            this.dgvSolicitudesDesaprobadas.Name = "dgvSolicitudesDesaprobadas";
            this.dgvSolicitudesDesaprobadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSolicitudesDesaprobadas.RowHeadersVisible = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSolicitudesDesaprobadas.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSolicitudesDesaprobadas.Size = new System.Drawing.Size(845, 428);
            this.dgvSolicitudesDesaprobadas.TabIndex = 4;
            this.dgvSolicitudesDesaprobadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesDesaprobadas_CellFormatting);
            // 
            // ID_desaprobado
            // 
            this.ID_desaprobado.HeaderText = "ID Solicitud";
            this.ID_desaprobado.Name = "ID_desaprobado";
            this.ID_desaprobado.Width = 200;
            // 
            // Codigo_curso_desaprobado
            // 
            this.Codigo_curso_desaprobado.HeaderText = "Codigo del curso";
            this.Codigo_curso_desaprobado.Name = "Codigo_curso_desaprobado";
            this.Codigo_curso_desaprobado.Width = 210;
            // 
            // Nombre_curso_desaprobado
            // 
            this.Nombre_curso_desaprobado.HeaderText = "Nombre del curso";
            this.Nombre_curso_desaprobado.Name = "Nombre_curso_desaprobado";
            this.Nombre_curso_desaprobado.Width = 250;
            // 
            // Profesor_desaprobado
            // 
            this.Profesor_desaprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor_desaprobado.HeaderText = "Profesor";
            this.Profesor_desaprobado.Name = "Profesor_desaprobado";
            // 
            // tabControlSolicitudes
            // 
            this.tabControlSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolPendientes);
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolAprobadas);
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolDesaprobadas);
            this.tabControlSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSolicitudes.Location = new System.Drawing.Point(34, 117);
            this.tabControlSolicitudes.Name = "tabControlSolicitudes";
            this.tabControlSolicitudes.SelectedIndex = 0;
            this.tabControlSolicitudes.Size = new System.Drawing.Size(907, 501);
            this.tabControlSolicitudes.TabIndex = 5;
            // 
            // tabPageSolPendientes
            // 
            this.tabPageSolPendientes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPageSolPendientes.Controls.Add(this.dgvSolicitudesPendientes);
            this.tabPageSolPendientes.Controls.Add(this.btnInspeccionarSolicitud);
            this.tabPageSolPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolPendientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageSolPendientes.Location = new System.Drawing.Point(4, 33);
            this.tabPageSolPendientes.Name = "tabPageSolPendientes";
            this.tabPageSolPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolPendientes.Size = new System.Drawing.Size(899, 464);
            this.tabPageSolPendientes.TabIndex = 0;
            this.tabPageSolPendientes.Text = "Pendientes";
            // 
            // tabPageSolAprobadas
            // 
            this.tabPageSolAprobadas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPageSolAprobadas.Controls.Add(this.dgvSolicitudesAprobadas);
            this.tabPageSolAprobadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolAprobadas.Location = new System.Drawing.Point(4, 33);
            this.tabPageSolAprobadas.Name = "tabPageSolAprobadas";
            this.tabPageSolAprobadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolAprobadas.Size = new System.Drawing.Size(899, 468);
            this.tabPageSolAprobadas.TabIndex = 1;
            this.tabPageSolAprobadas.Text = "Aprobadas";
            // 
            // tabPageSolDesaprobadas
            // 
            this.tabPageSolDesaprobadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPageSolDesaprobadas.Controls.Add(this.dgvSolicitudesDesaprobadas);
            this.tabPageSolDesaprobadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolDesaprobadas.Location = new System.Drawing.Point(4, 33);
            this.tabPageSolDesaprobadas.Name = "tabPageSolDesaprobadas";
            this.tabPageSolDesaprobadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolDesaprobadas.Size = new System.Drawing.Size(899, 468);
            this.tabPageSolDesaprobadas.TabIndex = 2;
            this.tabPageSolDesaprobadas.Text = "Desaprobadas";
            // 
            // frmGestionarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.tabControlSolicitudes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarClassroom";
            this.Text = "frmGestionarClassroom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesDesaprobadas)).EndInit();
            this.tabControlSolicitudes.ResumeLayout(false);
            this.tabPageSolPendientes.ResumeLayout(false);
            this.tabPageSolAprobadas.ResumeLayout(false);
            this.tabPageSolDesaprobadas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSolicitudesPendientes;
        private System.Windows.Forms.Button btnInspeccionarSolicitud;
        private System.Windows.Forms.DataGridView dgvSolicitudesAprobadas;
        private System.Windows.Forms.DataGridView dgvSolicitudesDesaprobadas;
        private System.Windows.Forms.TabControl tabControlSolicitudes;
        private System.Windows.Forms.TabPage tabPageSolPendientes;
        private System.Windows.Forms.TabPage tabPageSolAprobadas;
        private System.Windows.Forms.TabPage tabPageSolDesaprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_desaprobado;
    }
}