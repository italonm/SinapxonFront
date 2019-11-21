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
            this.WindowState = FormWindowState.Maximized;
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
            Login.LoginServicesClient dbLogin = new Login.LoginServicesClient();
            Login.alumno alumObt = dbLogin.validarNickname(txtNickname.Text);
            Login.persona perObt = dbLogin.validarCorreo(txtCorreo.Text);
            if (alumObt.codigo != null)
            {
                MessageBox.Show("El nickname ya se encuentra registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (perObt.nombre != null)
            {
                MessageBox.Show("El correo ya se encuentra registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.Close();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtNickname.Text = "";
            txtNombres.Text = "";
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtPassword.Text = "";
            txtRepetirPassword.Text = "";
            txtTelefono.Text = "";            
            dtpFechaNac.ResetText();
            this.ActiveControl = txtNombres;
            txtNombres.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
            }
            else
            {
                this.Activate();
            }
        }

        private void txtRepetirPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrarse_Click(sender, e);
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNombres;
            txtNombres.Focus();
        }
    }
}
