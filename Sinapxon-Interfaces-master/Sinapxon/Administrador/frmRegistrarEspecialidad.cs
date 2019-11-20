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
    public partial class frmRegistrarEspecialidad : Form
    {
        private frmAdministrador _padre = null;
        private Administrador.especialidad especialidad;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private String codigoAdmin;
        private Estado estadoEspecialidad;
        public frmRegistrarEspecialidad(String codigo, Administrador.especialidad espSelec)
        {
            InitializeComponent();
            this.codigoAdmin = codigo;
            txtIdEspecialidad.Text = espSelec.id_especialidad.ToString();
            txtNombre.Text = espSelec.nombre;
            txtDescripcion.Text = espSelec.descripcion;
            estadoComponentes(Estado.Modificar);
        }

        public frmRegistrarEspecialidad(String codigo)
        {
            InitializeComponent();
            this.codigoAdmin = codigo;
            estadoComponentes(Estado.Nuevo);
        }

        public void limpiarComponentes()
        {
            txtIdEspecialidad.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
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
                    btnRegresar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtIdEspecialidad.Enabled = false;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    txtIdEspecialidad.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIdEspecialidad.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            especialidad = new Administrador.especialidad();
            especialidad.administrador.codigo = codigoAdmin;
            estadoEspecialidad = Estado.Nuevo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdEspecialidad.Text == "")
            {
                MessageBox.Show("Debe asignar un ID a la especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe colocar el nombre de la especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            especialidad = new Administrador.especialidad();
            especialidad.id_especialidad = Int32.Parse(txtIdEspecialidad.Text);
            especialidad.nombre = txtNombre.Text;
            especialidad.descripcion = txtDescripcion.Text;

            if (estadoEspecialidad == Estado.Nuevo)
            {
                DBController.insertarEspecialidad(especialidad);
                MessageBox.Show("La especialidad se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoEspecialidad == Estado.Modificar)
            {
                DBController.actualizarEspecialidad(especialidad);
                MessageBox.Show("La especialidad se ha sido actualizada con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Inicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar esta espacialidad?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarEspecialidad(especialidad.id_especialidad);
                MessageBox.Show("La especialidad se ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            estadoEspecialidad = Estado.Modificar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad formAgregarEspecialidad = new frmAgregarEspecialidad(codigoAdmin);
            this.Close();
            formAgregarEspecialidad.Visible = true;
        }
    }
}
