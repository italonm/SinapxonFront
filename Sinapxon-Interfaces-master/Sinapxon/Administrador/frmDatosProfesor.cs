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
    public partial class frmDatosProfesor : Form
    {
        private frmAdministrador _padre = null;
        private Administrador.profesor profesor;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoProfesor;

        public frmDatosProfesor(Administrador.profesor profesor, frmAdministrador padre)
        {
            InitializeComponent(); this.Padre = padre;
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";

            txtIdProfesor.Text = profesor.codigo;
            txtNombre.Text = profesor.nombre;
            txtApMat.Text = profesor.apellidoMaterno;
            txtApPat.Text = profesor.apellidoPaterno;
            txtDNI.Text = profesor.dni;
            txtCorreo.Text = profesor.correo;
            cboPais.Text = profesor.pais.nombre;
            txtGrado.Text = profesor.gradoInstruccion;
            txtTelf.Text = profesor.telefono;
            txtNickname.Text = profesor.nickname;
            txtPassword.Text = profesor.password;
            txtAInt.Text = profesor.areaInteres;
            dtFechNac.Text = profesor.fecha.ToShortDateString();
            if (profesor.estado == 0)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = true;
            }
            if (profesor.estado == 1)
            {
                rbActivo.Checked = true;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = false;
            }
            if (profesor.estado == 2)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = true;
                rbInactivo.Checked = false;
            }
            estadoComponentes(Estado.Modificar);
        }


        public frmDatosProfesor(frmAdministrador padre)
        {
            InitializeComponent();
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";
            this.Padre = padre;

            estadoComponentes(Estado.Inicial);
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        public void limpiarComponentes()
        {
            txtIdProfesor.Text = "";
            txtNombre.Text = "";
            txtApMat.Text = "";
            txtApPat.Text = "";
            txtDNI.Text = "";
            txtCorreo.Text = "";
            cboPais.SelectedIndex = -1;
            txtGrado.Text = "";
            txtTelf.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
            txtAInt.Text = "";
            dtFechNac.Value = DateTime.Today;
            rbActivo.Checked = false;
            rbBloqueado.Checked = false;
            rbInactivo.Checked = false;
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
                    gbEstado.Enabled = false;
                    txtAInt.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtGrado.Enabled = false;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = true;
                    txtAInt.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtGrado.Enabled = true;
                    txtIdProfesor.Enabled = true;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = false;
                    txtAInt.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtGrado.Enabled = true;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = false;
                    txtAInt.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtGrado.Enabled = false;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            profesor = new Administrador.profesor();
            estadoProfesor = Estado.Nuevo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProfesor.Text == "")
            {
                MessageBox.Show("Debe asignar un ID al profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe colocar el nombre del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtApPat.Text == "") || (txtApMat.Text == ""))
            {
                MessageBox.Show("Debe completar los dos campos para los apellidos del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe colocar el DNI del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            profesor = new Administrador.profesor();
            profesor.codigo = txtIdProfesor.Text;
            profesor.nombre = txtNombre.Text;
            profesor.apellidoMaterno = txtApMat.Text;
            profesor.apellidoPaterno = txtApPat.Text;
            profesor.dni = txtDNI.Text;
            profesor.correo = txtCorreo.Text;
            profesor.pais = (Administrador.pais)cboPais.SelectedItem;
            profesor.gradoInstruccion = txtGrado.Text;
            profesor.telefono = txtTelf.Text;
            profesor.nickname = txtNickname.Text;
            profesor.password = txtPassword.Text;
            profesor.areaInteres = txtAInt.Text;
            profesor.password = txtPassword.Text;
            profesor.fecha = dtFechNac.Value;
            profesor.fechaSpecified = true;
            if (rbActivo.Checked == true)
            {
                profesor.estado = 1;
            }
            if (rbBloqueado.Checked == true)
            {
                profesor.estado = 2;
            }
            if (rbInactivo.Checked == true)
            {
                profesor.estado = 0;
            }
            if (estadoProfesor == Estado.Nuevo)
            {
                DBController.insertarProfesor(profesor);
                MessageBox.Show("El profesor se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoProfesor == Estado.Modificar)
            {
                DBController.actualizarProfesor(profesor);
                MessageBox.Show("El profesor se ha sido actualizado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Inicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este profesor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarProfesor(profesor.codigo);
                MessageBox.Show("El profesor ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            estadoProfesor = Estado.Modificar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        private void btnGenerarContr_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionarProfesor formGestionarProfesor = new frmGestionarProfesor(this.Padre);
            _padre.openChildForm(formGestionarProfesor);
        }
    }
}
