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

namespace Sinapxon.Profesor
{
    public partial class frmTema : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        BindingList<Profesor.tema> temas;
        private Profesor.archivoXTema archivo=new Profesor.archivoXTema();
        private frmProfesor _profesor;
        string ruta;
        public frmTema(frmProfesor profesor)
        {
            InitializeComponent();
            _profesor = profesor;
            lblTema.Text = "Tema" + " - " + ClassroomInfo.classroom.codigo;
            temas = new BindingList<Profesor.tema>(DBController.listarTemas());
            cbTemas.DataSource = temas;
            cbTemas.DisplayMember = "Nombre";
            cbTemas.ValueMember = "id_tema";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor.temaXClassroom temaxClassroom = new Profesor.temaXClassroom();
            temaxClassroom.tema = new Profesor.tema();
            temaxClassroom.tema = (Profesor.tema)cbTemas.SelectedItem;
            temaxClassroom.classroom = new Profesor.classroom();
            temaxClassroom.classroom.alumnos = new BindingList<Profesor.classroomXAlumno>().ToArray();
            temaxClassroom.classroom.codigo = ClassroomInfo.classroom.codigo;
            temaxClassroom.classroom.curso = new Profesor.curso();
            temaxClassroom.classroom.idioma = new Profesor.idioma();
            temaxClassroom.classroom.periodo = new Profesor.periodo();
            temaxClassroom.classroom.profesor = new profesor();
            temaxClassroom.classroom.temas = new BindingList<Profesor.temaXClassroom>().ToArray();
            temaxClassroom.descripcion = txtDescripcion.Text;
            temaxClassroom.link = txtLinkVideo.Text;
            temaxClassroom.evaluacion = new Profesor.evaluacion();
            DBController.insertarTemaxClassroom(temaxClassroom);
            /////////////////////
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte [] bytes= br.ReadBytes((int)fs.Length);
            archivo.descripcion = "";
            int aux=DBController.insertarArchivoXTema(archivo, ((Profesor.tema)cbTemas.SelectedItem).id_tema, ClassroomInfo.classroom.codigo);
            DBController.guardarArchivoxTema(bytes, aux);
            frmVerClassroom frmVerClassroom = new frmVerClassroom(_profesor);
            _profesor.openChildForm(frmVerClassroom);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmVerClassroom frmVerClassroom = new frmVerClassroom(_profesor);
            _profesor.openChildForm(frmVerClassroom);
        }

        private void btnAniadirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofd.FileName;
                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    //Profesor.archivoXTema arch = new Profesor.archivoXTema ();
                    archivo.nombre = ofd.SafeFileName;
                    txtArchivo.Text = archivo.nombre;
                    //BinaryReader br = new BinaryReader(fs);
                    //archivos.Add(br.ReadBytes((int)fs.Length));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {

        }
    }
}
