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
    public partial class frmCurso : Form
    {
        private frmAdministrador _padre = null;

        private Administrador.curso curso;
        private Administrador.curso cursoshow;
        private BindingList<Administrador.curso> cursos;
        private Administrador.curso curSeleccionado;

        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoCurso;
        private String codigoAdmin;
        public frmCurso(String titulo, Administrador.curso curso, frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = titulo + " Curso";
            BindingList<Administrador.especialidad> especialidades = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";
            this.curso = new Administrador.curso ();
            this.curso = curso;
            this.cursos = new BindingList<Administrador.curso>();
            txtCodigoCurso.Text = curso.codigo;
            txtNombreCurso.Text = curso.nombre;
            txtDescripcion.Text = curso.descripcion;
            cbEspecialidad.Text = curso.especialidad.nombre;
            curso.cursos = new BindingList<Administrador.curso>(DBController.listarRequisitos(curso.codigo)).ToArray();
            dgvRequisitos.AutoGenerateColumns = false;
            this.cursos  = new BindingList<Administrador.curso>(curso.cursos.ToList()); ;          
            dgvRequisitos.DataSource = new BindingList<Administrador.curso>(DBController.listarRequisitos(curso.codigo));

            estadoComponentes(Estado.Modificar);
        }

        public frmCurso(String titulo, String codigoAdmin, frmAdministrador padre)
        {
            InitializeComponent();
            this.codigoAdmin = codigoAdmin;
            lblTitulo.Text = titulo + " Curso";
            this.curso = new Administrador.curso();
            this.cursos = new BindingList<Administrador.curso>();
            BindingList<Administrador.especialidad> especialidades = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";
            dgvRequisitos.AutoGenerateColumns = false;
            dgvRequisitos.DataSource = new BindingList<Administrador.curso>();
            this.Padre = padre;
            estadoComponentes(Estado.Actualizar);
        }

        public void limpiarComponentes()
        {
            txtNombreCurso.Text = "";
            txtCodigoCurso.Text = "";
            txtDescripcion.Text = "";
            cbEspecialidad.SelectedIndex = -1;
            dgvRequisitos.DataSource = null;
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnAgregarRequisito.Enabled = false;
                    btnQuitarRequisito.Enabled =false;
                    btnCancelar.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    dgvRequisitos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAgregarRequisito.Enabled = true;
                    btnQuitarRequisito.Enabled = true;
                    txtNombreCurso.Enabled = true;
                    txtCodigoCurso.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cbEspecialidad.Enabled = true;
                    dgvRequisitos.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAgregarRequisito.Enabled = true;
                    btnQuitarRequisito.Enabled = true;
                    txtCodigoCurso.Enabled = false;
                    txtNombreCurso.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cbEspecialidad.Enabled = true;
                    dgvRequisitos.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAgregarRequisito.Enabled = false;
                    btnQuitarRequisito.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    dgvRequisitos.Enabled = false;
                    break;
            }
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void dgvRequisitos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvRequisitos.Rows[e.RowIndex].DataBoundItem;
            if (cursoFila != null)
            {
                dgvRequisitos.Rows[e.RowIndex].Cells[0].Value = cursoFila.codigo;
                dgvRequisitos.Rows[e.RowIndex].Cells[1].Value = cursoFila.nombre;
                dgvRequisitos.Rows[e.RowIndex].Cells[2].Value = cursoFila.descripcion;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            curso = new Administrador.curso();
            curso.administrador.codigo = codigoAdmin;
            cursos = new BindingList<Administrador.curso>();
            dgvRequisitos.AutoGenerateColumns = false;
            dgvRequisitos.DataSource = cursos;
            estadoCurso = Estado.Nuevo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCurso.Text == "")
            {
                MessageBox.Show("Debe asignar un código al curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombreCurso.Text == "")
            {
                MessageBox.Show("Debe colocar el nombre del curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cursoshow = new Administrador.curso();
            cursoshow.codigo = txtCodigoCurso.Text;
            cursoshow.nombre = txtNombreCurso.Text;
            cursoshow.descripcion = txtDescripcion.Text;
            cursoshow.especialidad = (Administrador.especialidad)cbEspecialidad.SelectedItem;
            cursoshow.administrador.codigo = this.curso.administrador.codigo;
            cursoshow.cursos = cursos.ToArray();

            if (estadoCurso == Estado.Nuevo)
            {
                DBController.insertarCurso(curso);
                MessageBox.Show("El curso se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoCurso == Estado.Modificar)
            {
                DBController.actualizarCurso(cursoshow);
                MessageBox.Show("El curso se ha sido actualizada con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Inicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este curso?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarAlumno(curso.codigo);
                MessageBox.Show("El curso ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            estadoCurso = Estado.Modificar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        private void btnAgregarRequisito_Click(object sender, EventArgs e)
        {
            frmAgregarRequisito formAgregarRequisito = new frmAgregarRequisito();
            if (formAgregarRequisito.ShowDialog() == DialogResult.OK)
            {
                curSeleccionado = formAgregarRequisito.CurSeleccionado;
                this.cursos = new BindingList<Administrador.curso>(this.curso.cursos.ToList());
                dgvRequisitos.AutoGenerateColumns = false;
                dgvRequisitos.DataSource = this.cursos;
                estadoComponentes(Estado.Actualizar);
            }
            if (curSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado un curso requisito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cursos.Add(curSeleccionado);
            curSeleccionado = null;
        }

        private void btnQuitarRequisito_Click(object sender, EventArgs e)
        {
            if (cursos.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado un requisito a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Administrador.curso curreq = (Administrador.curso)dgvRequisitos.CurrentRow.DataBoundItem;
            cursos.Remove(curreq);
            dgvRequisitos.DataSource = this.cursos;
        }

        private void btnAgregarEsp_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad formAgregarEspecialidad = new frmAgregarEspecialidad(codigoAdmin);
            formAgregarEspecialidad.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionarCursos formGestionarCurso = new frmGestionarCursos(this.Padre);
            Padre.openChildForm(formGestionarCurso);
        }
    }
}
