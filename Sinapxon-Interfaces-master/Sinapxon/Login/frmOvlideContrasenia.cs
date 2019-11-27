using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Login
{
    public partial class frmOvlideContrasenia : Form
    {
        private Login.LoginServicesClient DBController = new Login.LoginServicesClient();
        public frmOvlideContrasenia()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            LoginInfo.persona = DBController.validarCorreo(txtCorreo.Text);
            String usuario = LoginInfo.persona.nombre;
            if(txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese su correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (usuario == null)
            {
                MessageBox.Show("Email invalido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                
                GenerarNuevaContrasenia(txtCorreo.Text);

            }
            this.Close();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }
        public void GenerarNuevaContrasenia(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaContrasenia = rd.Next(100000, 9999999);
            DBController.actualizarPassword(LoginInfo.persona.codigo,nuevaContrasenia.ToString());
            EnviarCorreo(nuevaContrasenia.ToString(),txtCorreo.Text);
        }

        private void EnviarCorreo(string contrasenaNueva, string correo)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("sinapxonsac.peru@gmail.com");
            mail.To.Add(correo);
            mail.Subject = "Nueva contraseña Sinapxon";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "Su nueva contraseña es " + contrasenaNueva;
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sinapxonsac.peru@gmail.com", "lp2grupoB");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Correo enviado, revise su bandeja de entrada");
            this.Close();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
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

        private void frmOvlideContrasenia_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCorreo;
            txtCorreo.Focus();
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar_Click(sender, e);
            }
        }
    }
}
