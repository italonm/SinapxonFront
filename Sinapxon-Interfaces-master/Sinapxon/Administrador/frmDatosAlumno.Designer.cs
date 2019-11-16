namespace Sinapxon.Administrador
{
    partial class frmDatosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAlumno));
            this.lblDatosDelAlumno = new System.Windows.Forms.Label();
            this.panelDatosGenerales = new System.Windows.Forms.Panel();
            this.panelTituloDatosGenerales = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.dtFechNac = new System.Windows.Forms.DateTimePicker();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbBloqueado = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGenerarContr = new System.Windows.Forms.Button();
            this.lblId_Alumno = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.panelDatosGenerales.SuspendLayout();
            this.panelTituloDatosGenerales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosDelAlumno
            // 
            this.lblDatosDelAlumno.AutoSize = true;
            this.lblDatosDelAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelAlumno.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDatosDelAlumno.Location = new System.Drawing.Point(12, 9);
            this.lblDatosDelAlumno.Name = "lblDatosDelAlumno";
            this.lblDatosDelAlumno.Size = new System.Drawing.Size(216, 29);
            this.lblDatosDelAlumno.TabIndex = 68;
            this.lblDatosDelAlumno.Text = "Datos del alumno";
            // 
            // panelDatosGenerales
            // 
            this.panelDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDatosGenerales.Controls.Add(this.lblId_Alumno);
            this.panelDatosGenerales.Controls.Add(this.txtIdAlumno);
            this.panelDatosGenerales.Controls.Add(this.panelTituloDatosGenerales);
            this.panelDatosGenerales.Controls.Add(this.lblNombre);
            this.panelDatosGenerales.Controls.Add(this.txtNombre);
            this.panelDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.panelDatosGenerales.Controls.Add(this.txtApPat);
            this.panelDatosGenerales.Controls.Add(this.lblApellidoMaterno);
            this.panelDatosGenerales.Controls.Add(this.txtApMat);
            this.panelDatosGenerales.Controls.Add(this.lblDni);
            this.panelDatosGenerales.Controls.Add(this.txtDNI);
            this.panelDatosGenerales.Controls.Add(this.lblFechaNacimiento);
            this.panelDatosGenerales.Controls.Add(this.txtTelf);
            this.panelDatosGenerales.Controls.Add(this.dtFechNac);
            this.panelDatosGenerales.Controls.Add(this.cboPais);
            this.panelDatosGenerales.Controls.Add(this.label2);
            this.panelDatosGenerales.Controls.Add(this.label3);
            this.panelDatosGenerales.Location = new System.Drawing.Point(17, 104);
            this.panelDatosGenerales.Name = "panelDatosGenerales";
            this.panelDatosGenerales.Size = new System.Drawing.Size(468, 378);
            this.panelDatosGenerales.TabIndex = 69;
            // 
            // panelTituloDatosGenerales
            // 
            this.panelTituloDatosGenerales.BackColor = System.Drawing.Color.SlateBlue;
            this.panelTituloDatosGenerales.Controls.Add(this.label1);
            this.panelTituloDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDatosGenerales.Name = "panelTituloDatosGenerales";
            this.panelTituloDatosGenerales.Size = new System.Drawing.Size(468, 45);
            this.panelTituloDatosGenerales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos generales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(16, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 26);
            this.txtNombre.TabIndex = 40;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 173);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(124, 20);
            this.lblApellidoPaterno.TabIndex = 31;
            this.lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // txtApPat
            // 
            this.txtApPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApPat.Location = new System.Drawing.Point(16, 195);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(225, 26);
            this.txtApPat.TabIndex = 41;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(254, 172);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(128, 20);
            this.lblApellidoMaterno.TabIndex = 32;
            this.lblApellidoMaterno.Text = "Apellido materno";
            // 
            // txtApMat
            // 
            this.txtApMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApMat.Location = new System.Drawing.Point(258, 195);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(191, 26);
            this.txtApMat.TabIndex = 42;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(254, 105);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 20);
            this.lblDni.TabIndex = 34;
            this.lblDni.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(258, 128);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(191, 26);
            this.txtDNI.TabIndex = 44;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 242);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(157, 20);
            this.lblFechaNacimiento.TabIndex = 33;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txtTelf
            // 
            this.txtTelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelf.Location = new System.Drawing.Point(16, 339);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(251, 26);
            this.txtTelf.TabIndex = 47;
            // 
            // dtFechNac
            // 
            this.dtFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechNac.Location = new System.Drawing.Point(16, 264);
            this.dtFechNac.Name = "dtFechNac";
            this.dtFechNac.Size = new System.Drawing.Size(433, 26);
            this.dtFechNac.TabIndex = 43;
            // 
            // cboPais
            // 
            this.cboPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(292, 339);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(157, 28);
            this.cboPais.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Teléfono";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnGenerarContr);
            this.panel1.Controls.Add(this.txtNickname);
            this.panel1.Controls.Add(this.lblNickname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(491, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 266);
            this.panel1.TabIndex = 70;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(13, 141);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(420, 26);
            this.txtNickname.TabIndex = 55;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(10, 118);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(75, 18);
            this.lblNickname.TabIndex = 54;
            this.lblNickname.Text = "Nickname";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 45);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datos de la cuenta";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(9, 51);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 20);
            this.lblCorreo.TabIndex = 36;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(13, 74);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(420, 26);
            this.txtCorreo.TabIndex = 45;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(9, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(13, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(310, 26);
            this.txtPassword.TabIndex = 52;
            // 
            // gbEstado
            // 
            this.gbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbEstado.Controls.Add(this.rbBloqueado);
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.gbEstado.Location = new System.Drawing.Point(491, 376);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(449, 160);
            this.gbEstado.TabIndex = 71;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbBloqueado
            // 
            this.rbBloqueado.AutoSize = true;
            this.rbBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBloqueado.ForeColor = System.Drawing.Color.Black;
            this.rbBloqueado.Location = new System.Drawing.Point(35, 117);
            this.rbBloqueado.Name = "rbBloqueado";
            this.rbBloqueado.Size = new System.Drawing.Size(104, 24);
            this.rbBloqueado.TabIndex = 2;
            this.rbBloqueado.TabStop = true;
            this.rbBloqueado.Text = "Bloqueado";
            this.rbBloqueado.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(35, 73);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(82, 24);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.Location = new System.Drawing.Point(35, 36);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(70, 24);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnModificar);
            this.panel5.Location = new System.Drawing.Point(17, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(923, 48);
            this.panel5.TabIndex = 76;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SlateBlue;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(0, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 42);
            this.btnNuevo.TabIndex = 71;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(142, 3);
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
            this.btnEliminar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(302, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 42);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(464, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 42);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(799, 3);
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
            this.btnModificar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(627, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 44);
            this.btnModificar.TabIndex = 69;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGenerarContr
            // 
            this.btnGenerarContr.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGenerarContr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarContr.FlatAppearance.BorderSize = 0;
            this.btnGenerarContr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarContr.ForeColor = System.Drawing.Color.White;
            this.btnGenerarContr.Location = new System.Drawing.Point(338, 206);
            this.btnGenerarContr.Name = "btnGenerarContr";
            this.btnGenerarContr.Size = new System.Drawing.Size(95, 30);
            this.btnGenerarContr.TabIndex = 75;
            this.btnGenerarContr.Text = "Generar";
            this.btnGenerarContr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarContr.UseVisualStyleBackColor = false;
            // 
            // lblId_Alumno
            // 
            this.lblId_Alumno.AutoSize = true;
            this.lblId_Alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Alumno.Location = new System.Drawing.Point(14, 51);
            this.lblId_Alumno.Name = "lblId_Alumno";
            this.lblId_Alumno.Size = new System.Drawing.Size(117, 20);
            this.lblId_Alumno.TabIndex = 51;
            this.lblId_Alumno.Text = "Codigo Alumno";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAlumno.Location = new System.Drawing.Point(16, 76);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(191, 26);
            this.txtIdAlumno.TabIndex = 50;
            // 
            // frmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(956, 546);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatosGenerales);
            this.Controls.Add(this.lblDatosDelAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDatosAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alumno";
            this.panelDatosGenerales.ResumeLayout(false);
            this.panelDatosGenerales.PerformLayout();
            this.panelTituloDatosGenerales.ResumeLayout(false);
            this.panelTituloDatosGenerales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatosDelAlumno;
        private System.Windows.Forms.Panel panelDatosGenerales;
        private System.Windows.Forms.Panel panelTituloDatosGenerales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.DateTimePicker dtFechNac;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbBloqueado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGenerarContr;
        internal System.Windows.Forms.Label lblId_Alumno;
        private System.Windows.Forms.TextBox txtIdAlumno;
    }
}