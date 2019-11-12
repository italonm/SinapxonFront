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
    public partial class frmDatosClassroom : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();

        BindingList<Profesor.curso> cursos;
        BindingList<Profesor.periodo> periodos;
        BindingList<Profesor.idioma> idiomas;
        public frmDatosClassroom()
        {
            InitializeComponent();

            dgvCursos.AutoGenerateColumns = false;
            cursos = new BindingList<Profesor.curso>(DBController.listarCursos(""));
            dgvCursos.DataSource = cursos;

            periodos = new BindingList<Profesor.periodo>(DBController.listarPeriodos());

            cbPeriodos.DataSource = periodos;
            cbPeriodos.DisplayMember = "Nombre";
            cbPeriodos.ValueMember = "Id_periodo";

            idiomas = new BindingList<Profesor.idioma>(DBController.listarIdiomas());
            cbIdiomas.DataSource = idiomas;
            cbIdiomas.DisplayMember = "Nombre";
            cbIdiomas.ValueMember = "Id_idioma";
        }

        private void BtnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            Profesor.solicitudClassroom solicitud = new Profesor.solicitudClassroom();
            solicitud.curso = (Profesor.curso)dgvCursos.CurrentRow.DataBoundItem;
            Profesor.profesor profesor = new Profesor.profesor();
            profesor.codigo = Login.LoginInfo.persona.codigo;
            solicitud.profesor = profesor;
            solicitud.idioma = (Profesor.idioma)cbIdiomas.SelectedItem;
            Profesor.administrador admin = new Profesor.administrador();
            admin.codigo = "123456";
            solicitud.administrador = admin;
            solicitud.periodo = (Profesor.periodo)cbPeriodos.SelectedItem;
            solicitud.descripcion = txtDescripcion.Text;
            //frmConfirmacionEnvioSolicitudClassroom formConfirmacion = new frmConfirmacionEnvioSolicitudClassroom();
            //formConfirmacion.Visible = true;
            DBController.insertarSolicitudClassroom(solicitud);
        }
        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Profesor.curso cursoFila = (Profesor.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            dgvCursos.Rows[e.RowIndex].Cells["Codigo"].Value = cursoFila.codigo;
            dgvCursos.Rows[e.RowIndex].Cells["Nombre"].Value = cursoFila.nombre;
        }

        private void cbPeriodos_Format(object sender, ListControlConvertEventArgs e )
        {
            e.Value = ((Profesor.periodo)e.ListItem).nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            cursos = new BindingList<Profesor.curso>(DBController.listarCursos(lblCurso.Text));
            dgvCursos.DataSource = cursos;
        }
    }
}
