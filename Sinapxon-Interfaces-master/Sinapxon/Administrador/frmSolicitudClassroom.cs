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
    public partial class frmSolicitudClassroom : Form
    {
        public frmSolicitudClassroom()
        {
            InitializeComponent();
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            DBController.crearClassroom_y_asignarProfesor(_solicitudClassroom);
            MessageBox.Show("Se agrego el classroom correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
