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
        private Administrador.profesor pfSeleccionado;


        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public profesor PfSeleccionado { get => pfSeleccionado; set => pfSeleccionado = value; }

        public frmGestionarProfesor()
        {
            InitializeComponent();
            dgvProfesores.AutoGenerateColumns = false;
            dgvProfesores.DataSource = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));
        }


        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.profesor profesorFila = (Administrador.profesor)dgvProfesores.Rows[e.RowIndex].DataBoundItem;
            if (profesorFila != null)
            {
                dgvProfesores.Rows[e.RowIndex].Cells[0].Value = profesorFila.codigo.ToString();
                dgvProfesores.Rows[e.RowIndex].Cells[1].Value = profesorFila.nombre;
                dgvProfesores.Rows[e.RowIndex].Cells[2].Value = profesorFila.apellidoPaterno;
                dgvProfesores.Rows[e.RowIndex].Cells[3].Value = profesorFila.apellidoMaterno;
                dgvProfesores.Rows[e.RowIndex].Cells[4].Value = profesorFila.dni;
                dgvProfesores.Rows[e.RowIndex].Cells[5].Value = profesorFila.telefono.ToString();
                dgvProfesores.Rows[e.RowIndex].Cells[6].Value = profesorFila.correo;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = DBController.listarProfesores(txtNombre.Text);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            pfSeleccionado = dgvProfesores.CurrentRow.DataBoundItem as Administrador.profesor;
            this.DialogResult = DialogResult.OK;
        }
    }
}
