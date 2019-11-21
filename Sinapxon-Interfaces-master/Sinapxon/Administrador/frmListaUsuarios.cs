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
    public partial class frmListaUsuarios : Form
    {
        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        public frmListaUsuarios(string tipo)
        {
            InitializeComponent();
            lblTitulo.Text = "Lista de " + tipo;
        }

        private void btnCargarProfesor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
