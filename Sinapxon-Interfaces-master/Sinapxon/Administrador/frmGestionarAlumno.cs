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
    public partial class frmGestionarAlumno : Form
    {
        private frmAdministrador _padre = null;
        private Administrador.alumno alSeleccionado;


        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public alumno AlSeleccionado { get => alSeleccionado; set => alSeleccionado = value; }

        public frmGestionarAlumno()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));
        }

        public frmGestionarAlumno(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }



        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.alumno alumnoFila = (Administrador.alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            if (alumnoFila != null)
            {
                dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = alumnoFila.codigo.ToString();
                dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = alumnoFila.nombre;
                dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = alumnoFila.apellidoPaterno;
                dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = alumnoFila.apellidoMaterno;
                dgvAlumnos.Rows[e.RowIndex].Cells[4].Value = alumnoFila.dni;
                dgvAlumnos.Rows[e.RowIndex].Cells[5].Value = alumnoFila.telefono.ToString();
                dgvAlumnos.Rows[e.RowIndex].Cells[6].Value = alumnoFila.correo;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = DBController.listarAlumnos(txtNombre.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno(_padre);
            _padre.openChildForm(formDatosAlumno);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            alSeleccionado = dgvAlumnos.CurrentRow.DataBoundItem as Administrador.alumno;
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno(alSeleccionado, _padre);
            _padre.openChildForm(formDatosAlumno);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
