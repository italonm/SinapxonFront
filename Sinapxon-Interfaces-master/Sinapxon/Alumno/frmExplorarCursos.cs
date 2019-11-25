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
    public partial class frmExplorarCursos : Form
    {
        private int altura = 0, boxAltura = 174;
        private frmAlumno _padre = null;

        private Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();

        public frmExplorarCursos()
        {
            InitializeComponent();
            BindingList<Alumno.curso> cursos = new BindingList<curso>(DBController.listarCursos(""));

            foreach (Alumno.curso obj in cursos)
            {
                crearElemento(obj);
            }
        }

        public frmExplorarCursos(frmAlumno padre)
        {
            _padre = padre;
            InitializeComponent();
            BindingList<Alumno.curso> cursos = new BindingList<curso>(DBController.listarCursos(""));

            foreach (Alumno.curso obj in cursos)
            {
                crearElemento(obj);
            }

            //crearElemento();
        }

        public void crearElemento(Alumno.curso curso)
        {
            /*
             * Codigo del curso
             */
            Label lblCod = new Label();
            lblCod.BackColor = Color.FromArgb(0, 0, 90);
            lblCod.Font = new Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCod.ForeColor = Color.White;
            lblCod.Location = new Point(69, 54 + altura);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(92, 25);
            lblCod.Text = curso.codigo.ToString();
            lblCod.Visible = true;
            panelContenedorCursos.Controls.Add(lblCod);


            /*
             * lbl Nombre del curso
             */
            Label lblNombCur = new Label();
            lblNombCur.BackColor = Color.FromArgb(0, 0, 90);
            lblNombCur.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombCur.ForeColor = Color.White;
            lblNombCur.Location = new Point(167, 54 + altura);
            lblNombCur.Name = "lblNombCurso";
            lblNombCur.Size = new Size(300, 25);
            lblNombCur.Text = curso.nombre;
            panelContenedorCursos.Controls.Add(lblNombCur);


            // 
            // lbl Numero de temas
            //
            Label lblNumClassroom = new Label();
            lblNumClassroom.BackColor = Color.FromArgb(0, 0, 90);
            lblNumClassroom.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumClassroom.ForeColor = Color.White;
            lblNumClassroom.Location = new Point(218, 110 + altura);
            lblNumClassroom.Name = "lblNumClassrooms";
            lblNumClassroom.Size = new Size(300, 19);
            lblNumClassroom.Text = "0 Classrooms";
            //panelContenedorCursos.Controls.Add(lblNumClassroom);


            /*
             * Picture box Classrooms
             */
            PictureBox pbCursos = new PictureBox();
            pbCursos.BackColor = Color.FromArgb(0, 0, 90);
            pbCursos.Image = global::Sinapxon.Properties.Resources.baseline_collections_bookmark;
            pbCursos.Location = new Point(172, 101 + altura);
            pbCursos.Name = "pbCurso";
            pbCursos.Size = new Size(34, 36);
            pbCursos.SizeMode = PictureBoxSizeMode.AutoSize;
            //panelContenedorCursos.Controls.Add(pbCursos);

            /*
             * Boton ver curso
             */
            Button btnVerCurs = new Button();

            btnVerCurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnVerCurs.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnVerCurs.FlatAppearance.BorderSize = 0;
            btnVerCurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerCurs.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerCurs.ForeColor = System.Drawing.Color.Black;
            btnVerCurs.Location = new System.Drawing.Point(636, 74 + altura);
            btnVerCurs.Name = "btnIrCurso";
            btnVerCurs.Size = new System.Drawing.Size(182, 49);
            btnVerCurs.Text = "Ver curso";
            btnVerCurs.UseVisualStyleBackColor = false;
            //btnVerCurs.Click += new System.EventHandler(this.BtnVerCurso_Click);
            btnVerCurs.Click += new System.EventHandler((sender, e) => this.BtnVerCurso_Click(sender, e, curso));
            panelContenedorCursos.Controls.Add(btnVerCurs);

            /*
             * Picture box azul
             */
            PictureBox boxBase = new PictureBox();
            boxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            boxBase.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            boxBase.Location = new Point(11, 15 + altura);
            boxBase.Name = "pictureBoxBlue";
            boxBase.Size = new Size(852, 164);
            boxBase.SizeMode = PictureBoxSizeMode.StretchImage;
            boxBase.BackColor = Color.FromArgb(130, 130, 130);
            panelContenedorCursos.Controls.Add(boxBase);

            altura = altura + boxAltura;
        }

        private void BtnVerCurso_Click(object sender, EventArgs e, Alumno.curso curso)
        {
            ALUMNO_CursoInfo.cursoInfo = curso;
            frmExplorarCurso formExplorarCurso = new frmExplorarCurso();
            _padre.openChildForm_withoutClosing(formExplorarCurso);
        }
    }

    public static class ALUMNO_CursoInfo
    {
        public static Alumno.curso cursoInfo;
    }
}
