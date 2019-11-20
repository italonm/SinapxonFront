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
    public partial class frmAgregarEspecialidad : Form
    {
        private Administrador.especialidad espSeleccionado;


        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public especialidad EspSeleccionado { get => espSeleccionado; set => espSeleccionado = value; }
        private String codigoAdmin;

        public frmAgregarEspecialidad(String codigo)
        {
            InitializeComponent();
            this.codigoAdmin = codigo;
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
        }

        public frmAgregarEspecialidad()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
        }

        private void dgvEspecialidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.especialidad especialidadFila = (Administrador.especialidad)dgvEspecialidades.Rows[e.RowIndex].DataBoundItem;
            if (especialidadFila != null)
            {
                dgvEspecialidades.Rows[e.RowIndex].Cells[0].Value = especialidadFila.id_especialidad.ToString();
                dgvEspecialidades.Rows[e.RowIndex].Cells[1].Value = especialidadFila.nombre;
                dgvEspecialidades.Rows[e.RowIndex].Cells[2].Value = especialidadFila.descripcion;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = DBController.listarEspecialidades(txtBuscar.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            espSeleccionado = dgvEspecialidades.CurrentRow.DataBoundItem as Administrador.especialidad;
            this.DialogResult = DialogResult.OK;
            frmRegistrarEspecialidad formRegEspecialidad = new frmRegistrarEspecialidad(codigoAdmin, espSeleccionado);
            this.Close();
            formRegEspecialidad.Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmRegistrarEspecialidad formRegEspecialidad = new frmRegistrarEspecialidad(codigoAdmin);
            this.Close();
            formRegEspecialidad.Visible = true;
        }
    }
}
