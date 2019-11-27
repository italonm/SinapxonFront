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
    public partial class frmTema : Form
    {
        private Alumno.tema tema;
        private Estado estadoTema;

        Alumno.AlumnoServicesClient DBController = new Alumno.AlumnoServicesClient();

        int posC1;
        int posC2;
        string vidio;
        BindingList<Alumno.archivoXTema> archivos;

        public frmTema()
        {
            InitializeComponent();
            dgvArchivos.AutoGenerateColumns = false;
            lblNombreTema.Text = ALUMNO_temaInfo.tema_X_classroom.nombre;
            txtDescripcion.Text = ALUMNO_temaInfo.tema_X_classroom.descripcion;
            vidio = ALUMNO_temaInfo.tema_X_classroom.link.Replace("watch?v=","embed/");

            try
            {
                archivos = new BindingList<archivoXTema>(DBController.listarArchivosXTemaXClassroom(ALUMNO_temaInfo.tema_X_classroom.id_tema, ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo));
            }
            catch (Exception)
            {
                archivos = new BindingList<archivoXTema>();
            }
            dgvArchivos.DataSource = archivos;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"520\" src=\"{0}\"" +
            "<iframe height=\"260\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            //var url = "https://www.youtube.com/embed/L6ZgzJKfERM";
            //var url = "https://www.youtube.com/embed/mb3GhfFfo_0";
            var url = vidio;
            this.webBrowser2.DocumentText = string.Format(embed, url);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArchivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Alumno.archivoXTema archFila = (Alumno.archivoXTema)dgvArchivos.Rows[e.RowIndex].DataBoundItem;
            if(archFila!=null)
            {
                dgvArchivos.Rows[e.RowIndex].Cells[0].Value = archFila.id_archivo_x_tema.ToString();
                dgvArchivos.Rows[e.RowIndex].Cells[1].Value = archFila.nombre;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            saveFileDialogArchivo.ShowDialog();
            byte[] arreglo
                = DBController.obtenerArchivo(((Alumno.archivoXTema)dgvArchivos.CurrentRow.DataBoundItem).id_archivo_x_tema);
            File.WriteAllBytes(saveFileDialogArchivo.FileName + ((Alumno.archivoXTema)dgvArchivos.CurrentRow.DataBoundItem).nombre, arreglo);
        }
    }
}
