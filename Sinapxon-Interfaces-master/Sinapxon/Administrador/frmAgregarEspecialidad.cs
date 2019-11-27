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
        private frmAdministrador _padre = null;
        BindingList<Administrador.especialidad> backup;
        BindingList<Administrador.especialidad> toShow;
        private Administrador.especialidad espSeleccionado;
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();
        int busq = 0;
        private int index = 0;
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        public frmAgregarEspecialidad(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;

            //Inicializao dgvAlumnos:con todos los alumnos
            dgvEspecialidades.AutoGenerateColumns = false;
            index += 1;
            backup = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            BindingList<Administrador.especialidad> bdl = new BindingList<Administrador.especialidad>();
            for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
            {
                bdl.Add(backup[n_]);
            }
            dgvEspecialidades.DataSource = bdl;
            BindingList<Administrador.especialidad> toShow = new BindingList<Administrador.especialidad>();
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Doy espacio al alumno seleccionado
            espSeleccionado = new Administrador.especialidad();
        }


        //===========================================================================================================================================
        //DGV
        private void dgvEspecialidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                Administrador.especialidad especialidadFila = (Administrador.especialidad)dgvEspecialidades.Rows[e.RowIndex].DataBoundItem;
                if (especialidadFila != null)
                {
                    dgvEspecialidades.Rows[e.RowIndex].Cells[0].Value = especialidadFila.nombre;
                    dgvEspecialidades.Rows[e.RowIndex].Cells[1].Value = especialidadFila.descripcion;
                }
            }
            catch
            {

            }
        }

        //=============================================================================================================================================
        //BUSCAR
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
                busq = 0;
                index += 1;
                BindingList<Administrador.especialidad> bdl = new BindingList<Administrador.especialidad>();
                for (int n_ = (index - 1) * 20; n_ < backup.Count() && n_ < index * 20; n_++)
                {
                    bdl.Add(backup[n_]);
                }
                dgvEspecialidades.DataSource = bdl;
            }
            else
            {
                if (toShow.Count() == 0)
                {
                    MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                index += 1;
                BindingList<Administrador.especialidad> bdl = new BindingList<Administrador.especialidad>();
                busq = 1;
                for (int n_ = (index - 1) * 20; (n_ < toShow.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(toShow[n_]);
                }
                dgvEspecialidades.DataSource = bdl;
            }

        }

        //=============================================================================================================================================
        //SELECCIONAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                espSeleccionado = dgvEspecialidades.CurrentRow.DataBoundItem as Administrador.especialidad;
                frmRegistrarEspecialidad formRegspecialidad = new frmRegistrarEspecialidad(espSeleccionado, _padre);
                _padre.openChildForm(formRegspecialidad);
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //=============================================================================================================================================
        //AGREGAR
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvEspecialidades.FirstDisplayedScrollingRowIndex = dgvEspecialidades.RowCount - 1;
                frmRegistrarEspecialidad formRegspecialidad = new frmRegistrarEspecialidad(_padre);
                _padre.openChildForm(formRegspecialidad);
            }
            catch
            {
                frmRegistrarEspecialidad formRegspecialidad = new frmRegistrarEspecialidad(_padre);
                _padre.openChildForm(formRegspecialidad);
            }
        }

        //=============================================================================================================================================
        //SIGUIENTE
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.especialidad> aux = new BindingList<Administrador.especialidad>();
            backup = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index * 20 <= aux.Count() - 1)
            {
                index += 1;
                BindingList<Administrador.especialidad> bdl = new BindingList<Administrador.especialidad>();
                for (int n_ = (index - 1) * 20; (n_ < aux.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvEspecialidades.DataSource = bdl;
            }
        }

        //=============================================================================================================================================
        //ANTERIOR
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.especialidad> aux = new BindingList<Administrador.especialidad>();
            backup = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index > 1)
            {
                index -= 1;
                BindingList<Administrador.especialidad> bdl = new BindingList<Administrador.especialidad>();
                for (int n_ = (index - 1) * 20; (n_ >= 0) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvEspecialidades.DataSource = bdl;
            }
        }
    }
}
