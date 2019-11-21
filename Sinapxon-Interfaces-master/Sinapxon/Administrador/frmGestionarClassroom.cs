using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Administrador
{
    public partial class frmGestionarClassroom : Form
    {
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();

        private frmAdministrador _padre = null;
        private BindingList<Administrador.solicitudClassroom> solicitudClassroomsPendientes;
        private BindingList<Administrador.solicitudClassroom> solicitudClassroomsAprobados;
        private BindingList<Administrador.solicitudClassroom> solicitudClassroomsDesaprobados;

        private Administrador.solicitudClassroom solicitudSeleccionado;

        public frmGestionarClassroom()
        {
            InitializeComponent();
            dgvSolicitudesPendientes.AutoGenerateColumns = false;
            solicitudClassroomsPendientes = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(2));
            dgvSolicitudesPendientes.DataSource = solicitudClassroomsPendientes;

            dgvSolicitudesAprobadas.AutoGenerateColumns = false;
            solicitudClassroomsAprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(1));
            dgvSolicitudesAprobadas.DataSource = solicitudClassroomsAprobados;

            dgvSolicitudesDesaprobadas.AutoGenerateColumns = false;
            solicitudClassroomsDesaprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(0));
            dgvSolicitudesDesaprobadas.DataSource = solicitudClassroomsDesaprobados;
        }

        public frmGestionarClassroom(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            dgvSolicitudesPendientes.AutoGenerateColumns = false;
            solicitudClassroomsPendientes = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(2));
            dgvSolicitudesPendientes.DataSource = solicitudClassroomsPendientes;

            dgvSolicitudesAprobadas.AutoGenerateColumns = false;
            solicitudClassroomsAprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(1));
            dgvSolicitudesAprobadas.DataSource = solicitudClassroomsAprobados;

            dgvSolicitudesDesaprobadas.AutoGenerateColumns = false;
            try
            {
                solicitudClassroomsDesaprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(0));
            }
            catch (ArgumentNullException e)
            {
                solicitudClassroomsDesaprobados = new BindingList<Administrador.solicitudClassroom>();
            }
            dgvSolicitudesDesaprobadas.DataSource = solicitudClassroomsDesaprobados;
            //solicitudClassroomsDesaprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(0));
            //dgvSolicitudesDesaprobadas.DataSource = solicitudClassroomsDesaprobados;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            solicitudSeleccionado = dgvSolicitudesPendientes.CurrentRow.DataBoundItem as Administrador.solicitudClassroom;

            frmSolicitudClassroom formSolicitudClassroom = new frmSolicitudClassroom(solicitudSeleccionado);
            if(formSolicitudClassroom.ShowDialog() == DialogResult.OK)
            {
                solicitudClassroomsPendientes = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(2));
                solicitudClassroomsAprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(1));
                try
                {
                    solicitudClassroomsDesaprobados = new BindingList<Administrador.solicitudClassroom>(DBController.listarSolicitudes(0));
                }
                catch(ArgumentNullException)
                {

                }
                dgvSolicitudesPendientes.DataSource = solicitudClassroomsPendientes;
                dgvSolicitudesAprobadas.DataSource = solicitudClassroomsAprobados;
                dgvSolicitudesDesaprobadas.DataSource = solicitudClassroomsDesaprobados;
            }
        }

        private void dgvSolicitudesPendientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.solicitudClassroom solicitudFila = (Administrador.solicitudClassroom)dgvSolicitudesPendientes.Rows[e.RowIndex].DataBoundItem;
            if(solicitudFila!=null)
            {
                dgvSolicitudesPendientes.Rows[e.RowIndex].Cells[0].Value = solicitudFila.id_solicitud.ToString();
                dgvSolicitudesPendientes.Rows[e.RowIndex].Cells[1].Value = solicitudFila.curso.codigo;
                dgvSolicitudesPendientes.Rows[e.RowIndex].Cells[2].Value = solicitudFila.curso.nombre;
                dgvSolicitudesPendientes.Rows[e.RowIndex].Cells[3].Value = solicitudFila.profesor.nombre;
            }
        }

        private void dgvSolicitudesAprobadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.solicitudClassroom solicitudFila = (Administrador.solicitudClassroom)dgvSolicitudesAprobadas.Rows[e.RowIndex].DataBoundItem;
            if (solicitudFila != null)
            {
                dgvSolicitudesAprobadas.Rows[e.RowIndex].Cells[0].Value = solicitudFila.id_solicitud.ToString();
                dgvSolicitudesAprobadas.Rows[e.RowIndex].Cells[1].Value = solicitudFila.curso.codigo;
                dgvSolicitudesAprobadas.Rows[e.RowIndex].Cells[2].Value = solicitudFila.curso.nombre;
                dgvSolicitudesAprobadas.Rows[e.RowIndex].Cells[3].Value = solicitudFila.profesor.nombre;
            }
        }

        private void dgvSolicitudesDesaprobadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.solicitudClassroom solicitudFila = (Administrador.solicitudClassroom)dgvSolicitudesDesaprobadas.Rows[e.RowIndex].DataBoundItem;
            if (solicitudFila != null)
            {
                dgvSolicitudesDesaprobadas.Rows[e.RowIndex].Cells[0].Value = solicitudFila.id_solicitud.ToString();
                dgvSolicitudesDesaprobadas.Rows[e.RowIndex].Cells[1].Value = solicitudFila.curso.codigo;
                dgvSolicitudesDesaprobadas.Rows[e.RowIndex].Cells[2].Value = solicitudFila.curso.nombre;
                dgvSolicitudesDesaprobadas.Rows[e.RowIndex].Cells[3].Value = solicitudFila.profesor.nombre;
            }
        }
    }
}
