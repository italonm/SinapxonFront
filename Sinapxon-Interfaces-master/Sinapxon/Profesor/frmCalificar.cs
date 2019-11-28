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
    public partial class frmCalificar : Form
    {
        private frmProfesor _profesor;
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        BindingList<Profesor.entregable> entregables;
        public frmCalificar(frmProfesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            entregables= new BindingList<Profesor.entregable>(DBController.listarEntregables(EvaluacionInfo.evaluacion.id_evaluacion,ClassroomInfo.classroom.codigo));
            dgvEntregables.AutoGenerateColumns = false;
            dgvEntregables.DataSource = entregables;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmVerClassroom frmVerClassroom = new frmVerClassroom(_profesor);
            _profesor.openChildForm(frmVerClassroom);
        }

        private void btnAsignarPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void dgvEntregables_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Profesor.entregable entregable = (Profesor.entregable)dgvEntregables.Rows[e.RowIndex].DataBoundItem;
            if (entregable != null)
            {
                dgvEntregables.Rows[e.RowIndex].Cells["Nombre"].Value = entregable.alumno.alumno.codigo;
                dgvEntregables.Rows[e.RowIndex].Cells["Entregable"].Value = entregable.archivo.nombre;
            }
        }
    }
}
