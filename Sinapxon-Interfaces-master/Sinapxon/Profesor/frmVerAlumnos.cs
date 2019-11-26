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
    public partial class frmVerAlumnos : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        private BindingList<Profesor.alumno> alumnos;
        private frmProfesor _profesor;
        int altura = 0;
        public frmVerAlumnos(frmProfesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            alumnos = new BindingList<Profesor.alumno>(DBController.listarAlumnoXClassroom(ClassroomInfo.classroom.codigo));
            foreach (Profesor.alumno a in alumnos) {

                crearCurso(a);
            }
        }
        public void crearCurso(alumno a) {
            // 
            // lblNombreAlumno
            // 
            Label lblNombreAlumno = new Label();
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreAlumno.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreAlumno.ForeColor = System.Drawing.Color.White;
            lblNombreAlumno.Location = new System.Drawing.Point(50, 54 + altura);
            lblNombreAlumno.Name = "lblNombreCurso";
            lblNombreAlumno.Size = new System.Drawing.Size(181, 25);
            lblNombreAlumno.Text = a.codigo + " " + a.apellidoPaterno + " " + a.apellidoMaterno + " " + a.nombre;
            lblNombreAlumno.BringToFront();
            panelContenedor.Controls.Add(lblNombreAlumno);
            // 
            // lblCorreoAlumno
            // 
            Label lblCorreoAlumno = new Label();
            lblCorreoAlumno.AutoSize = true;
            lblCorreoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCorreoAlumno.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCorreoAlumno.ForeColor = System.Drawing.Color.White;
            lblCorreoAlumno.Location = new System.Drawing.Point(50, 90 + altura);
            lblCorreoAlumno.Name = "lblNombreCurso";
            lblCorreoAlumno.Size = new System.Drawing.Size(181, 25);
            lblCorreoAlumno.Text =  a.correo;
            lblCorreoAlumno.BringToFront();
            panelContenedor.Controls.Add(lblCorreoAlumno);
            // 
            // btnVerAlumnos
            // 
            Button btnVerNotas = new Button();
            btnVerNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            //btnVerNotas.Anchor= ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            btnVerNotas.FlatAppearance.BorderSize = 0;
            btnVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerNotas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerNotas.Image = global::Sinapxon.Properties.Resources.round_search;
            btnVerNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVerNotas.Location = new System.Drawing.Point(550, 67 + altura);
            btnVerNotas.Name = "btnVerAlumnos";
            btnVerNotas.Size = new System.Drawing.Size(189, 44);
            btnVerNotas.Text = " Ver Notas";
            btnVerNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnVerNotas.UseVisualStyleBackColor = false;
            btnVerNotas.Click += new System.EventHandler((sender, e) => btnVerNotas_Click(sender, e, a.codigo));
            panelContenedor.Controls.Add(btnVerNotas);
            // 
            // pbBlueBox
            // 
            PictureBox pbBlueBox = new PictureBox();
            pbBlueBox.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBlueBox.Location = new System.Drawing.Point(11, 15 + altura);
            pbBlueBox.Name = "pbBlueBox";
            pbBlueBox.Size = new System.Drawing.Size(800, 140);
            pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBlueBox.TabStop = false;
            panelContenedor.Controls.Add(pbBlueBox);

            altura = altura + 164;
            //this.label1.Text = "Alumnos del classroom: "+ClassroomInfo.classroom.codigo+" - "+ClassroomInfo.classroom.curso.nombre;
        }
        private void btnVerNotas_Click(object sender, EventArgs e, string codAlumno)
        {
            AlumnoInfo.alumnno.codigo = codAlumno;
            frmVerNotas frmVerNotas = new frmVerNotas();
            frmVerNotas.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmGestionarMisClassrooms frmGestionarMisClassrooms = new frmGestionarMisClassrooms(_profesor);
            _profesor.openChildForm(frmGestionarMisClassrooms);
        }
    }
    public static class AlumnoInfo
    {
        public static Profesor.alumno alumnno = new Profesor.alumno();
    }
}
