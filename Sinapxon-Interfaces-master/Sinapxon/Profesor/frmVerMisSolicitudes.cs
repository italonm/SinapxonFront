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

namespace Sinapxon.Profesor
{
    public partial class frmVerMisSolicitudes : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        private BindingList<Profesor.solicitudClassroom> solicitudes;
        private int altura = 0;
        public frmVerMisSolicitudes()
        {
            InitializeComponent();
            BindingList<string> estados = new BindingList<string>();
            estados.Add("Aprobados");
            estados.Add("Pendientes");
            estados.Add("Denegados");
            cbEstados.DataSource = estados;
            solicitudes = new BindingList<Profesor.solicitudClassroom>(DBController.listarSolicitudesClassroomxProfesor(LoginInfo.persona.codigo));
            foreach (Profesor.solicitudClassroom soli in solicitudes) {
                crearSolicitud(soli);
            }
        }

        private void crearSolicitud(solicitudClassroom soli)
        {
            // 
            // lblEstado
            // 
            Label lblEstado = new Label();
            lblEstado.AutoSize = true;
            lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblEstado.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEstado.ForeColor = System.Drawing.Color.White;
            lblEstado.Location = new System.Drawing.Point(30, 54 + altura);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(89, 25);
            lblEstado.Text = soli.estado==1? "PENDIENTE":"APROBADO";
            lblEstado.BringToFront();
            panel1.Controls.Add(lblEstado);
            // 
            // lblFecha
            // 
            Label lblFecha = new Label();
            lblFecha.AutoSize = true;
            lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblFecha.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.Location = new System.Drawing.Point(30, 100 + altura);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(89, 25);
            lblFecha.Text = (soli.fecha).ToString("dd-MM-yyyy");
            lblFecha.BringToFront();
            panel1.Controls.Add(lblFecha);
            // 
            // lblCodigoCurso
            // 
            Label lblCodigoCurso = new Label();
            lblCodigoCurso.AutoSize = true;
            lblCodigoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCodigoCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigoCurso.ForeColor = System.Drawing.Color.White;
            lblCodigoCurso.Location = new System.Drawing.Point(180, 54 + altura);
            lblCodigoCurso.Name = "lblCodigoCurso";
            lblCodigoCurso.Size = new System.Drawing.Size(89, 25);
            lblCodigoCurso.Text = soli.curso.codigo;
            lblCodigoCurso.BringToFront();
            panel1.Controls.Add(lblCodigoCurso);
            // 
            // lblNombreCurso
            // 
            Label lblNombreCurso = new Label();
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreCurso.ForeColor = System.Drawing.Color.White;
            lblNombreCurso.Location = new System.Drawing.Point(265, 54 + altura);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new System.Drawing.Size(181, 25);
            lblNombreCurso.Text = soli.curso.nombre;
            lblNombreCurso.BringToFront();
            panel1.Controls.Add(lblNombreCurso);
            // 
            // lblDescripcion
            // 
            Label lblDescripcion = new Label();
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblDescripcion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(180, 100 + altura);
            lblDescripcion.Name = "lblNombreCurso";
            lblDescripcion.Size = new System.Drawing.Size(181, 25);
            lblDescripcion.Text = soli.curso.nombre;
            lblDescripcion.BringToFront();
            panel1.Controls.Add(lblDescripcion);

            // 
            // pbBlueBox
            // 
            PictureBox pbBlueBox = new PictureBox();
            pbBlueBox.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBlueBox.Location = new System.Drawing.Point(11, 15 + altura);
            pbBlueBox.Name = "pbBlueBox";
            pbBlueBox.Size = new System.Drawing.Size(800, 164);
            pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBlueBox.TabStop = false;
            panel1.Controls.Add(pbBlueBox);
            altura = altura + 164;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
