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
        BindingList<Administrador.alumno> backup;


        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        
        public alumno AlSeleccionado { get => alSeleccionado; set => alSeleccionado = value; }

        public frmGestionarAlumno()
        {
            InitializeComponent();
            
            dgvAlumno.AutoGenerateColumns = false;
            dgvAlumno.DataSource = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public frmGestionarAlumno(frmAdministrador padre)
        {
            InitializeComponent();
            
            this.Padre = padre;
            dgvAlumno.AutoGenerateColumns = false;
            dgvAlumno.DataSource = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));

            backup = (BindingList<Administrador.alumno>)dgvAlumno.DataSource;
            
            BindingList<Administrador.alumno> toShow = new BindingList<Administrador.alumno> ();
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }




        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.alumno alumnoFila = (Administrador.alumno)dgvAlumno.Rows[e.RowIndex].DataBoundItem;
            if (alumnoFila != null)
            {
                dgvAlumno.Rows[e.RowIndex].Cells[0].Value = alumnoFila.codigo.ToString();
                dgvAlumno.Rows[e.RowIndex].Cells[1].Value = alumnoFila.nombre;
                dgvAlumno.Rows[e.RowIndex].Cells[2].Value = alumnoFila.apellidoPaterno;
                dgvAlumno.Rows[e.RowIndex].Cells[3].Value = alumnoFila.apellidoMaterno;
                dgvAlumno.Rows[e.RowIndex].Cells[4].Value = alumnoFila.dni;
                dgvAlumno.Rows[e.RowIndex].Cells[5].Value = alumnoFila.telefono.ToString();
                dgvAlumno.Rows[e.RowIndex].Cells[6].Value = alumnoFila.correo;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvAlumno.DataSource = DBController.listarAlumnos(txtNombre.Text);
            BindingList<Administrador.alumno> toShow = new BindingList<Administrador.alumno>();
            foreach (Administrador.alumno al in backup)
            {
                String chi = al.nombre + " " + al.apellidoPaterno + " " + al.apellidoMaterno+ " " + al.codigo + " " + al.dni; ;
                if (chi.Contains(txtNombre.Text))
                {
                    toShow.Add(al);
                }
            }
            if (txtNombre.Text != " ") dgvAlumno.DataSource = toShow;
            else dgvAlumno.DataSource = backup;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvAlumno.FirstDisplayedScrollingRowIndex = dgvAlumno.RowCount - 1;
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno(_padre);
            _padre.openChildForm(formDatosAlumno);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            alSeleccionado = dgvAlumno.CurrentRow.DataBoundItem as Administrador.alumno;
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno(alSeleccionado, _padre);
            _padre.openChildForm(formDatosAlumno);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
