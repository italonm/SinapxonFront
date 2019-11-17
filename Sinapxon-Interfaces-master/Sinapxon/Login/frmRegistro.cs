using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Login
{
    public partial class frmRegistro : Form
    {
        private Administrador.AdministradorServicesClient dbContoller = new Administrador.AdministradorServicesClient();
        private Administrador.alumno alumno;

        public frmRegistro()
        {
            InitializeComponent();
            alumno = new Administrador.alumno();
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(dbContoller.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_pais";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(String.Compare(txtPassword.Text, txtRepetirPassword.Text) != 0)
            {
                MessageBox.Show("Passwords no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombres.Text == "" || txtPassword.Text == "" || txtDni.Text == "" || txtCorreo.Text == "" || txtApellidoMaterno.Text == "" || txtApellidoPaterno.Text == ""
                || txtTelefono.Text == "" || txtNickname.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtDni.Text.Length != 8)
            {
                MessageBox.Show("DNI debe ser 8 caracteres de longitud", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String txtStudID;
            txtStudID = DateTime.Now.Year.ToString() + DateTime.Now.Second;
            alumno.codigo = txtStudID;
            alumno.nombre = txtNombres.Text;
            alumno.apellidoMaterno = txtApellidoMaterno.Text;
            alumno.apellidoPaterno = txtApellidoPaterno.Text;
            alumno.dni = txtDni.Text;
            alumno.correo = txtCorreo.Text;
            alumno.telefono = txtTelefono.Text;
            alumno.fecha = dtpFechaNac.Value;
            alumno.fechaSpecified = true;
            alumno.pais = (Administrador.pais)cboPais.SelectedItem;
            alumno.nickname = txtNickname.Text;
            alumno.password = txtPassword.Text;
            dbContoller.insertarAlumno(alumno);
            MessageBox.Show("Se ha registrado exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
