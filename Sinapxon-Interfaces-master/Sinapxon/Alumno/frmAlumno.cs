using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Alumno
{
    public partial class frmAlumno : Form
    {
        private Form formularioActivo = null;
        public frmAlumno()
        {
            InitializeComponent();
        }

        public void openChildForm(Form formularioHijo)
        {
            if(formularioActivo != null)
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

        private void BtnMisClassrooms_Click(object sender, EventArgs e)
        {
            frmMisClassrooms misClassrooms = new frmMisClassrooms(this);
            openChildForm(misClassrooms);
        }

        private void BtnExplorar_Click(object sender, EventArgs e)
        {
            frmExplorarCursos explorarCursos = new frmExplorarCursos(this);
            openChildForm(explorarCursos);
        }
    }
}
