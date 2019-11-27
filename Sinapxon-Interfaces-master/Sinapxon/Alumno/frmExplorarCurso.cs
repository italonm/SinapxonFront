using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Alumno
{
    public partial class frmExplorarCurso : Form
    {
        private Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();

        private int altura = 0, boxAltura = 113;
        private int reqAltura = 0, distancia = 80;

        private BindingList<Alumno.classroom> classrooms;

        public frmExplorarCurso()
        {
            InitializeComponent();
            lblNombreCurso.Text = ALUMNO_CursoInfo.cursoInfo.codigo + " - " + ALUMNO_CursoInfo.cursoInfo.nombre;
            int numRequisitos = 0;
            try
            {
                numRequisitos = ALUMNO_CursoInfo.cursoInfo.cursos.Length;
            }
            catch (Exception) {numRequisitos = 0; }
            for (int i = 0; i < numRequisitos; i++)
            {
                generarListaRequisitos(ALUMNO_CursoInfo.cursoInfo.cursos[i]);
            }

            try
            {
                classrooms = new BindingList<Alumno.classroom>(DBController.listarClassroomsxCurso(ALUMNO_CursoInfo.cursoInfo));
            }
            catch (Exception)
            {
                classrooms = new BindingList<Alumno.classroom>();
            }

            foreach(Alumno.classroom classroom in classrooms)
            {
                generarBloqueClassroom(classroom);
            }

            //generarBloqueClassroom();
            //generarBloqueClassroom();
        }


        private void generarListaRequisitos(Alumno.curso cursoRequisito)
        {
            // 
            // lblRequisito
            // 
            Label lblRequisito = new Label();
            lblRequisito.AutoSize = false;
            lblRequisito.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRequisito.Location = new System.Drawing.Point(50, 82 + reqAltura);
            lblRequisito.Name = "lblRequisito";
            lblRequisito.Size = new System.Drawing.Size(320, 80);
            lblRequisito.TabIndex = 1;
            lblRequisito.Text = "●  "+cursoRequisito.nombre;

            panelRequisitos.Controls.Add(lblRequisito);

            reqAltura = reqAltura + distancia;
        }

        private void generarBloqueClassroom(Alumno.classroom classroomIn)
        {
            // 
            // lblNombreProfesor
            // 
            Label lblNombreProfesor = new Label();
            lblNombreProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreProfesor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            lblNombreProfesor.Location = new System.Drawing.Point(62, 83+altura);
            lblNombreProfesor.Name = "lblNombreProfesor";
            lblNombreProfesor.Size = new System.Drawing.Size(187, 23);
            lblNombreProfesor.Text = classroomIn.profesor.nombre + " " + classroomIn.profesor.apellidoPaterno;
            panelClassrooms.Controls.Add(lblNombreProfesor);

            // 
            // pbUsuarios
            // 
            PictureBox pbUsuarios = new PictureBox();
            pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            pbUsuarios.Image = global::Sinapxon.Properties.Resources.baseline_group_white_18dp;
            pbUsuarios.Location = new System.Drawing.Point(66, 117+altura);
            pbUsuarios.Name = "pbUsuarios";
            pbUsuarios.Size = new System.Drawing.Size(36, 36);
            pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbUsuarios.TabStop = false;
            panelClassrooms.Controls.Add(pbUsuarios);

            // 
            // lblNumeroAlumnos
            // 
            Label lblNumeroAlumnos = new Label();
            lblNumeroAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNumeroAlumnos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumeroAlumnos.ForeColor = System.Drawing.Color.White;
            lblNumeroAlumnos.Location = new System.Drawing.Point(109, 126+altura);
            lblNumeroAlumnos.Name = "lblNumeroAlumnos";
            lblNumeroAlumnos.Size = new System.Drawing.Size(85, 19);
            lblNumeroAlumnos.Text = "0 Alumnos";
            panelClassrooms.Controls.Add(lblNumeroAlumnos);

            //
            // btnVerClassroom
            //
            Button btnVerClassroom = new Button();
            btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            btnVerClassroom.FlatAppearance.BorderSize = 0;
            btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerClassroom.Font = new System.Drawing.Font("Roboto", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerClassroom.ForeColor = System.Drawing.Color.White;
            btnVerClassroom.Location = new System.Drawing.Point(325, 96 + altura);
            btnVerClassroom.Name = "btnVisualizarClassroom";
            btnVerClassroom.Size = new System.Drawing.Size(162, 41);
            btnVerClassroom.Text = "Ver classroom";
            btnVerClassroom.UseVisualStyleBackColor = false;
            //btnVerClassroom.Click += new System.EventHandler(this.BtnVerClassroom_Click);
            btnVerClassroom.Click += new System.EventHandler((sender, e) => this.BtnVerClassroom_Click(sender, e, classroomIn));
            panelClassrooms.Controls.Add(btnVerClassroom);

            // 
            // pictureBox Bloque azul
            // 
            PictureBox pbBloque = new PictureBox();
            pbBloque.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBloque.Location = new System.Drawing.Point(22, 56+altura);
            pbBloque.Name = "pbBloque";
            pbBloque.Size = new System.Drawing.Size(500, 113);
            pbBloque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBloque.TabStop = false;
            panelClassrooms.Controls.Add(pbBloque);

            altura = altura + boxAltura;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVerClassroom_Click(object sender, EventArgs e, Alumno.classroom classroomIn)
        {
            Explorar_classroomInfo.classroom = classroomIn;
            frmExplorarClassroom formExplorarClassroom = new frmExplorarClassroom();
            if(formExplorarClassroom.ShowDialog() == DialogResult.OK)
            {
                //actualizar el contador de alumnos
            }
            //formExplorarClassroom.Visible = true;
        }
    }

    public static class Explorar_classroomInfo
    {
        public static Alumno.classroom classroom;
    }

}
