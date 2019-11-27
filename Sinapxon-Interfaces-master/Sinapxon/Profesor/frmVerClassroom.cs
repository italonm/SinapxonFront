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
        BindingList<Profesor.evaluacion> evaluaciones;
        private frmProfesor _profesor;

        public frmVerClassroom(frmProfesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            dgvTemas.AutoGenerateColumns = false;
            if (DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo) != null)
            {
                temas = new BindingList<temaXClassroom>(DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo));
                dgvTemas.DataSource = temas;
            }

            dgvEvaluaciones.AutoGenerateColumns = false;
            if (DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo) != null)
            {
                evaluaciones = new BindingList<evaluacion>(DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo));
                dgvEvaluaciones.DataSource = evaluaciones;
            }
        }

        private void btnAniadirTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema(_profesor);
            _profesor.openChildForm(formTema);
        }      

        private void btnAniadirEvaluacion_Click(object sender, EventArgs e)
        {
            frmEvaluacion formAniadirEvaluacion = new frmEvaluacion();
            formAniadirEvaluacion.Visible = true;
        }
        private void btnEditarEvaluacion_Click(object sender, EventArgs e)
        {
            frmCalificar frmCalificar = new frmCalificar(_profesor);
            _profesor.openChildForm(frmCalificar);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmGestionarMisClassrooms frmGestionarMisClassrooms = new frmGestionarMisClassrooms(_profesor);
            _profesor.openChildForm(frmGestionarMisClassrooms);
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

        private void dgvEvaluaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Profesor.evaluacion evaluacion = (Profesor.evaluacion)dgvEvaluaciones.Rows[e.RowIndex].DataBoundItem;
            if (evaluacion != null)
            {
                dgvEvaluaciones.Rows[e.RowIndex].Cells["Namee"].Value = evaluacion.nombre;
                dgvEvaluaciones.Rows[e.RowIndex].Cells["Peso"].Value = evaluacion.peso_porcentual.ToString();
                dgvEvaluaciones.Rows[e.RowIndex].Cells["Description"].Value = evaluacion.descripcion;

            }
        }

        private void btnQuitarTema_Click(object sender, EventArgs e)
        {
            int codTema = ((Profesor.temaXClassroom)dgvTemas.CurrentRow.DataBoundItem).id_tema;
            DBController.eliminarTemaxClassroom(codTema,ClassroomInfo.classroom.codigo);
            if (DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo) != null)
            {
                temas = new BindingList<temaXClassroom>(DBController.listarTemaxClassroom(ClassroomInfo.classroom.codigo));
                dgvTemas.DataSource = temas;
            }
            else {
                dgvTemas.DataSource = null;
            }
            //dgvTemas.Rows.Remove(dgvTemas.CurrentRow);
            if (DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo) != null)
            {
                evaluaciones = new BindingList<evaluacion>(DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo));
                dgvEvaluaciones.DataSource = evaluaciones;
            }
            else {
                dgvEvaluaciones.DataSource = null;
            }
        }

        private void btnQuitarEvaluacion_Click(object sender, EventArgs e)
        {
            int codigo = ((Profesor.evaluacion)dgvEvaluaciones.CurrentRow.DataBoundItem).id_evaluacion;

            DBController.eliminarEvaluacionxClassroom(codigo);
            if (DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo) != null)
            {
                evaluaciones = new BindingList<evaluacion>(DBController.listarEvaluacionesXClassroom(ClassroomInfo.classroom.codigo));
                dgvEvaluaciones.DataSource = evaluaciones;
            }
            else
            {
                dgvEvaluaciones.DataSource = null;
            }
            //dgvEvaluaciones.Rows.Remove(dgvEvaluaciones.CurrentRow);
        }
    }
}
