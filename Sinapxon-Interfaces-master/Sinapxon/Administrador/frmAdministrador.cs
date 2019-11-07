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
    public partial class frmAdministrador : Form
    {
        private Form formularioActivo = null;
        public frmAdministrador()
        {
            InitializeComponent();
            panelSubGestionarUsr.Visible = false;
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

        private void btnGestionarCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGestionarCursos(this));
        }

        private void btnGestionarClassrooms_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGestionarClassroom(this));
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            if(panelSubGestionarUsr.Visible)
            {
                panelSubGestionarUsr.Visible = false;
            }
            else
            {
                panelSubGestionarUsr.Visible = true;
            }
        }

        private void btnGestionarProfesor_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGestionarProfesor(this));
        }

        private void btnGestionarAlumno_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGestionarAlumno(this));
        }
    }
}
