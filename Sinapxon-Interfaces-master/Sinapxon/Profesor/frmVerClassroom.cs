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
    public partial class frmVerClassroom : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        BindingList<Profesor.temaXClassroom> temas;
        private frmProfesor _padre;
        public frmVerClassroom(frmProfesor padre)
        {
            InitializeComponent();
            _padre = padre;
            dgvTemas.AutoGenerateColumns = false;
            temas = new BindingList<temaXClassroom>(DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo));
            dgvTemas.DataSource = temas;
        }

        private void btnAniadirTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            _padre.openChildForm(formTema);
        }

        private void btnAniadirEvaluacion_Click(object sender, EventArgs e)
        {
            frmEvaluacion formAniadirEvaluacion = new frmEvaluacion();
            formAniadirEvaluacion.Visible = true;
        }

        private void btnEditarTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            formTema.Visible = true;
        }

        private void btnCalificarEvaluacion_Click(object sender, EventArgs e)
        {
            frmCalificar formCalificar = new frmCalificar();
            formCalificar.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTemas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Profesor.temaXClassroom tema = (Profesor.temaXClassroom)dgvTemas.Rows[e.RowIndex].DataBoundItem;
            if (tema != null)
            {
                dgvTemas.Rows[e.RowIndex].Cells["Nombre"].Value = tema.nombre;
                dgvTemas.Rows[e.RowIndex].Cells["Descripcion"].Value = tema.descripcion;
                dgvTemas.Rows[e.RowIndex].Cells["Video"].Value = tema.link;
            }
        }
    }
}
