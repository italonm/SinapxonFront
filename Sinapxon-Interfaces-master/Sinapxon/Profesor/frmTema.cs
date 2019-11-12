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
    public partial class frmTema : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        public frmTema()
        {
            InitializeComponent();
            lblTema.Text = "Tema" + " - " + ClassroomInfo.classroom.codigo;
        }

        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTema_Click(object sender, EventArgs e)
        {
            Profesor.tema tema = new Profesor.tema();
            tema.nombre = txtNombre.Text;
            tema.link = txtLinkVideo.Text;
            tema.descripcion = txtDescripcion.Text;
            tema.classroom= new Profesor.classroom();
            tema.classroom.codigo= ClassroomInfo.classroom.codigo;
            tema.classroom.curso = new Profesor.curso();
            tema.classroom.profesor = new profesor();
            tema.classroom.idioma = new idioma();
            tema.classroom.temas = new Profesor.temaXClassroom[0];
            tema.classroom.alumnos = new Profesor.classroomXAlumno[0];
            tema.classroom.periodo = new Profesor.periodo();
            DBController.insertarTema(tema);
            this.Close();
        }
    }
}
