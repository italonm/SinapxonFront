using Sinapxon.Login;
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
        BindingList<Administrador.curso> backup;
        private Administrador.curso curSeleccionado;
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();
        private String codigoAdmin;

        public frmGestionarCursos()
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursos(""));
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.codigoAdmin = LoginInfo.persona.codigo;
        }

        public frmGestionarCursos(frmAdministrador padre)
        {
            InitializeComponent();
            this.codigoAdmin = LoginInfo.persona.codigo;
            this.Padre = padre;
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursos(""));

            backup = (BindingList<Administrador.curso>)dgvCursos.DataSource;

            BindingList<Administrador.curso> toShow = new BindingList<Administrador.curso>();

            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (cursoFila != null)
            {
                dgvCursos.Rows[e.RowIndex].Cells["Codigo"].Value = cursoFila.codigo;
                dgvCursos.Rows[e.RowIndex].Cells["Nombre"].Value = cursoFila.nombre;
                dgvCursos.Rows[e.RowIndex].Cells["Descripcion"].Value = cursoFila.descripcion;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvCursos.DataSource = DBController.listarCursos(txtNombre.Text);
            BindingList<Administrador.curso> toShow = new BindingList<Administrador.curso>();
            foreach (Administrador.curso cur in backup)
            {
                String chi = cur.codigo + " " + cur.nombre + " " + cur.descripcion;
                if (chi.Contains(txtNombre.Text))
                {
                    toShow.Add(cur);
                }
            }
            if (txtNombre.Text != " ") dgvCursos.DataSource = toShow;
            else dgvCursos.DataSource = backup;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCursos.FirstDisplayedScrollingRowIndex = dgvCursos.RowCount - 1;
            frmCurso formCurso = new frmCurso("Añadir", this.codigoAdmin, _padre);
            Padre.openChildForm(formCurso);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            curSeleccionado = dgvCursos.CurrentRow.DataBoundItem as Administrador.curso;
            frmCurso formCurso = new frmCurso("Editar", curSeleccionado, _padre);
            _padre.openChildForm(formCurso);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
