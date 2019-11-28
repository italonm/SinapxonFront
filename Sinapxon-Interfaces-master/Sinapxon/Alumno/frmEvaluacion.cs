using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private BindingList<byte[]> archivosB = new BindingList<byte[]>();

        public frmEvaluacion()
        {
            InitializeComponent();
            btnRemoverArchivo.Hide();
            lblNombreEvaluacion.Text = ALUMNO_evaluacionInfo.evaluacion.nombre;
            txtDescripcion.Text = ALUMNO_evaluacionInfo.evaluacion.descripcion;
            lblPeso.Text = "Peso de la evaluacion: " + ALUMNO_evaluacionInfo.evaluacion.peso_porcentual.ToString();
            dgvArchivos.AutoGenerateColumns = false;


            try
            {
                BindingList<archivoXEntregable> archivosXentregable;
                archivosXentregable  = new BindingList<archivoXEntregable>(DBController.listarArchivosXAlumnoXClassroomXEvaluacion(ALUMNO_evaluacionInfo.evaluacion.id_evaluacion,Login.LoginInfo.persona.codigo,ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo));
                entregables = new BindingList<entregable>();
                foreach(archivoXEntregable arch in archivosXentregable)
                {
                    Alumno.entregable auxEntregable = new entregable();
                    auxEntregable.archivo = arch;
                    entregables.Add(auxEntregable);
                }
            }
            catch (Exception)
            {
                entregables = new BindingList<entregable>();
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

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bytes = br.ReadBytes((int)fs.Length);
                    archivosB.Add(bytes);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int res = 0;
            int pos = 0;
            foreach(Alumno.entregable entr in entregables)
            {
                res = DBController.insertarArchivoXEntregable(entr.archivo);
                DBController.insertarEntregable(ALUMNO_evaluacionInfo.evaluacion.id_evaluacion,
                                                Login.LoginInfo.persona.codigo,
                                                ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo,
                                                " ",
                                                res);
                DBController.guardarArchivo(archivosB[pos], res);
            }
        }
    }
}
