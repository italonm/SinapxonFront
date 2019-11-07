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
    public partial class frmGestionarClassroom : Form
    {
        private frmAdministrador _padre = null;
        public frmGestionarClassroom()
        {
            InitializeComponent();
        }

        public frmGestionarClassroom(frmAdministrador padre)
        {
            InitializeComponent();
            this.Padre = padre;
        }

        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSolicitudClassroom formSolicitudClassroom = new frmSolicitudClassroom();
            formSolicitudClassroom.Visible = true;
        }
    }
}
