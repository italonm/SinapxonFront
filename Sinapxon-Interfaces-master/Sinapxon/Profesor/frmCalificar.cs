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
    public partial class frmCalificar : Form
    {
        private frmProfesor _profesor;
        public frmCalificar(frmProfesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmVerClassroom frmVerClassroom = new frmVerClassroom(_profesor);
            _profesor.openChildForm(frmVerClassroom);
        }

        private void btnAsignarPuntaje_Click(object sender, EventArgs e)
        {

        }
    }
}
