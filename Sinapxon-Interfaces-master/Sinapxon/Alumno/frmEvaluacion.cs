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
        Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();

        private BindingList<Alumno.entregable> entregables;
        private string ruta;
        private string nombArch;

        public frmEvaluacion()
        {
            InitializeComponent();
            lblNombreEvaluacion.Text = ALUMNO_evaluacionInfo.evaluacion.nombre;
            txtDescripcion.Text = ALUMNO_evaluacionInfo.evaluacion.descripcion;
            lblPeso.Text = "Peso de la evaluacion: " + ALUMNO_evaluacionInfo.evaluacion.peso_porcentual.ToString();
            dgvArchivos.AutoGenerateColumns = false;

            try
            {
                entregables = new BindingList<entregable>();
            }
            catch (Exception)
            {

                throw;
            }
            dgvArchivos.DataSource = entregables;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAniadirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog1.FileName;
                    nombArch = openFileDialog1.SafeFileName;
                    Alumno.entregable entregableAux = new entregable();
                    Alumno.archivoXEntregable archAux = new archivoXEntregable();
                    archAux.nombre = nombArch;

                    entregableAux.archivo = archAux;
                    entregables.Add(entregableAux);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvArchivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Alumno.entregable entregableFila= (Alumno.entregable)dgvArchivos.Rows[e.RowIndex].DataBoundItem;
            if (entregableFila != null)
            {
                dgvArchivos.Rows[e.RowIndex].Cells[0].Value = entregableFila.archivo.nombre;
            }
        }
    }
}
