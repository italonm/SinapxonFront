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
            classrooms = new BindingList<Profesor.classroom>(DBController.listarClassroomxProfesor(LoginInfo.persona.codigo,""));
            foreach (Profesor.classroom obj in classrooms){
                crearClassroom(obj.curso.codigo, obj.curso.nombre, obj.codigo);
            }
        }

        public frmGestionarMisClassrooms(frmProfesor padre)
        {
            _padre = padre;
            InitializeComponent();
            classrooms = new BindingList<Profesor.classroom>(DBController.listarClassroomxProfesor(LoginInfo.persona.codigo,""));
            foreach (Profesor.classroom obj in classrooms){
                crearClassroom(obj.curso.codigo, obj.curso.nombre, obj.codigo);
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
            // btnVerClassroom
            // 
            Button btnVerClassroom = new Button();
            btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnVerClassroom.FlatAppearance.BorderSize = 0;
            btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerClassroom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerClassroom.Image = global::Sinapxon.Properties.Resources.baseline_edit_black_18dp;
            btnVerClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVerClassroom.Location = new System.Drawing.Point(96, 109 + altura);
            btnVerClassroom.Name = "btnVerClassroom";
            btnVerClassroom.Size = new System.Drawing.Size(189, 44);
            btnVerClassroom.Text = "  Ver classroom";
            btnVerClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnVerClassroom.UseVisualStyleBackColor = false;
            //btnVerClassroom.Click += new System.EventHandler(this.btnVerClassroom_Click);
            btnVerClassroom.Click += new System.EventHandler((sender, e) => this.btnVerClassroom_Click(sender,e,codClassroom));
            panelContenedor.Controls.Add(btnVerClassroom);
            // 
            // btnVerAlumnos
            // 
            Button btnVerAlumnos = new Button();
            btnVerAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnVerAlumnos.FlatAppearance.BorderSize = 0;
            btnVerAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerAlumnos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerAlumnos.Image = global::Sinapxon.Properties.Resources.round_search;
            btnVerAlumnos.ImageAlign = System.Drawing.ContentAlignment. MiddleLeft;
            btnVerAlumnos.Location = new System.Drawing.Point(316, 109 + altura);
            btnVerAlumnos.Name = "btnVerAlumnos";
            btnVerAlumnos.Size = new System.Drawing.Size(189, 44);
            btnVerAlumnos.Text = "Ver Alumnos";
            btnVerAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnVerAlumnos.UseVisualStyleBackColor = false;
            //btnAniadirEvaluacion.Click += new System.EventHandler(this.btnAniadirEvaluacion_Click);
            btnVerAlumnos.Click += new System.EventHandler((sender, e) => btnVerAlumnos_Click(sender, e, codClassroom,nombre));
            panelContenedor.Controls.Add(btnVerAlumnos);
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
            btnAniadirTema.Location = new System.Drawing.Point(536, 109 + altura);
            btnAniadirTema.Name = "btnAniadirTema";
            btnAniadirTema.Size = new System.Drawing.Size(189, 44);
            btnAniadirTema.TabIndex = 6;
            btnAniadirTema.Text = "ESTA DEMAS ESTE BOTON";
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
            pbBlueBox.Size = new System.Drawing.Size(800, 164);
            pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBlueBox.TabStop = false;
            panelContenedor.Controls.Add(pbBlueBox);

            altura = altura + boxAltura;
        }

        private void btnVerClassroom_Click(object sender, EventArgs e, string codClassroom)
        {
            ClassroomInfo.classroom.codigo = codClassroom;
            frmVerClassroom formVerClassroom = new frmVerClassroom();
            _padre.openChildForm(formVerClassroom);
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e,string codclassroom,string nombre)
        {
            ClassroomInfo.classroom.codigo = codclassroom;
            ClassroomInfo.classroom.curso = new Profesor.curso();
            ClassroomInfo.classroom.curso.nombre = nombre;
            frmVerAlumnos frmVerAlumnos = new frmVerAlumnos();
            _padre.openChildForm(frmVerAlumnos);
            frmVerAlumnos.Visible = true;
        }

        private void btnAniadirTema_Click(object sender, EventArgs e, string codclassroom)
        {
            ClassroomInfo.classroom.codigo = codclassroom;
            frmTema formAniadirTema = new frmTema();
            formAniadirTema.Visible = true;
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

        
    }

    public static class ClassroomInfo
    {
        public static Profesor.classroom classroom = new Profesor.classroom();
    }
}
