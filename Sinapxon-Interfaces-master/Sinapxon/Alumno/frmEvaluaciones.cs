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
    public partial class frmEvaluaciones : Form
    {
        public frmEvaluaciones()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmEvaluacion formEvaluacion = new frmEvaluacion();
            formEvaluacion.Visible = true;
        }
    }
}
