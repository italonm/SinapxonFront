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
    public partial class frmGestionarAlumno : Form
    {
        private frmAdministrador _padre = null;
        BindingList<Administrador.alumno> backup;
        BindingList<Administrador.alumno> toShow;
        private Administrador.alumno alSeleccionado;
        private Administrador.AdministradorServicesClient DBController = new AdministradorServicesClient();
        int busq = 0;
        private int index = 0;
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        public frmGestionarAlumno(frmAdministrador padre)
        {
            InitializeComponent();           
            this.Padre = padre;

            //Inicializao dgvAlumnos:con todos los alumnos
            dgvAlumno.AutoGenerateColumns = false;
            index += 1;
            backup = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));      
            BindingList<Administrador.alumno> bdl = new BindingList<Administrador.alumno> ();
            for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
            {
                bdl.Add(backup[n_]);
            }
            dgvAlumno.DataSource = bdl;
            BindingList<Administrador.alumno> toShow = new BindingList<Administrador.alumno>();
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Doy espacio al alumno seleccionado
            alSeleccionado = new Administrador.alumno();

            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            rbBloqueado.Checked = false;
            rbTodos.Checked = true;
        }

        //===========================================================================================================================================
        //DGV
        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.alumno alumFila = (Administrador.alumno)dgvAlumno.Rows[e.RowIndex].DataBoundItem;
            if (alumFila != null)
            {
                dgvAlumno.Rows[e.RowIndex].Cells[0].Value = alumFila.codigo;
                dgvAlumno.Rows[e.RowIndex].Cells[1].Value = alumFila.nombre;
                dgvAlumno.Rows[e.RowIndex].Cells[2].Value = alumFila.apellidoPaterno;
                dgvAlumno.Rows[e.RowIndex].Cells[3].Value = alumFila.apellidoMaterno;
                dgvAlumno.Rows[e.RowIndex].Cells[4].Value = alumFila.dni;
                dgvAlumno.Rows[e.RowIndex].Cells[5].Value = alumFila.telefono;
                dgvAlumno.Rows[e.RowIndex].Cells[6].Value = alumFila.correo;
            }
        }

        //=============================================================================================================================================
        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toShow = new BindingList<Administrador.alumno>();
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
                foreach (Administrador.alumno al in backup)
                {
                    String nombRev = al.nombre.ToUpper();
                    String codRev = al.codigo;
                    String apPatRev = al.apellidoPaterno.ToUpper();
                    String apMatRev = al.apellidoMaterno.ToUpper();

                    if (al.estado == eaux && nombRev.Contains(nombreAux) && codRev.Contains(codigoAux) && apPatRev.Contains(apPatAux) && apMatRev.Contains(apMatAux))
                    {
                        toShow.Add(al);
                    }
                }
            }
            else
            {
                foreach (Administrador.alumno al in backup)
                {
                    String nombRev = al.nombre.ToUpper();
                    String codRev = al.codigo;
                    String apPatRev = al.apellidoPaterno.ToUpper();
                    String apMatRev = al.apellidoMaterno.ToUpper();

                    if (nombRev.Contains(nombreAux) && codRev.Contains(codigoAux) && apPatRev.Contains(apPatAux) && apMatRev.Contains(apMatAux))
                    {
                        toShow.Add(al);
                    }
                }
            }

            if (eaux==3 && txtNombre.Text == "" && txtCodigo.Text == "" && txtApPat.Text=="" && txtApMat.Text=="")
            {
                busq = 0;
                index += 1;
                BindingList<Administrador.alumno> bdl = new BindingList<Administrador.alumno>();
                for (int n_ = (index - 1) * 20; n_<backup.Count() && n_ < index * 20; n_++)
                {
                    bdl.Add(backup[n_]);
                }
                dgvAlumno.DataSource = bdl;
            }
            else
            {
                index += 1;
                BindingList<Administrador.alumno> bdl = new BindingList<Administrador.alumno>();
                busq = 1;
                for (int n_ = (index - 1) * 20; (n_ < toShow.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(toShow[n_]);
                }
                dgvAlumno.DataSource = bdl;

                if (toShow.Count() == 0)
                {
                
                    MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    
                }
            }
        }

        //=============================================================================================================================================
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAlumno.FirstDisplayedScrollingRowIndex = dgvAlumno.RowCount - 1;
                frmDatosAlumno formDatosAlumno = new frmDatosAlumno(_padre);
                _padre.openChildForm(formDatosAlumno);
            }
            catch
            {
                frmDatosAlumno formDatosAlumno = new frmDatosAlumno(_padre);
                _padre.openChildForm(formDatosAlumno);
            }
        }

        //=============================================================================================================================================
        //SELECCIONAR
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            alSeleccionado = dgvAlumno.CurrentRow.DataBoundItem as Administrador.alumno;
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno(alSeleccionado, _padre);
            _padre.openChildForm(formDatosAlumno);
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
            BindingList<Administrador.alumno> aux = new BindingList<Administrador.alumno>();
            backup = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index > 1)
            {
                index -= 1;
                BindingList<Administrador.alumno> bdl = new BindingList<Administrador.alumno>();
                for (int n_ = (index - 1) * 20; (n_ >= 0) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvAlumno.DataSource = bdl;
            }
        }

        //=============================================================================================================================================
        //SIGUIENTE
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.alumno> aux = new BindingList<Administrador.alumno>();
            backup = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index * 20 <= aux.Count() - 1)
            {
                index += 1;
                BindingList<Administrador.alumno> bdl = new BindingList<Administrador.alumno>();
                for (int n_ = (index - 1) * 20; (n_ < aux.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvAlumno.DataSource = bdl;
            }
        }
    }
}
