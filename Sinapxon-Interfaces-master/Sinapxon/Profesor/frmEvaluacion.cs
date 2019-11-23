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
    public partial class frmEvaluacion : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        BindingList<Profesor.temaXClassroom> temaXClassrooms;
        public frmEvaluacion()
        {
            InitializeComponent();
            temaXClassrooms = new BindingList<temaXClassroom>(DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo));
            cbTemas.DataSource = temaXClassrooms;
            cbTemas.DisplayMember = "Nombre";
            cbTemas.ValueMember = "id_tema";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Profesor.evaluacion evaluacion = new Profesor.evaluacion();
            evaluacion.nombre = txtNombreEvaluacion.Text;
            int codTema = ((Profesor.temaXClassroom)cbTemas.SelectedItem).id_tema;
            evaluacion.peso_porcentual = float.Parse(txtPeso.Text);
            evaluacion.descripcion = txtDescripcion.Text;
            evaluacion.tema = new Profesor.temaXClassroom();
            DBController.insertarEvaluacion(evaluacion, ClassroomInfo.classroom.codigo, codTema);
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
