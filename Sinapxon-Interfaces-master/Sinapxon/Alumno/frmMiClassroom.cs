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
    public partial class frmMiClassroom : Form
    {
        private int alturaTemas = 0, boxAltura = 119;
        private int alturaEvaluaciones = 0;
        private frmAlumno _padre = null;

        private Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();

        //private BindingList<Alumno.tema> temas;
        BindingList<Alumno.temaXClassroom> temaXC;
        private BindingList<Alumno.evaluacion> evaluaciones;

        public frmMiClassroom()
        {
            InitializeComponent();
            //agregarTema();
            //agregarTema();
            //agregarTema();
            //agregarEvaluacion();
        }

        public frmMiClassroom(frmAlumno padre)
        {
            _padre = padre;
            InitializeComponent();
            lblTitulo.Text = ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo.ToString() +"    "+ ALUMNO_ClassroomSeleccionado.classroomSeleccionado.curso.nombre;
            
            //Listar temas
            try
            {
                temaXC = new BindingList<temaXClassroom>(DBController.listarTemaxClassroom(ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo));
            }
            catch (Exception)
            {
                temaXC = new BindingList<temaXClassroom>();
                
            }
            foreach(Alumno.temaXClassroom temaXClassroom in temaXC)
            {
                agregarTema(temaXClassroom);
            }

            //Listar evaluaciones
            try
            {
                evaluaciones = new BindingList<evaluacion>(DBController.listarEvaluacionesXClassroom(ALUMNO_ClassroomSeleccionado.classroomSeleccionado.codigo));
            }
            catch (Exception)
            {
                evaluaciones = new BindingList<evaluacion>();
            }
            foreach(Alumno.evaluacion eval in evaluaciones)
            {
                agregarEvaluacion(eval);
            }

            
            //agregarTema();
            //agregarTema();
            //agregarTema();
            //agregarEvaluacion();
        }

        private void agregarTema(Alumno.temaXClassroom tma)
        {
            //
            // lbl Nombre del tema
            //
            Label lblNombTema = new Label();
            lblNombTema.BackColor = Color.FromArgb(0, 0, 90);
            lblNombTema.Font = new Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombTema.ForeColor = Color.White;
            lblNombTema.Location = new Point(76, 66 + alturaTemas);
            lblNombTema.Name = "lblNombreTema";
            lblNombTema.Size = new Size(300, 23);
            //lblNombTema.Text = "Nombre del tema";
            lblNombTema.Text = tma.nombre;
            lblNombTema.Visible = true;
            tabPageTema.Controls.Add(lblNombTema);

            //
            // Picture box Check
            //
            PictureBox pbCheck = new PictureBox();
            pbCheck.Location = new Point(814, 59 + alturaTemas);
            pbCheck.BackColor = Color.FromArgb(0, 0, 90);
            pbCheck.Size = new Size(36, 36);
            pbCheck.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCheck.Image = global::Sinapxon.Properties.Resources.baseline_check_circle_white_18dp;
            pbCheck.Name = "pbChecked";
            tabPageTema.Controls.Add(pbCheck);

            //
            // Picture box Cross
            //
            PictureBox pbCross = new PictureBox();
            pbCross.Location = new Point(814, 59 + alturaEvaluaciones);
            pbCross.BackColor = Color.FromArgb(0, 0, 90);
            pbCross.Size = new Size(36, 36);
            pbCross.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCross.Image = global::Sinapxon.Properties.Resources.baseline_cancel_white_18dp;
            pbCross.Name = "pbCrossed";
            pbCross.Visible = false;
            tabPageEvaluacion.Controls.Add(pbCross);

            //
            // btn Ver tema
            //
            Button btnEntrarTema = new Button();
            btnEntrarTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnEntrarTema.BackColor = System.Drawing.Color.FromArgb(103, 70, 195);
            btnEntrarTema.FlatAppearance.BorderSize = 0;
            btnEntrarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrarTema.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEntrarTema.ForeColor = System.Drawing.Color.White;
            btnEntrarTema.Location = new System.Drawing.Point(645, 59 + alturaTemas);
            btnEntrarTema.Name = "btnVerTema";
            btnEntrarTema.Size = new System.Drawing.Size(122, 36);
            btnEntrarTema.Text = "Ver tema";
            btnEntrarTema.UseVisualStyleBackColor = false;
            //btnEntrarTema.Click += new System.EventHandler(this.btnVerTema_Click);
            btnEntrarTema.Click += new System.EventHandler((sender, e) => this.btnVerTema_Click(sender, e, tma));
            tabPageTema.Controls.Add(btnEntrarTema);

            //
            // Picture box Contenedor azul
            //
            PictureBox boxBase = new PictureBox();
            boxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            boxBase.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            boxBase.Location = new Point(6, 18 + alturaTemas);
            boxBase.Name = "pictureBoxBlue";
            boxBase.Size = new Size(888, 119);
            boxBase.SizeMode = PictureBoxSizeMode.StretchImage;
            boxBase.BackColor = Color.FromArgb(130, 130, 130);
            tabPageTema.Controls.Add(boxBase);

            alturaTemas = alturaTemas + boxAltura;
        }

        private void agregarEvaluacion(Alumno.evaluacion eval)
        {
            //
            // lbl Nombre de la evaluacion
            //
            Label lblNombEval = new Label();
            lblNombEval.BackColor = Color.FromArgb(0, 0, 90);
            lblNombEval.Font = new Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombEval.ForeColor = Color.White;
            lblNombEval.Location = new Point(76, 66 + alturaEvaluaciones);
            lblNombEval.Name = "lblNombreEvaluacion";
            lblNombEval.Size = new Size(300, 23);
            //lblNombEval.Text = "Nombre de la evaluación";
            lblNombEval.Text = eval.nombre;
            lblNombEval.Visible = true;
            tabPageEvaluacion.Controls.Add(lblNombEval);

            //
            // Picture box Check
            //
            PictureBox pbCheck = new PictureBox();
            pbCheck.Location = new Point(814, 59 + alturaEvaluaciones);
            pbCheck.BackColor = Color.FromArgb(0, 0, 90);
            pbCheck.Size = new Size(36, 36);
            pbCheck.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCheck.Image = global::Sinapxon.Properties.Resources.baseline_check_circle_white_18dp;
            pbCheck.Name = "pbChecked";
            pbCheck.Visible = false;
            tabPageEvaluacion.Controls.Add(pbCheck);

            //
            // Picture box Cross
            //
            PictureBox pbCross = new PictureBox();
            pbCross.Location = new Point(814, 59 + alturaEvaluaciones);
            pbCross.BackColor = Color.FromArgb(0, 0, 90);
            pbCross.Size = new Size(36, 36);
            pbCross.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCross.Image = global::Sinapxon.Properties.Resources.baseline_cancel_white_18dp;
            pbCross.Name = "pbCrossed";
            tabPageEvaluacion.Controls.Add(pbCross);

            //
            // btn Ver Evaluacion
            //
            Button btnEntrarEval = new Button();
            btnEntrarEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnEntrarEval.BackColor = System.Drawing.Color.FromArgb(103, 70, 195);
            btnEntrarEval.FlatAppearance.BorderSize = 0;
            btnEntrarEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrarEval.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEntrarEval.ForeColor = System.Drawing.Color.White;
            btnEntrarEval.Location = new System.Drawing.Point(625, 59 + alturaEvaluaciones);
            btnEntrarEval.Name = "btnVerEvaluacion";
            btnEntrarEval.Size = new System.Drawing.Size(150, 36);
            btnEntrarEval.Text = "Ver evaluación";
            btnEntrarEval.UseVisualStyleBackColor = false;
            //btnEntrarEval.Click += new System.EventHandler(this.btnVerEvaluacion_Click);
            btnEntrarEval.Click += new System.EventHandler((sender, e) => this.btnVerEvaluacion_Click(sender, e, eval));
            tabPageEvaluacion.Controls.Add(btnEntrarEval);

            //
            // Picture box Contenedor azul
            //
            PictureBox boxBase = new PictureBox();
            boxBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            boxBase.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            boxBase.Location = new Point(6, 18 + alturaEvaluaciones);
            boxBase.Name = "pictureBoxBlue";
            boxBase.Size = new Size(888, 119);
            boxBase.SizeMode = PictureBoxSizeMode.StretchImage;
            boxBase.BackColor = Color.FromArgb(130, 130, 130);
            tabPageEvaluacion.Controls.Add(boxBase);

            alturaEvaluaciones = alturaEvaluaciones + boxAltura;
        }

        //====================================================================================================

        private void btnVerEvaluacion_Click(object sender, EventArgs e, Alumno.evaluacion eval)
        {
            ALUMNO_evaluacionInfo.evaluacion = eval;
            frmEvaluacion formEvaluacion = new frmEvaluacion();
            //formEvaluacion.Visible = true;
            _padre.openChildForm_withoutClosing(formEvaluacion);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerTema_Click(object sender, EventArgs e, Alumno.temaXClassroom txc)
        {
            ALUMNO_temaInfo.tema_X_classroom = txc;
            frmTema formTema = new frmTema();
            //formTema.Visible = true;
            _padre.openChildForm_withoutClosing(formTema);
        }
    }

    public static class ALUMNO_temaInfo
    {
        public static Alumno.temaXClassroom tema_X_classroom;
    }

    public static class ALUMNO_evaluacionInfo
    {
        public static Alumno.evaluacion evaluacion;
    }
}
