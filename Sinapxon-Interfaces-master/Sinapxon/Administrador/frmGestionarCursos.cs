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
    public partial class frmGestionarCursos : Form
    {
        private frmAdministrador _padre = null;

        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();
        public frmGestionarCursos()
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.codigoAdmin = LoginInfo.persona.codigo;
        }

        public frmGestionarCursos(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void btnAniadirCurso_Click(object sender, EventArgs e)
        {
            //Padre.openChildForm(new frmCurso("Añadir"));
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            //Padre.openChildForm(new frmCurso("Editar"));
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if(cursoFila != null)
            {
                dgvCursos.Rows[e.RowIndex].Cells["Codigo"].Value = cursoFila.codigo;
                dgvCursos.Rows[e.RowIndex].Cells["Nombre"].Value = cursoFila.nombre;
                dgvCursos.Rows[e.RowIndex].Cells["Descripcion"].Value = cursoFila.descripcion;
            }
        }
    }
}
