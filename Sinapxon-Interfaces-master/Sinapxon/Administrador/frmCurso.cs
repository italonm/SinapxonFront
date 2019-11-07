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
    public partial class frmCurso : Form
    {
        public frmCurso(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo + " curso";
        }

        private void btnAgregarRequisito_Click(object sender, EventArgs e)
        {
            frmAgregarRequisito formAgregarRequisito = new frmAgregarRequisito();
            formAgregarRequisito.Visible = true;
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad formAgregarEspecialidad = new frmAgregarEspecialidad();
            formAgregarEspecialidad.Visible = true;
        }
    }
}
