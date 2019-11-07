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
    public partial class frmTemas : Form
    {
        public frmTemas()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIrTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            formTema.Visible = true;
        }
    }
}
