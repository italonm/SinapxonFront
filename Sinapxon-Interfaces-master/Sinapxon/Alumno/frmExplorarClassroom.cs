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
    public partial class frmExplorarClassroom : Form
    {
        public frmExplorarClassroom()
        {
            InitializeComponent();
            lblCurso.Text = ALUMNO_CursoInfo.cursoInfo.codigo + " - " + ALUMNO_CursoInfo.cursoInfo.nombre;
            txtDescripcion.Text = Explorar_classroomInfo.classroom.curso.descripcion;
            lblNombreProfesor.Text = Explorar_classroomInfo.classroom.profesor.nombre;
            lblApellidosProfesor.Text = Explorar_classroomInfo.classroom.profesor.apellidoPaterno + " " + Explorar_classroomInfo.classroom.profesor.apellidoMaterno;
            lblAreaInteresProfesor.Text = Explorar_classroomInfo.classroom.profesor.areaInteres;
            lblGradoInstruccionProfesor.Text = Explorar_classroomInfo.classroom.profesor.gradoInstruccion;
            lblPeriodoClassroom.Text = Explorar_classroomInfo.classroom.periodo.nombre;
            lblIdiomaClassroom.Text = Explorar_classroomInfo.classroom.idioma.nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmConfirmarIngresoClassroom formConfirmarIngresoClassroom = new frmConfirmarIngresoClassroom();
            if(formConfirmarIngresoClassroom.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            //formConfirmarIngresoClassroom.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
