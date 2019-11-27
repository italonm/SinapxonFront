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
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
            lblNombreEvaluacion.Text = ALUMNO_evaluacionInfo.evaluacion.nombre;
            txtDescripcion.Text = ALUMNO_evaluacionInfo.evaluacion.descripcion;
            lblPeso.Text = "Peso de la evaluacion: " + ALUMNO_evaluacionInfo.evaluacion.peso_porcentual.ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
