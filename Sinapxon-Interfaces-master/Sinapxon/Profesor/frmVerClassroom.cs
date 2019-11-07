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
    public partial class frmVerClassroom : Form
    {
        public frmVerClassroom()
        {
            InitializeComponent();
        }

        private void btnAniadirTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            formTema.Visible = true;
        }

        private void btnAniadirEvaluacion_Click(object sender, EventArgs e)
        {
            frmEvaluacion formAniadirEvaluacion = new frmEvaluacion();
            formAniadirEvaluacion.Visible = true;
        }

        private void btnEditarTema_Click(object sender, EventArgs e)
        {
            frmTema formTema = new frmTema();
            formTema.Visible = true;
        }

        private void btnCalificarEvaluacion_Click(object sender, EventArgs e)
        {
            frmCalificar formCalificar = new frmCalificar();
            formCalificar.Visible = true;
        }
    }
}
