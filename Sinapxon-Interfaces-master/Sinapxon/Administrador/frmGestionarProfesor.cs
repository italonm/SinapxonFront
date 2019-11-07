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
    public partial class frmGestionarProfesor : Form
    {
        private frmAdministrador _padre = null;

        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();

        public frmGestionarProfesor()
        {
            InitializeComponent();
        }

        public frmGestionarProfesor(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            dgvProfesores.AutoGenerateColumns = false;
            dgvProfesores.DataSource = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmDatosProfesor formDatosProfesor = new frmDatosProfesor();
            formDatosProfesor.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosProfesor formDatosProfesor = new frmDatosProfesor();
            formDatosProfesor.Visible = true;
        }

        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.profesor profesorFila = (Administrador.profesor)dgvProfesores.Rows[e.RowIndex].DataBoundItem;
            if (profesorFila != null)
            {
                dgvProfesores.Rows[e.RowIndex].Cells[0].Value = profesorFila.codigo.ToString();
                dgvProfesores.Rows[e.RowIndex].Cells[1].Value = profesorFila.nombre;
                dgvProfesores.Rows[e.RowIndex].Cells[2].Value = profesorFila.apellidoPaterno;
                dgvProfesores.Rows[e.RowIndex].Cells[3].Value = profesorFila.telefono.ToString();
                dgvProfesores.Rows[e.RowIndex].Cells[4].Value = profesorFila.correo;
            }
        }
    }
}
