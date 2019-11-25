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
    public partial class frmCurso : Form
    {
        private frmAdministrador _padre = null;
        private int tipo;
        private int tipoX;
        private Administrador.curso curso;
        private BindingList<Administrador.curso> cursos;
        private BindingList<Administrador.curso> listado;
        private Administrador.curso curSeleccionado;
        Administrador.curso cur;

        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoCurso;
        private String codigoAdmin;

        //==============================================================================================================================================================
        //AL SELECCIONAR UN CURSO
        public frmCurso(Administrador.curso curSelec, frmAdministrador padre)
        {
            //Inicializo Formulario
            tipo = 1;
            tipoX = 1;
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = "Editar Curso";

            //Listado especialidades
            BindingList<Administrador.especialidad> especialidades = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";

            //Curso Nuevo
            curso = new Administrador.curso();

            try
             {
                curSelec.cursos = new BindingList<Administrador.curso>(DBController.listarRequisitos(curSelec.codigo)).ToArray();
            }
            catch
            {
                curSelec.cursos = new BindingList<Administrador.curso>().ToArray();
            }

            curso = curSelec;
            txtCodigoCurso.Text = curSelec.codigo;
            txtNombreCurso.Text = curSelec.nombre;
            txtDescripcion.Text = curSelec.descripcion;
            cbEspecialidad.Text = curSelec.especialidad.nombre;
            cursos = new BindingList<Administrador.curso>(curso.cursos.ToList());
            

            dgvRequisitos.AutoGenerateColumns = false;
            try
            {
                dgvRequisitos.DataSource = cursos;
            }
            catch
            {
                dgvRequisitos.DataSource = cursos;
            }
            dgvRequisitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //AL CREAR UN CURSO
        public frmCurso(frmAdministrador padre)
        {
            tipo = 2;
            tipoX = 2;
            //Inicializo Formulario
            InitializeComponent();
            this.Padre = padre;
            this.codigoAdmin = LoginInfo.persona.codigo;
            lblTitulo.Text = "Añadir Curso";
            curso = new Administrador.curso();
            curso.cursos = new BindingList<Administrador.curso>().ToArray();
            //Listado especialidades
            BindingList<Administrador.especialidad> especialidades = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";
            cursos = new BindingList<Administrador.curso>();
            dgvRequisitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            estadoComponentes(Estado.Inicial);
        }
        //==============================================================================================================================================================
        //LIMPIEZA DE DATOS
        public void limpiarComponentes()
        {
            txtNombreCurso.Text = "";
            txtCodigoCurso.Text = "";
            txtDescripcion.Text = "";
            cbEspecialidad.SelectedIndex = -1;
            dgvRequisitos.DataSource = null;
        }
        //==============================================================================================================================================================
        //ESTADOS
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
                    btnQuitarRequisito.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnAgregarEsp.Enabled = false;
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
                    btnAgregarEsp.Enabled = true;
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
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarRequisito.Enabled = false;
                    btnQuitarRequisito.Enabled = false;
                    btnAgregarEsp.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    dgvRequisitos.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnAgregarRequisito.Enabled = false;
                    btnQuitarRequisito.Enabled = false;
                    btnAgregarEsp.Enabled = false;
                    txtCodigoCurso.Enabled = false;
                    txtNombreCurso.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbEspecialidad.Enabled = false;
                    dgvRequisitos.Enabled = false;
                    break;
            }
        }
        //==============================================================================================================================================================
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        //==============================================================================================================================================================
        //DGV
        private void dgvRequisitos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                Administrador.curso cursoFila = (Administrador.curso)dgvRequisitos.Rows[e.RowIndex].DataBoundItem;
                if (cursoFila != null)
                {
                    dgvRequisitos.Rows[e.RowIndex].Cells[0].Value = cursoFila.codigo.ToString();
                    dgvRequisitos.Rows[e.RowIndex].Cells[1].Value = cursoFila.nombre;
                    dgvRequisitos.Rows[e.RowIndex].Cells[2].Value = cursoFila.descripcion;
                }
            }
            catch
            {

            }
        }

        //==============================================================================================================================================================
        //NUEVO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            cur = new Administrador.curso();
            cur.cursos = new BindingList<Administrador.curso>().ToArray();
            cursos = new BindingList<Administrador.curso>();
            dgvRequisitos.AutoGenerateColumns = false;
            dgvRequisitos.DataSource = cursos;
            estadoCurso = Estado.Nuevo;
        }

        //==============================================================================================================================================================
        //GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombaux = txtNombreCurso.Text.ToLower();
            nombaux =  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombaux);
            String codigoaux = txtCodigoCurso.Text.ToUpper();
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
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe llenar la descripción del curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbEspecialidad.Text == "")
            {
                MessageBox.Show("Debe elegir una especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            listado = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            foreach (Administrador.curso curaux in listado)
            {
                 String nb = nombaux.ToUpper();
                 String cb = codigoaux.ToUpper();
                 String nl = curaux.nombre.ToUpper();
                 String cl = curaux.codigo.ToUpper();
                if (tipoX == 2)
                {
                    if ((string.Equals(cl, cb)) && !(string.Equals(nl, nb)))
                    {
                        MessageBox.Show("Ya existe un curso registrado con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!(string.Equals(cl, cb)) && (string.Equals(nl, nb)))
                    {
                        MessageBox.Show("Ya existe un curso registrado con el nombre ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if ((string.Equals(cl, cb)) && (string.Equals(nl, nb)))
                    {
                        MessageBox.Show("Ya existe un curso registrado con el código y nombre ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (!(string.Equals(cl, cb)) && (string.Equals(nl, nb)))
                    {
                        MessageBox.Show("Ya existe un curso registrado con el nombre ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            
            Administrador.administrador admin = new Administrador.administrador();

            cur = new Administrador.curso();
            cur.codigo = codigoaux;
            cur.nombre = nombaux;
            cur.descripcion = txtDescripcion.Text;
            cur.especialidad = (Administrador.especialidad)cbEspecialidad.SelectedItem;
            
            cur.cursos = cursos.ToArray();
            //GUARDAR NUEVO CURSO
            if (estadoCurso == Estado.Nuevo)
            {
                admin.codigo = codigoAdmin;
                cur.administrador = admin;
                cur.estado = 1;
                DBController.insertarCurso(cur);
                if (cur.cursos.Count() == 0)
                {
                    MessageBox.Show("El curso se ha registrado con exito, no presenta requisitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("El curso se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoX = 1;
            }
            //ACTUALIZAR CURSO SELECCIONADO
            else if (estadoCurso == Estado.Modificar)
            {
                if (tipo == 1) admin.codigo = curso.administrador.codigo;
                if (tipo == 2) admin.codigo = codigoAdmin;
                cur.administrador = admin;
                cur.estado = curso.estado;
                DBController.actualizarCurso(cur);
                if(txtDescripcion.Text == " " & cur.cursos.Count() == 0)
                {
                    MessageBox.Show("El curso se ha actualizado con exito, no presenta requisitos ni descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cur.cursos.Count() == 0)
                {
                    MessageBox.Show("El curso se ha actualizado con exito, no presenta requisitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtDescripcion.Text == " ")
                {
                    MessageBox.Show("El curso se ha actualizado con exito, no presenta descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("El curso se ha sido actualizado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //ELIMINAR CURSO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este curso?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminaCurso(curso.codigo);
                MessageBox.Show("El curso ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
            if (tipo==2)
            {
                btnNuevo.Enabled = false;
            }
            limpiarComponentes();
        }

        //==============================================================================================================================================================
        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            if (tipoX == 1) txtCodigoCurso.Enabled = false;
            btnEliminar.Enabled = true;
            estadoCurso = Estado.Modificar;
        }

        //==============================================================================================================================================================
        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            btnModificar.Enabled=true;
            if (tipo == 1) {
                btnNuevo.Enabled = false;
            }
            if(estadoCurso== Estado.Modificar) {
                dgvRequisitos.DataSource = curso.cursos;
            }
        }

        //==============================================================================================================================================================
        //AGREGAR REQUISITO AL CURSO
        private void btnAgregarRequisito_Click(object sender, EventArgs e)
        {
            frmAgregarRequisito formAgregarRequisito = new frmAgregarRequisito(curso.codigo, cursos);
            if (formAgregarRequisito.ShowDialog() == DialogResult.OK)
            {
                curSeleccionado = new Administrador.curso();
                curSeleccionado = formAgregarRequisito.CurSeleccionado;
                dgvRequisitos.AutoGenerateColumns = false;
            }
            if (curSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado un curso requisito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cursos.Add(curSeleccionado);
                curSeleccionado = null;
            }
        }
        //==============================================================================================================================================================
        //QUITAR REQUISITO AL CURSO
        private void btnQuitarRequisito_Click(object sender, EventArgs e)
        {
            if (cursos.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado un requisito a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Administrador.curso curSeleccionado = (Administrador.curso)dgvRequisitos.CurrentRow.DataBoundItem;
            cursos.Remove(curSeleccionado);
        }

        //==============================================================================================================================================================
        //GESTIONAR: CREAR O MODIFICAR ESPECIALIDADES
        private void btnAgregarEsp_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad formAgregarEspecialidad = new frmAgregarEspecialidad();
            formAgregarEspecialidad.Visible = true;
        }

        //==============================================================================================================================================================
        //REGRESAR AL LISTADO DE CURSO
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionarCursos formGestionarCurso = new frmGestionarCursos(this.Padre);
            Padre.openChildForm(formGestionarCurso);
        }

        private void panel5_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
