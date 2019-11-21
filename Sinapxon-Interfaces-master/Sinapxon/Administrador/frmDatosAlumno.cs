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
    public partial class frmDatosAlumno : Form
    {
        private frmAdministrador _padre = null;

        private Administrador.alumno alumno;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoAlumno;

        public frmDatosAlumno(Administrador.alumno alumno, frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";
            txtIdAlumno.Text = alumno.codigo;
            txtNombre.Text = alumno.nombre;
            txtApMat.Text = alumno.apellidoMaterno;
            txtApPat.Text = alumno.apellidoPaterno;
            txtDNI.Text = alumno.dni;
            txtCorreo.Text = alumno.correo;
            cboPais.Text = alumno.pais.nombre;
            txtTelf.Text = alumno.telefono;
            txtNickname.Text = alumno.nickname;
            txtPassword.Text = alumno.password;
            dtFechNac.Text = alumno.fecha.ToShortDateString();
            if (alumno.estado == 0)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = true;
            }
            if (alumno.estado == 1)
            {
                rbActivo.Checked = true;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = false;
            }
            if (alumno.estado == 2)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = true;
                rbInactivo.Checked = false;
            }
            estadoComponentes(Estado.Modificar);
        }

        public frmDatosAlumno(frmAdministrador padre)
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
            txtIdAlumno.Text = "";
            txtNombre.Text = "";
            txtApMat.Text = "";
            txtApPat.Text = "";
            txtDNI.Text = "";
            txtCorreo.Text = "";
            cboPais.SelectedIndex = -1;
            txtTelf.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
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
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdAlumno.Enabled = true;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    dtFechNac.Enabled = true;
                    cboPais.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = false;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    dtFechNac.Enabled = true;
                    cboPais.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    break;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text == "")
            {
                MessageBox.Show("Debe asignar un ID al alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe colocar el nombre del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtApPat.Text == "") || (txtApMat.Text == ""))
            {
                MessageBox.Show("Debe completar los dos campos para los apellidos del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe colocar el DNI del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            alumno = new Administrador.alumno();
            alumno.codigo = txtIdAlumno.Text;
            alumno.nombre = txtNombre.Text;
            alumno.apellidoMaterno = txtApMat.Text;
            alumno.apellidoPaterno = txtApPat.Text;
            alumno.dni = txtDNI.Text;
            alumno.correo = txtCorreo.Text;
            alumno.pais = (Administrador.pais)cboPais.SelectedItem;
            alumno.telefono = txtTelf.Text;
            alumno.nickname = txtNickname.Text;
            alumno.password = txtPassword.Text;
            alumno.fecha = dtFechNac.Value;
            alumno.fechaSpecified = true;
            if (rbActivo.Checked == true)
            {
                alumno.estado = 1;
            }
            if (rbBloqueado.Checked == true)
            {
                alumno.estado = 2;
            }
            if (rbInactivo.Checked == true)
            {
                alumno.estado = 0;
            }
            if (estadoAlumno == Estado.Nuevo)
            {
                DBController.insertarAlumno(alumno);
                MessageBox.Show("El alumno se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoAlumno == Estado.Modificar)
            {
                DBController.actualizarAlumno(alumno);
                MessageBox.Show("El alumno se ha sido actualizado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Inicial);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            alumno = new Administrador.alumno();
            estadoAlumno = Estado.Nuevo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este alumno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarAlumno(alumno.codigo);
                MessageBox.Show("El alumno ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            estadoAlumno = Estado.Modificar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        private void btnGenerarContr_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GenerarNuevaContrasenia();
            txtPassword.UseSystemPasswordChar = true;
        }
        public string GenerarNuevaContrasenia()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasenia = rd.Next(100000, 9999999);
            return nuevaContrasenia.ToString();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
