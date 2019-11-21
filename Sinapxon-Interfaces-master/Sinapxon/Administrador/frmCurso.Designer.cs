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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelRequisitos = new System.Windows.Forms.Panel();
            this.btnQuitarRequisito = new System.Windows.Forms.Button();
            this.panelTituloRequisitos = new System.Windows.Forms.Panel();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarRequisito = new System.Windows.Forms.Button();
            this.panelDatosCurso = new System.Windows.Forms.Panel();
            this.btnAgregarEsp = new System.Windows.Forms.Button();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.panelTituloCurso = new System.Windows.Forms.Panel();
            this.lblDatosCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.btnCodigoCurso = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panelRequisitos.SuspendLayout();
            this.panelTituloRequisitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
            this.panelDatosCurso.SuspendLayout();
            this.panelTituloCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnRegresar.Location = new System.Drawing.Point(34, 19);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 50);
            this.btnRegresar.TabIndex = 86;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnModificar);
            this.panel5.Location = new System.Drawing.Point(34, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 48);
            this.panel5.TabIndex = 87;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Sinapxon.Properties.Resources.round_insert_drive_file_white_18dp;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 42);
            this.btnNuevo.TabIndex = 75;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sinapxon.Properties.Resources.round_save_white_18dp;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(185, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 42);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Sinapxon.Properties.Resources.round_delete_white_18dp;
            this.btnEliminar.Location = new System.Drawing.Point(398, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 42);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Sinapxon.Properties.Resources.round_cancel_white_18dp;
            this.btnCancelar.Location = new System.Drawing.Point(769, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 42);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::Sinapxon.Properties.Resources.round_edit_white_18dp;
            this.btnModificar.Location = new System.Drawing.Point(587, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 44);
            this.btnModificar.TabIndex = 69;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelRequisitos
            // 
            this.panelRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelRequisitos.Controls.Add(this.btnQuitarRequisito);
            this.panelRequisitos.Controls.Add(this.panelTituloRequisitos);
            this.panelRequisitos.Controls.Add(this.dgvRequisitos);
            this.panelRequisitos.Controls.Add(this.btnAgregarRequisito);
            this.panelRequisitos.Location = new System.Drawing.Point(480, 147);
            this.panelRequisitos.Name = "panelRequisitos";
            this.panelRequisitos.Size = new System.Drawing.Size(450, 514);
            this.panelRequisitos.TabIndex = 85;
            // 
            // btnQuitarRequisito
            // 
            this.btnQuitarRequisito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnQuitarRequisito.FlatAppearance.BorderSize = 0;
            this.btnQuitarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRequisito.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRequisito.Image = global::Sinapxon.Properties.Resources.baseline_remove_circle_white_18dp;
            this.btnQuitarRequisito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarRequisito.Location = new System.Drawing.Point(230, 68);
            this.btnQuitarRequisito.Name = "btnQuitarRequisito";
            this.btnQuitarRequisito.Size = new System.Drawing.Size(200, 45);
            this.btnQuitarRequisito.TabIndex = 12;
            this.btnQuitarRequisito.Text = "Quitar";
            this.btnQuitarRequisito.UseVisualStyleBackColor = false;
            this.btnQuitarRequisito.Click += new System.EventHandler(this.btnQuitarRequisito_Click);
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
            this.lblRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitos.ForeColor = System.Drawing.Color.White;
            this.lblRequisitos.Location = new System.Drawing.Point(15, 19);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(123, 25);
            this.lblRequisitos.TabIndex = 1;
            this.lblRequisitos.Text = "Requisitos";
            // 
            // dgvRequisitos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequisitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Descripción});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequisitos.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvRequisitos.Location = new System.Drawing.Point(20, 123);
            this.dgvRequisitos.Name = "dgvRequisitos";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequisitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvRequisitos.Size = new System.Drawing.Size(410, 372);
            this.dgvRequisitos.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 270;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // btnAgregarRequisito
            // 
            this.btnAgregarRequisito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAgregarRequisito.FlatAppearance.BorderSize = 0;
            this.btnAgregarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRequisito.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRequisito.Image = global::Sinapxon.Properties.Resources.baseline_add_circle_white_18dp;
            this.btnAgregarRequisito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRequisito.Location = new System.Drawing.Point(20, 68);
            this.btnAgregarRequisito.Name = "btnAgregarRequisito";
            this.btnAgregarRequisito.Size = new System.Drawing.Size(200, 45);
            this.btnAgregarRequisito.TabIndex = 11;
            this.btnAgregarRequisito.Text = "Agregar";
            this.btnAgregarRequisito.UseVisualStyleBackColor = false;
            this.btnAgregarRequisito.Click += new System.EventHandler(this.btnAgregarRequisito_Click);
            // 
            // panelDatosCurso
            // 
            this.panelDatosCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panelDatosCurso.Controls.Add(this.btnAgregarEsp);
            this.panelDatosCurso.Controls.Add(this.cbEspecialidad);
            this.panelDatosCurso.Controls.Add(this.panelTituloCurso);
            this.panelDatosCurso.Controls.Add(this.lblNombreCurso);
            this.panelDatosCurso.Controls.Add(this.txtDescripcion);
            this.panelDatosCurso.Controls.Add(this.txtNombreCurso);
            this.panelDatosCurso.Controls.Add(this.btnCodigoCurso);
            this.panelDatosCurso.Controls.Add(this.lblDescripcion);
            this.panelDatosCurso.Controls.Add(this.txtCodigoCurso);
            this.panelDatosCurso.Controls.Add(this.lblEspecialidad);
            this.panelDatosCurso.Location = new System.Drawing.Point(34, 147);
            this.panelDatosCurso.Name = "panelDatosCurso";
            this.panelDatosCurso.Size = new System.Drawing.Size(428, 514);
            this.panelDatosCurso.TabIndex = 84;
            // 
            // btnAgregarEsp
            // 
            this.btnAgregarEsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAgregarEsp.FlatAppearance.BorderSize = 0;
            this.btnAgregarEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEsp.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEsp.Location = new System.Drawing.Point(299, 211);
            this.btnAgregarEsp.Name = "btnAgregarEsp";
            this.btnAgregarEsp.Size = new System.Drawing.Size(108, 37);
            this.btnAgregarEsp.TabIndex = 13;
            this.btnAgregarEsp.Text = "Gestionar";
            this.btnAgregarEsp.UseVisualStyleBackColor = false;
            this.btnAgregarEsp.Click += new System.EventHandler(this.btnAgregarEsp_Click);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(20, 216);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(273, 28);
            this.cbEspecialidad.TabIndex = 10;
            // 
            // panelTituloCurso
            // 
            this.panelTituloCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.panelTituloCurso.Controls.Add(this.lblDatosCurso);
            this.panelTituloCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloCurso.Location = new System.Drawing.Point(0, 0);
            this.panelTituloCurso.Name = "panelTituloCurso";
            this.panelTituloCurso.Size = new System.Drawing.Size(428, 58);
            this.panelTituloCurso.TabIndex = 0;
            // 
            // lblDatosCurso
            // 
            this.lblDatosCurso.AutoSize = true;
            this.lblDatosCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCurso.ForeColor = System.Drawing.Color.White;
            this.lblDatosCurso.Location = new System.Drawing.Point(20, 19);
            this.lblDatosCurso.Name = "lblDatosCurso";
            this.lblDatosCurso.Size = new System.Drawing.Size(177, 25);
            this.lblDatosCurso.TabIndex = 0;
            this.lblDatosCurso.Text = "Datos del curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(17, 131);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(133, 20);
            this.lblNombreCurso.TabIndex = 2;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(21, 283);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(386, 212);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.Color.White;
            this.txtNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCurso.Location = new System.Drawing.Point(20, 153);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(387, 26);
            this.txtNombreCurso.TabIndex = 8;
            // 
            // btnCodigoCurso
            // 
            this.btnCodigoCurso.AutoSize = true;
            this.btnCodigoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigoCurso.Location = new System.Drawing.Point(16, 72);
            this.btnCodigoCurso.Name = "btnCodigoCurso";
            this.btnCodigoCurso.Size = new System.Drawing.Size(127, 20);
            this.btnCodigoCurso.TabIndex = 1;
            this.btnCodigoCurso.Text = "Codigo del curso";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(21, 260);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(160, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción del curso";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.BackColor = System.Drawing.Color.White;
            this.txtCodigoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCurso.Location = new System.Drawing.Point(20, 94);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(387, 26);
            this.txtCodigoCurso.TabIndex = 7;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(17, 193);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(99, 20);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(102, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(82, 29);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Curso";
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelRequisitos);
            this.Controls.Add(this.panelDatosCurso);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurso";
            this.Text = "frmAgregarCurso";
            this.panel5.ResumeLayout(false);
            this.panelRequisitos.ResumeLayout(false);
            this.panelTituloRequisitos.ResumeLayout(false);
            this.panelTituloRequisitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            this.panelDatosCurso.ResumeLayout(false);
            this.panelDatosCurso.PerformLayout();
            this.panelTituloCurso.ResumeLayout(false);
            this.panelTituloCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelRequisitos;
        private System.Windows.Forms.Button btnQuitarRequisito;
        private System.Windows.Forms.Panel panelTituloRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.Button btnAgregarRequisito;
        private System.Windows.Forms.Panel panelDatosCurso;
        private System.Windows.Forms.Button btnAgregarEsp;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Panel panelTituloCurso;
        private System.Windows.Forms.Label lblDatosCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label btnCodigoCurso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTitulo;
    }
}