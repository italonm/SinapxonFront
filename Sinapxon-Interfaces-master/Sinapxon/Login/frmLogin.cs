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
    public static class LoginInfo
    {
        public static Login.persona persona;
    }
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
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new frmRegistro();
            formRegistro.Visible = true;
            this.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmOvlideContrasenia formOlvideContrasenia = new frmOvlideContrasenia();
            formOlvideContrasenia.Visible = true;
            this.Visible = true;
        }

        private void pctImagenSinapxon_Click(object sender, EventArgs e)
        {

        }
    }
}
