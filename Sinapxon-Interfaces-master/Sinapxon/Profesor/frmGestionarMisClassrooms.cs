using Sinapxon.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Profesor
{
    public partial class frmGestionarMisClassrooms : Form
    {
        private frmProfesor _padre;
        private int altura = 0, boxAltura = 164;

        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();

        private BindingList<Profesor.classroom> classrooms;

        public frmGestionarMisClassrooms()
        {
            InitializeComponent();
            
            classrooms = 
                new BindingList<Profesor.classroom>(DBController.listarClassroomxProfesor(LoginInfo.persona.codigo,""));

            foreach (Profesor.classroom obj in classrooms)
            {
                crearClassroom(obj.curso.codigo, obj.curso.nombre, obj.codigo);
            }
            
        }

        public frmGestionarMisClassrooms(frmProfesor padre)
        {
            _padre = padre;
            InitializeComponent();

            classrooms =
                new BindingList<Profesor.classroom>(DBController.listarClassroomxProfesor(LoginInfo.persona.codigo,""));

            foreach (Profesor.classroom obj in classrooms)
            {
                crearClassroom(obj.curso.codigo, obj.curso.nombre,obj.codigo);
            }
            
        }

        private void crearClassroom(string codCurso, string nombre, string codClassroom)
        {
            // 
            // lblCodigoCurso
            // 
            Label lblCodigoCurso = new Label();
            lblCodigoCurso.AutoSize = true;
            lblCodigoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCodigoCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigoCurso.ForeColor = System.Drawing.Color.White;
            lblCodigoCurso.Location = new System.Drawing.Point(180, 54 + altura);
            lblCodigoCurso.Name = "lblCodigoCurso";
            lblCodigoCurso.Size = new System.Drawing.Size(89, 25);
            lblCodigoCurso.Text = codCurso;
            lblCodigoCurso.BringToFront();
            panelContenedor.Controls.Add(lblCodigoCurso);
            // 
            // lblNombreCurso
            // 
            Label lblNombreCurso = new Label();
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreCurso.ForeColor = System.Drawing.Color.White;
            lblNombreCurso.Location = new System.Drawing.Point(265, 54 + altura);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new System.Drawing.Size(181, 25);
            lblNombreCurso.Text = nombre;
            lblNombreCurso.BringToFront();
            panelContenedor.Controls.Add(lblNombreCurso);
            // 
            // lblCodigoClassroom
            // 
            Label lblCodigoClassroom = new Label();
            lblCodigoClassroom.AutoSize = true;
            lblCodigoClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCodigoClassroom.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigoClassroom.ForeColor = System.Drawing.Color.White;
            lblCodigoClassroom.Location = new System.Drawing.Point(70, 54 + altura);
            lblCodigoClassroom.Name = "lblCodigoClassroom";
            lblCodigoClassroom.Size = new System.Drawing.Size(90, 25);
            lblCodigoClassroom.Text = codClassroom;
            lblCodigoClassroom.BringToFront();
            panelContenedor.Controls.Add(lblCodigoClassroom);
            // 
            // btnEditarClassroom
            // 
            Button btnEditarClassroom = new Button();
            btnEditarClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnEditarClassroom.FlatAppearance.BorderSize = 0;
            btnEditarClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditarClassroom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEditarClassroom.Image = global::Sinapxon.Properties.Resources.baseline_edit_black_18dp;
            btnEditarClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEditarClassroom.Location = new System.Drawing.Point(536, 109 + altura);
            btnEditarClassroom.Name = "btnVerClassroom";
            btnEditarClassroom.Size = new System.Drawing.Size(189, 44);
            btnEditarClassroom.Text = "  Ver classroom";
            btnEditarClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnEditarClassroom.UseVisualStyleBackColor = false;
            btnEditarClassroom.Click += new System.EventHandler(this.button1_Click);
            panelContenedor.Controls.Add(btnEditarClassroom);
            // 
            // btnAniadirEvaluacion
            // 
            Button btnAniadirEvaluacion = new Button();
            btnAniadirEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAniadirEvaluacion.FlatAppearance.BorderSize = 0;
            btnAniadirEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAniadirEvaluacion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAniadirEvaluacion.Image = global::Sinapxon.Properties.Resources.baseline_add_box_black_18dp;
            btnAniadirEvaluacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAniadirEvaluacion.Location = new System.Drawing.Point(96, 109 + altura);
            btnAniadirEvaluacion.Name = "btnAniadirEvaluacion";
            btnAniadirEvaluacion.Size = new System.Drawing.Size(189, 44);
            btnAniadirEvaluacion.Text = "Añadir evaluación";
            btnAniadirEvaluacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAniadirEvaluacion.UseVisualStyleBackColor = false;
            //btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            btnAniadirEvaluacion.Click += new System.EventHandler((sender, e) => btnAniadirEvaluacion_Click(sender, e, codClassroom));
            panelContenedor.Controls.Add(btnAniadirEvaluacion);
            // 
            // btnAniadirTema
            // 
            Button btnAniadirTema = new Button();
            btnAniadirTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAniadirTema.FlatAppearance.BorderSize = 0;
            btnAniadirTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAniadirTema.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAniadirTema.Image = global::Sinapxon.Properties.Resources.baseline_add_box_black_18dp;
            btnAniadirTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAniadirTema.Location = new System.Drawing.Point(316, 109 + altura);
            btnAniadirTema.Name = codClassroom;
            btnAniadirTema.Size = new System.Drawing.Size(189, 44);
            btnAniadirTema.TabIndex = 6;
            btnAniadirTema.Text = "  Añadir Tema";
            btnAniadirTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnAniadirTema.UseVisualStyleBackColor = false;
            //btnAniadirTema.Click += new System.EventHandler(this.btnAniadirTema_Click);
            btnAniadirTema.Click += new System.EventHandler((sender, e) => btnAniadirTema_Click(sender, e, codClassroom));
            panelContenedor.Controls.Add(btnAniadirTema);
            // 
            // pbBlueBox
            // 
            PictureBox pbBlueBox = new PictureBox();
            pbBlueBox.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBlueBox.Location = new System.Drawing.Point(11, 15+altura);
            pbBlueBox.Name = "pbBlueBox";
            pbBlueBox.Size = new System.Drawing.Size(852, 164);
            pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBlueBox.TabStop = false;
            panelContenedor.Controls.Add(pbBlueBox);

            altura = altura + boxAltura;
        }

        private void BtnEditarClassroom_Click(object sender, EventArgs e)
        {

        }

        private void BtnAniadirClassroom_Click(object sender, EventArgs e)
        {
            frmDatosClassroom formDatosClassroom = new frmDatosClassroom();
            _padre.openChildForm(formDatosClassroom);
            //formAniadirClassroom.Visible = true;
        }

        private void btnAniadirTema_Click(object sender, EventArgs e,string codclassroom)
        {
            ClassroomInfo.classroom.codigo = codclassroom;
            frmTema formAniadirTema = new frmTema();
            formAniadirTema.Visible = true;
        }

        private void btnAniadirEvaluacion_Click(object sender, EventArgs e,string codclassroom)
        {
            ClassroomInfo.classroom.codigo = codclassroom;
            frmEvaluacion formAniadirEvaluacion = new frmEvaluacion();
            formAniadirEvaluacion.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            altura = 0;
            boxAltura = 164;
            panelContenedor.Controls.Clear();

            classrooms = new BindingList<Profesor.classroom>(DBController.listarClassroomxProfesor(LoginInfo.persona.codigo,txtBuscar.Text));

            foreach (Profesor.classroom obj in classrooms)
            {
                crearClassroom(obj.curso.codigo, obj.curso.nombre, obj.codigo);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerClassroom formVerClassroom = new frmVerClassroom();
            _padre.openChildForm(formVerClassroom);
        }
    }

    public static class ClassroomInfo
    {
        public static Profesor.classroom classroom= new Profesor.classroom();
    }
}
