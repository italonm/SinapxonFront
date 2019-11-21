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
    public partial class frmAgregarRequisito : Form
    {
        private Administrador.curso curSeleccionado;


        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public curso CurSeleccionado { get => curSeleccionado; set => curSeleccionado = value; }

        public frmAgregarRequisito()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (cursoFila != null)
            {
                dgvCursos.Rows[e.RowIndex].Cells[0].Value = cursoFila.codigo.ToString();
                dgvCursos.Rows[e.RowIndex].Cells[1].Value = cursoFila.nombre;
                dgvCursos.Rows[e.RowIndex].Cells[2].Value = cursoFila.descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            curSeleccionado = dgvCursos.CurrentRow.DataBoundItem as Administrador.curso;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = DBController.listarCursos(txtBuscar.Text);
        }
    }
}
