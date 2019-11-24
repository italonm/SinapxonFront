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
    public partial class frmRegistrarEspecialidad : Form
    {
        private frmAdministrador _padre = null;
        private Administrador.especialidad especialidad;
        private Administrador.especialidad especaux;
        private BindingList<Administrador.especialidad> listado;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private String codigoAdmin;
        private Estado estadoEspecialidad;
        int tipo;

        //==============================================================================================================================================================
        //AL SELECCIONAR UNA ESPECIALIDAD
        public frmRegistrarEspecialidad(Administrador.especialidad espSelec)
        {
            InitializeComponent();
            lblTitulo.Text = "Editar Especialidad";
            this.Text = "Editar Especialidad";
            especaux = new Administrador.especialidad();
            especaux = espSelec;
            tipo = 1;
            this.codigoAdmin = espSelec.administrador.codigo;
            txtIdEspecialidad.Text = espSelec.id_especialidad.ToString();
            txtNombre.Text = espSelec.nombre;
            txtDescripcion.Text = espSelec.descripcion;
            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //AL CREAR UNA ESPECIALIDAD
        public frmRegistrarEspecialidad()
        {
            InitializeComponent();
            lblTitulo.Text = "Añadir Especialidad";
            this.Text = "Añadir Especialidad";
            tipo = 2;
            estadoComponentes(Estado.Inicial);
        }
        //==============================================================================================================================================================
        //LIMPIEZA DE DATOS
        public void limpiarComponentes()
        {
            txtIdEspecialidad.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
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
                    btnCancelar.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtIdEspecialidad.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtIdEspecialidad.Enabled = false;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtIdEspecialidad.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    txtIdEspecialidad.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    break;
            }
        }

        //==============================================================================================================================================================
        //NUEVO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            especialidad = new Administrador.especialidad();
            estadoEspecialidad = Estado.Nuevo;
        }


        //==============================================================================================================================================================
        //GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombreaux = txtNombre.Text.ToLower();
            nombreaux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombreaux);
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe colocar el nombre de la especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (estadoEspecialidad== Estado.Actualizar)
            {
                listado = new BindingList<Administrador.especialidad>(DBController.listarEspecialidades(""));
                foreach (Administrador.especialidad especaux in listado)
                {
                    String nb = nombreaux.ToUpper();
                    String nl = especaux.nombre.ToUpper();
                    if (string.Equals(nl, nb))
                    {
                        MessageBox.Show("Ya existe un curso registrado con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }               
            }
            Administrador.administrador admin = new Administrador.administrador();

            especialidad = new Administrador.especialidad();           
            especialidad.nombre = nombreaux;
            especialidad.descripcion = txtDescripcion.Text;

            if (estadoEspecialidad == Estado.Nuevo)
            {
                admin.codigo = LoginInfo.persona.codigo;
                especialidad.administrador = admin;
                DBController.insertarEspecialidad(especialidad);
                MessageBox.Show("La especialidad se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoEspecialidad == Estado.Modificar)
            {
                admin.codigo = codigoAdmin;
                especialidad.id_especialidad = Int32.Parse(txtIdEspecialidad.Text); 
                especialidad.administrador = admin;
                DBController.actualizarEspecialidad(especialidad);
                MessageBox.Show("La especialidad se ha sido actualizada con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar esta espacialidad?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarEspecialidad(especaux.id_especialidad);
                MessageBox.Show("La especialidad se ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
            if (tipo == 2)
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
            btnEliminar.Enabled = true;
            estadoEspecialidad = Estado.Modificar;
        }

        //==============================================================================================================================================================
        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            btnModificar.Enabled = true;
            if (tipo == 1)
            {
                btnNuevo.Enabled = false;
            }
        }

        //==============================================================================================================================================================
        //REGRESAR
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad formAgregarEspecialidad = new frmAgregarEspecialidad();
            this.Close();
            formAgregarEspecialidad.Visible = true;
        }
    }
}
