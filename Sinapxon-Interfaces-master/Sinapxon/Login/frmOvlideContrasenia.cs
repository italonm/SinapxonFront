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
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("emmaragonq@hotmail.com");
            mail.To.Add(correo);
            mail.Subject = "Nueva contraseña Sinapxon";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "Su nueva contraseña es " + contrasenaNueva;
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("emmaragonq@hotmail.com", "aguilamaria");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Correo enviado, revise su bandeja de entrada");

            //string mensaje = string.Empty;
            //string destinatario = correo;
            //string remitente = "emmaraq96@gmail.com";
            //string asunto = "Nueva contraseña Sinapxon";
            //string cuerpoMensaje = "Su nueva contraseña es " + contrasenaNueva;
            //MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoMensaje);
            ////Host que se encargara de enviarlo
            //SmtpClient stmp = new SmtpClient("smtp.gmail.com", 587);
            //stmp.EnableSsl = true;
            //stmp.Credentials = new NetworkCredential("emmaraq96@gmail.com", "admitido2013");
            //try
            //{
            //    Task.Run(() =>
            //    {
            //        stmp.Send(ms);
            //        MessageBox.Show("Correo enviado, revise su bandeja de entrada");
            //    }
            //);
            //    MessageBox.Show("Esta tarea puede tardar unos segundos, tenga paciencia");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            //}


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Activate();
            }
        }
    }
}
