using Sinapxon.Login;
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
    public partial class frmMisClassrooms : Form
    {
        private bool _irClassroom = false;
        private int altura = 0, boxAltura = 174;
        private frmAlumno _padre = null;

        private BindingList<Alumno.classroom> classrooms;
        private BindingList<Alumno.periodo> periodos;

        private Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();
        

        public bool IrClassroom { get => _irClassroom; set => _irClassroom = value; }

        public frmMisClassrooms()
        {
            InitializeComponent();
            this.BringToFront();

            classrooms = new BindingList<classroom>(DBController.listarClassroomxAlumno(LoginInfo.persona.codigo));

            foreach (Alumno.classroom obj in classrooms)
            {
                crearElemento(obj);
            }
        }

        public frmMisClassrooms(frmAlumno padre)
        {
            InitializeComponent();
            this.BringToFront();
            _padre = padre;

            lblSincursos.Hide();
            pbSinCursos.Hide();

            periodos = new BindingList<Alumno.periodo>(DBController.listarPeriodos());
            cbPerido.DataSource = periodos;
            cbPerido.DisplayMember = "nombre";
            cbPerido.ValueMember = "id_periodo";

            try
            {
                classrooms = new BindingList<classroom>(DBController.listarClassroomxAlumno(LoginInfo.persona.codigo));
            }
            catch (ArgumentNullException)
            {
                lblSincursos.Show();
                pbSinCursos.Show();
            }

            if (classrooms != null)
            {
                foreach (Alumno.classroom obj in classrooms)
                    crearElemento(obj);
            }
        }

        public void crearElemento(Alumno.classroom clsroom)
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
            lblCod.Text = clsroom.codigo.ToString();
            lblCod.Visible = true;
            panelContenido.Controls.Add(lblCod);

            /*
             * lbl Nombre del profesor
             */
            Label lblNombreProf = new Label();
            lblNombreProf.BackColor = Color.FromArgb(0, 0, 90);
            lblNombreProf.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProf.ForeColor = Color.White;
            lblNombreProf.Location = new Point(168, 85 + altura);
            lblNombreProf.Name = "lblNombProfesor";
            lblNombreProf.Size = new Size(300, 25);
            lblNombreProf.Text = clsroom.profesor.nombre;
            lblNombreProf.BringToFront();
            panelContenido.Controls.Add(lblNombreProf);

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
            lblNombCur.Text = clsroom.curso.nombre;
            panelContenido.Controls.Add(lblNombCur);

            // 
            // lbl Numero de evaluaciones
            // 
            Label lblNumEval = new Label();
            lblNumEval.BackColor = Color.FromArgb(0, 0, 90);
            lblNumEval.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumEval.ForeColor = Color.White;
            lblNumEval.Location = new Point(386, 124 + altura);
            lblNumEval.Name = "lblNumEval";
            lblNumEval.Size = new Size(116, 19);
            lblNumEval.Text = "0 Evaluaciones";
            //panelContenido.Controls.Add(lblNumEval);

            // 
            // lbl Numero de temas
            //
            Label lblNumTema = new Label();
            lblNumTema.BackColor = Color.FromArgb(0, 0, 90);
            lblNumTema.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTema.ForeColor = Color.White;
            lblNumTema.Location = new Point(218, 124 + altura);
            lblNumTema.Name = "lblNumTema";
            lblNumTema.Size = new Size(70, 19);
            lblNumTema.Text = "0 Temas";
            //panelContenido.Controls.Add(lblNumTema);

            /*
             * Picture box Evaluacion
             */
            PictureBox pbEvaluacion = new PictureBox();
            pbEvaluacion.Location = new Point(344, 115 + altura);
            pbEvaluacion.BackColor = Color.FromArgb(0, 0, 90);
            pbEvaluacion.Size = new Size(36, 36);
            pbEvaluacion.SizeMode = PictureBoxSizeMode.AutoSize;
            pbEvaluacion.Image = global::Sinapxon.Properties.Resources.round_assignment;
            pbEvaluacion.Name = "pbEvaluacion";
            //panelContenido.Controls.Add(pbEvaluacion);

            /*
             * Picture box Tema
             */
            PictureBox pbTemas = new PictureBox();
            pbTemas.BackColor = Color.FromArgb(0, 0, 90);
            pbTemas.Image = global::Sinapxon.Properties.Resources.round_description;
            pbTemas.Location = new Point(172, 115+altura);
            pbTemas.Name = "pbTema";
            pbTemas.Size = new Size(34, 36);
            pbTemas.SizeMode = PictureBoxSizeMode.AutoSize;
            //panelContenido.Controls.Add(pbTemas);

            /*
             * Boton Ir a classroom
             */
            Button btnIrClassrom = new Button();

            btnIrClassrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnIrClassrom.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnIrClassrom.FlatAppearance.BorderSize = 0;
            btnIrClassrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIrClassrom.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnIrClassrom.ForeColor = System.Drawing.Color.Black;
            btnIrClassrom.Location = new System.Drawing.Point(636, 74+altura);
            btnIrClassrom.Name = "btnIrClassrom";
            btnIrClassrom.Size = new System.Drawing.Size(182, 49);
            btnIrClassrom.Text = "Ir al classroom";
            btnIrClassrom.UseVisualStyleBackColor = false;
            //btnIrClassrom.Click += new System.EventHandler(this.BtnIrClassroom_Click);
            //btnIrClassrom.Click += new System.EventHandler((sender, e) => this.BtnIrClassroom_Click(sender, e, clsroom));
            btnIrClassrom.Click += new System.EventHandler((sender, e) => this.BtnIrClassroom_Click(sender, e, clsroom));
            panelContenido.Controls.Add(btnIrClassrom);

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
            panelContenido.Controls.Add(boxBase);
            
            altura = altura + boxAltura;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            //txtPeridoID.Text = ((Alumno.periodo)cbPerido.SelectedItem).id_periodo.ToString() + " - "+ LoginInfo.persona.codigo;

            panelContenido.Controls.Clear();
            try
            {
                classrooms = new BindingList<Alumno.classroom>
                (DBController.listarClassroomsXAlumno_X_Periodo(LoginInfo.persona.codigo,
                    ((Alumno.periodo)cbPerido.SelectedItem).id_periodo)
                );
                altura = 0;
            }
            catch (Exception)
            {
                classrooms = null;
            }
            if (classrooms != null)
            {
                foreach (Alumno.classroom obj in classrooms)
                    crearElemento(obj);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIrClassroom_Click(object sender, EventArgs e, Alumno.classroom classrum)
        {
            ALUMNO_ClassroomSeleccionado.classroomSeleccionado = classrum;
            frmMiClassroom formMiClassroom = new frmMiClassroom(_padre);
            _padre.openChildForm_withoutClosing(formMiClassroom);
        }
    }

    public static class ALUMNO_ClassroomSeleccionado
    {
        public static Alumno.classroom classroomSeleccionado;
    }

}
