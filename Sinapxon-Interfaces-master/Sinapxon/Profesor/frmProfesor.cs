using Sinapxon.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Profesor
{
    public partial class frmProfesor : Form
    {
        private string _codigo;
        private Form formularioActivo = null;
        public frmProfesor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lblNombreUsuario.Text = LoginInfo.persona.nombre;
            panelSubGestionarUsr.Visible = false;
        }

        public frmProfesor(string codigo)
        {
            _codigo = codigo;
            InitializeComponent();
        }

        public void openChildForm(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void btnGestionarMisClassrooms_Click(object sender, EventArgs e)
        {
            frmGestionarMisClassrooms formMisClassrooms = new frmGestionarMisClassrooms(this);
            openChildForm(formMisClassrooms);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            if (panelSubGestionarUsr.Visible)
            {
                panelSubGestionarUsr.Visible = false;
            }
            else
            {
                panelSubGestionarUsr.Visible = true;
            }
        }

        private void btnVerSolicitudes_Click(object sender, EventArgs e)
        {
            frmVerMisSolicitudes frmVerMisSolicitudes = new frmVerMisSolicitudes();
            this.openChildForm(frmVerMisSolicitudes);
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            frmDatosClassroom formDatosClassroom = new frmDatosClassroom();
            this.openChildForm(formDatosClassroom);
        }
    }
}
