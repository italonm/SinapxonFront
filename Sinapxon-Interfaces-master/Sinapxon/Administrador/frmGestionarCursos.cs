using Sinapxon.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        BindingList<Administrador.curso> toShow;
        private Administrador.curso curSeleccionado;
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();
        int busq = 0;
        private int index = 0;
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        //INICIANDO FORMULARIO
        public frmGestionarCursos(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            //Inicializao dgvCursos:con todos los cursos
            dgvCursos.AutoGenerateColumns = false;

            index += 1;
            backup = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
            for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
            {
                bdl.Add(backup[n_]);
            }
            dgvCursos.DataSource = bdl;
            BindingList<Administrador.curso> toShow = new BindingList<Administrador.curso>();
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Doy espacio al curso seleccionado
            curSeleccionado = new Administrador.curso();
        }

        //===========================================================================================================================================
        //DGV
        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (cursoFila != null )
            {
                dgvCursos.Rows[e.RowIndex].Cells["Codigo"].Value = cursoFila.codigo;
                dgvCursos.Rows[e.RowIndex].Cells["Nombre"].Value = cursoFila.nombre;
                dgvCursos.Rows[e.RowIndex].Cells["Descripcion"].Value = cursoFila.descripcion;
            }
        }
        //=============================================================================================================================================
        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toShow = new BindingList<Administrador.curso>();
            index = 0;

            //Hago búsqueda por código y nombre del curso
            foreach (Administrador.curso cur in backup)
            {
                String chi = cur.codigo + " " + cur.nombre;
                String nombreAux = txtNombre.Text.ToUpper();
                String codigoAux = txtCodigo.Text.ToUpper();

                String nombRev= cur.nombre.ToUpper();
                String codRev = cur.codigo.ToUpper();

                if (nombRev.Contains(nombreAux) && codRev.Contains(codigoAux))
                {
                    toShow.Add(cur);
                }
            }

            if (txtNombre.Text == "" & txtCodigo.Text == "")
            {
                busq = 0;
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
                {
                    bdl.Add(backup[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
            else
            {
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                busq = 1;
                for (int n_ = (index - 1) * 20; (n_< toShow.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(toShow[n_]);
                }
                dgvCursos.DataSource = bdl;

                if (toShow.Count() == 0) {
                    if (txtNombre.Text != "" && txtCodigo.Text == "")
                    {
                        MessageBox.Show("No se encontraron resultados con el nombre ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text == "" && txtCodigo.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text != "" && txtCodigo.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }       
            
        }

        //=============================================================================================================================================
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCursos.FirstDisplayedScrollingRowIndex = dgvCursos.RowCount - 1;
            frmCurso formCurso = new frmCurso( _padre);
            Padre.openChildForm(formCurso);
        }

        //=============================================================================================================================================
        //SELECCIONAR
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            curSeleccionado = dgvCursos.CurrentRow.DataBoundItem as Administrador.curso;
            frmCurso formCurso = new frmCurso(curSeleccionado, _padre);
            Padre.openChildForm(formCurso);
        }

        //=============================================================================================================================================
        //REGRESAR
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //=============================================================================================================================================
        //ANTERIOR
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.curso> aux= new BindingList<Administrador.curso>();
            backup = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index > 1)
            {
                index -= 1;             
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; (n_>=0)  && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
        }

        //=============================================================================================================================================
        //SIGUIENTE
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.curso> aux = new BindingList<Administrador.curso>();
            backup = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index*20 <= aux.Count()-1)
            {
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; (n_ <aux.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
        }
    }
}
