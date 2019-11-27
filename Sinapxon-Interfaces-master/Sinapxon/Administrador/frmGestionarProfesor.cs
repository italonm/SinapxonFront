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
        BindingList<Administrador.profesor> backup;
        BindingList<Administrador.profesor> toShow;
        private Administrador.profesor pfSeleccionado;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        int busq = 0;
        private int index = 0;
        public frmAdministrador Padre { get => _padre; set => _padre = value; }


        public frmGestionarProfesor(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;

            //Inicializao dgvProfesores:con todos los profesores
            dgvProfesores.AutoGenerateColumns = false;
            index += 1;
            backup = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));
            BindingList<Administrador.profesor> bdl = new BindingList<Administrador.profesor>();
            for (int n_ = (index - 1) * 20; n_<backup.Count() && n_ < index * 20; n_++)
            {
                bdl.Add(backup[n_]);
            }
            dgvProfesores.DataSource = bdl;
            BindingList<Administrador.profesor> toShow = new BindingList<Administrador.profesor>();
            dgvProfesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Doy espacio al profesor seleccionado
            pfSeleccionado = new Administrador.profesor();

            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            rbBloqueado.Checked = false;
            rbTodos.Checked = true;
        }


        //===========================================================================================================================================
        //DGV
        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                Administrador.profesor profFila = (Administrador.profesor)dgvProfesores.Rows[e.RowIndex].DataBoundItem;
                if (profFila != null)
                {
                    dgvProfesores.Rows[e.RowIndex].Cells[0].Value = profFila.codigo;
                    dgvProfesores.Rows[e.RowIndex].Cells[1].Value = profFila.nombre;
                    dgvProfesores.Rows[e.RowIndex].Cells[2].Value = profFila.apellidoPaterno;
                    dgvProfesores.Rows[e.RowIndex].Cells[3].Value = profFila.apellidoMaterno;
                    dgvProfesores.Rows[e.RowIndex].Cells[4].Value = profFila.dni;
                    dgvProfesores.Rows[e.RowIndex].Cells[5].Value = profFila.telefono;
                    dgvProfesores.Rows[e.RowIndex].Cells[6].Value = profFila.correo;
                }
            }
            catch
            {

            }
        }

        //=============================================================================================================================================
        //BUSCAR
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            toShow = new BindingList<Administrador.profesor>();

            index = 0;

            int eaux = 3;
            if (rbActivo.Checked == true)
            {
                eaux = 1;
            }
            else if (rbInactivo.Checked == true)
            {
                eaux = 0;
            }
            else if (rbBloqueado.Checked == true)
            {
                eaux = 2;
            }


            String nombreAux = txtNombre.Text.ToUpper();
            String codigoAux = txtCodigo.Text;
            String apPatAux = txtApPat.Text.ToUpper();
            String apMatAux = txtApMat.Text.ToUpper();
            if (eaux != 3)
            {
                foreach (Administrador.profesor pf in backup)
                {
                    String nombRev = pf.nombre.ToUpper();
                    String codRev = pf.codigo;
                    String apPatRev = pf.apellidoPaterno.ToUpper();
                    String apMatRev = pf.apellidoMaterno.ToUpper();

                    if (pf.estado == eaux && nombRev.Contains(nombreAux) && codRev.Contains(codigoAux) && apPatRev.Contains(apPatAux) && apMatRev.Contains(apMatAux))
                    {
                        toShow.Add(pf);
                    }
                }
            }
            else
            {
                foreach (Administrador.profesor pf in backup)
                {
                    String nombRev = pf.nombre.ToUpper();
                    String codRev = pf.codigo;
                    String apPatRev = pf.apellidoPaterno.ToUpper();
                    String apMatRev = pf.apellidoMaterno.ToUpper();

                    if (nombRev.Contains(nombreAux) && codRev.Contains(codigoAux) && apPatRev.Contains(apPatAux) && apMatRev.Contains(apMatAux))
                    {
                        toShow.Add(pf);
                    }
                }
            }

            if (eaux == 3 && txtNombre.Text == "" && txtCodigo.Text == "" && txtApPat.Text == "" && txtApMat.Text == "")
            {
                busq = 0;
                index += 1;
                BindingList<Administrador.profesor> bdl = new BindingList<Administrador.profesor>();
                for (int n_ = (index - 1) * 20; n_<backup.Count() && n_ < index * 20; n_++)
                {
                    bdl.Add(backup[n_]);
                }
                dgvProfesores.DataSource = bdl;
            }
            else
            {
                if (toShow.Count() == 0)
                {

                    MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                index += 1;
                BindingList<Administrador.profesor> bdl = new BindingList<Administrador.profesor>();
                busq = 1;
                for (int n_ = (index - 1) * 20; (n_ < toShow.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(toShow[n_]);
                }
                dgvProfesores.DataSource = bdl; 
            }
        }

        //=============================================================================================================================================
        //SELECCIONAR
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                pfSeleccionado = dgvProfesores.CurrentRow.DataBoundItem as Administrador.profesor;
                frmDatosProfesor formDatosProfesor = new frmDatosProfesor(pfSeleccionado, _padre);
                _padre.openChildForm(formDatosProfesor);
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //=============================================================================================================================================
        //REGRESAR
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=============================================================================================================================================
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProfesores.FirstDisplayedScrollingRowIndex = dgvProfesores.RowCount - 1;
                frmDatosProfesor formDatosProfesor = new frmDatosProfesor(_padre);
                _padre.openChildForm(formDatosProfesor);
            }
            catch
            {
                frmDatosProfesor formDatosProfesor = new frmDatosProfesor(_padre);
                _padre.openChildForm(formDatosProfesor);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.profesor> aux = new BindingList<Administrador.profesor>();
            backup = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index > 1)
            {
                index -= 1;
                BindingList<Administrador.profesor> bdl = new BindingList<Administrador.profesor>();
                for (int n_ = (index - 1) * 20; (n_ >= 0) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvProfesores.DataSource = bdl;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.profesor> aux = new BindingList<Administrador.profesor>();
            backup = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index * 20 <= aux.Count() - 1)
            {
                index += 1;
                BindingList<Administrador.profesor> bdl = new BindingList<Administrador.profesor>();
                for (int n_ = (index - 1) * 20; (n_ < aux.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvProfesores.DataSource = bdl;
            }
        }
    }
}
