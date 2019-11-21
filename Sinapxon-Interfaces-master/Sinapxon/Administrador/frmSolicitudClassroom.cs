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
    public partial class frmSolicitudClassroom : Form
    {
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();

        private Administrador.solicitudClassroom _solicitudClassroom;

        public frmSolicitudClassroom()
        {
            InitializeComponent();
        }

        public frmSolicitudClassroom(Administrador.solicitudClassroom solicitud)
        {
            InitializeComponent();
            _solicitudClassroom = solicitud;
            lblTituloSolicitud.Text = "Datos de la solicitud" + " - " + _solicitudClassroom.id_solicitud.ToString();
            txtDescripcion.Text = _solicitudClassroom.descripcion;
            lblNombre.Text = _solicitudClassroom.profesor.nombre;
            lblGrado.Text = _solicitudClassroom.profesor.gradoInstruccion;
            lblInteres.Text = _solicitudClassroom.profesor.areaInteres;
            lblNombreCurso.Text = _solicitudClassroom.curso.codigo + " - " + _solicitudClassroom.curso.nombre;
            cbIdioma.Text = _solicitudClassroom.idioma.nombre;
            cbPeriodo.Text = _solicitudClassroom.periodo.nombre;
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            DBController.cambiarEstadoSolicitud(_solicitudClassroom.id_solicitud, 0);
            MessageBox.Show("Se cambio el estado de la solicitud correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            DBController.crearClassroom_y_asignarProfesor(_solicitudClassroom);
            MessageBox.Show("Se agrego el classroom correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
