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
    public partial class frmGestionarAlumno : Form
    {
        private frmAdministrador _padre = null;
        public frmGestionarAlumno()
        {
            InitializeComponent();
        }

        public frmGestionarAlumno(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListaUsuarios formListarUsuario = new frmListaUsuarios("alumnos");
            formListarUsuario.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno();
            formDatosAlumno.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmDatosAlumno formDatosAlumno = new frmDatosAlumno();
            formDatosAlumno.Visible = true;
        }
    }
}
