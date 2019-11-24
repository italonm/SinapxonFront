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
        BindingList<Administrador.especialidad> backup;
        BindingList<Administrador.especialidad> toShow;

        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public frmAgregarEspecialidad()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            backup = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvEspecialidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.especialidad especialidadFila = (Administrador.especialidad)dgvEspecialidades.Rows[e.RowIndex].DataBoundItem;
            if (especialidadFila != null)
            {
                dgvEspecialidades.Rows[e.RowIndex].Cells[0].Value = especialidadFila.nombre;
                dgvEspecialidades.Rows[e.RowIndex].Cells[1].Value = especialidadFila.descripcion;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toShow = new BindingList<Administrador.especialidad>();

            foreach (Administrador.especialidad esp in backup)
            {
                String nombreAux = txtNombre.Text.ToUpper();
                String desAux = txtDescripcion.Text.ToUpper();

                String nombRev = esp.nombre.ToUpper();
                String desRev = esp.descripcion.ToUpper();

                if (nombRev.Contains(nombreAux) && desRev.Contains(desAux))
                {
                    toShow.Add(esp);
                }
            }

            if (txtNombre.Text == "" & txtDescripcion.Text == "")
            {                
                dgvEspecialidades.DataSource = backup;
            }
            else
            {
                dgvEspecialidades.DataSource = toShow;
                if (toShow.Count() == 0)
                {
                    if (txtNombre.Text != "" && txtDescripcion.Text == "")
                    {
                        MessageBox.Show("No se encontraron resultados con el nombre ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text == "" && txtDescripcion.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados con el decripción ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text != "" && txtDescripcion.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            espSeleccionado = dgvEspecialidades.CurrentRow.DataBoundItem as Administrador.especialidad;
            this.DialogResult = DialogResult.OK;
            frmRegistrarEspecialidad formRegEspecialidad = new frmRegistrarEspecialidad(espSeleccionado);
            this.Close();
            formRegEspecialidad.Visible = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmRegistrarEspecialidad formRegEspecialidad = new frmRegistrarEspecialidad();
            this.Close();
            formRegEspecialidad.Visible = true;
        }
    }
}
