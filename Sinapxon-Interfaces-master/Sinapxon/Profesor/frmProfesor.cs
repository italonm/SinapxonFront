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
            lblNombreUsuario.Text = LoginInfo.persona.nombre;
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
        private void Button1_Click(object sender, EventArgs e)
        {
            frmGestionarMisClassrooms formMisClassrooms = new frmGestionarMisClassrooms(this);
            openChildForm(formMisClassrooms);
        }
    }
}
