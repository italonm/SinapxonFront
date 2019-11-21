using Sinapxon.Administrador;
using Sinapxon.Alumno;
using Sinapxon.Profesor;
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
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login.LoginServicesClient DBController = new Login.LoginServicesClient() ;
            LoginInfo.persona = DBController.validarLogin(txtUsuario.Text, txtContrasenia.Text);
            //LoginInfo.codigo = result.Substring(0, 6);
            if (LoginInfo.persona.nombre == null)
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String tipo = LoginInfo.persona.tipo;
            if (string.Equals(tipo, "D"))
            {
                frmAdministrador formAdministrador = new frmAdministrador();
                formAdministrador.Visible = true;
                this.Visible = true;

            }
            else if (string.Equals(tipo, "A"))
            {
                frmAlumno formAlumno = new frmAlumno();
                formAlumno.Visible = true;
                this.Visible = true;
            }
            else if (string.Equals(tipo, "P"))
            {
                frmProfesor formProfesor = new frmProfesor();
                formProfesor.Visible = true;
                this.Visible = true;
            }
            else
            {
                /* ERROR en el usuario o contraseña*/

            }
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new frmRegistro();
            formRegistro.Visible = true;
            this.Visible = true;
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmOvlideContrasenia formOlvideContrasenia = new frmOvlideContrasenia();
            formOlvideContrasenia.Visible = true;
            this.Visible = true;
            this.Hide();
        }

        private void pctImagenSinapxon_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            if (usuario.ToLower().Trim().Equals("usuario"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            if (usuario.ToLower().Trim().Equals("usuario") || usuario.Trim().Equals(""))
            {
                txtUsuario.Text = "usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            String password = txtContrasenia.Text;
            if (password.ToLower().Trim().Equals("contraseña"))
            {
                txtContrasenia.Text = "";
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.ForeColor = Color.White;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            String password = txtContrasenia.Text;
            if (password.ToLower().Trim().Equals("usuario") || password.Trim().Equals(""))
            {
                txtContrasenia.Text = "contraseña";
                txtContrasenia.UseSystemPasswordChar = false;
                txtContrasenia.ForeColor = Color.Gray;
            }
        }
    }

    public static class LoginInfo
    {
        public static Login.persona persona;
    }
}
