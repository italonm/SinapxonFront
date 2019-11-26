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
    public partial class frmVerSolicitudes : Form
    {
        Profesor.ProfesorServicesClient DBController = new Profesor.ProfesorServicesClient();
        private BindingList<Profesor.solicitudClassroom> solicitudClassroom;
        private int altura = 0;

        public frmVerSolicitudes()
        {
            InitializeComponent();
            cbEstado.Items.Add("");
            cbEstado.Items.Add("Aprobado");
            cbEstado.Items.Add("Pendiente");
            cbEstado.Items.Add("Denegado");
            solicitudClassroom = new BindingList<Profesor.solicitudClassroom>(DBController.listarSolicitudesClassroomxProfesor(LoginInfo.persona.codigo));
            foreach (Profesor.solicitudClassroom obj in solicitudClassroom)
            {
                crearClassroom(obj);
            }

        }

        private void crearClassroom(solicitudClassroom obj)
        {
            // 
            // lblCodigoCurso
            // 
            Label lblCodigoCurso = new Label();
            lblCodigoCurso.AutoSize = true;
            lblCodigoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCodigoCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigoCurso.ForeColor = System.Drawing.Color.White;
            lblCodigoCurso.Location = new System.Drawing.Point(200, 54 + altura);
            lblCodigoCurso.Name = "lblCodigoCurso";
            lblCodigoCurso.Size = new System.Drawing.Size(89, 25);
            lblCodigoCurso.Text = obj.curso.codigo;
            lblCodigoCurso.BringToFront();
            panelContenedor.Controls.Add(lblCodigoCurso);
            // 
            // lblNombreCurso
            // 
            Label lblNombreCurso = new Label();
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreCurso.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreCurso.ForeColor = System.Drawing.Color.White;
            lblNombreCurso.Location = new System.Drawing.Point(300, 54 + altura);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new System.Drawing.Size(181, 25);
            lblNombreCurso.Text = obj.curso.nombre;
            lblNombreCurso.BringToFront();
            panelContenedor.Controls.Add(lblNombreCurso);
            // 
            // lblEstado
            // 
            Label lblCodigoClassroom = new Label();
            lblCodigoClassroom.AutoSize = true;
            lblCodigoClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblCodigoClassroom.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodigoClassroom.ForeColor = System.Drawing.Color.White;
            lblCodigoClassroom.Location = new System.Drawing.Point(70, 54 + altura);
            lblCodigoClassroom.Name = "lblEstado";
            lblCodigoClassroom.Size = new System.Drawing.Size(90, 25);
            lblCodigoClassroom.Text = (obj.estado==2) ? "Pendiente" : (obj.estado==1? "Aprobado":"Desaprobado");
            lblCodigoClassroom.BringToFront();
            panelContenedor.Controls.Add(lblCodigoClassroom);
            // 
            // lblPeriodo
            // 
            Label lblPeriodo = new Label();
            lblPeriodo.AutoSize = true;
            lblPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblPeriodo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPeriodo.ForeColor = System.Drawing.Color.White;
            lblPeriodo.Location = new System.Drawing.Point(500, 109 + altura);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(90, 25);
            lblPeriodo.Text = "Periodo solicitado: "+obj.periodo.nombre;
            lblPeriodo.BringToFront();
            panelContenedor.Controls.Add(lblPeriodo);

            // 
            // lblFecha
            // 
            Label lblFecha = new Label();
            lblFecha.AutoSize = true;
            lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblFecha.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFecha.ForeColor = System.Drawing.Color.White;
            lblFecha.Location = new System.Drawing.Point(70, 109 + altura);
            lblFecha.Name = "lblEstado";
            lblFecha.Size = new System.Drawing.Size(90, 25);
            lblFecha.Text = "Fecha de solicitud: "+obj.fecha.ToString("dd-MM-yyyy");
            lblFecha.BringToFront();
            panelContenedor.Controls.Add(lblFecha);
            // 
            // pbBlueBox
            // 
            PictureBox pbBlueBox = new PictureBox();
            pbBlueBox.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBlueBox.Location = new System.Drawing.Point(11, 15 + altura);
            pbBlueBox.Name = "pbBlueBox";
            pbBlueBox.Size = new System.Drawing.Size(830, 164);
            pbBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBlueBox.TabStop = false;
            panelContenedor.Controls.Add(pbBlueBox);

            altura = altura + 164;
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            altura = 0;
            panelContenedor.Controls.Clear();
            solicitudClassroom = new BindingList<Profesor.solicitudClassroom>(DBController.listarSolicitudesClassroomxProfesor(LoginInfo.persona.codigo));
            foreach (Profesor.solicitudClassroom obj in solicitudClassroom)
            {
                if (cbEstado.Text=="Pendiente" && obj.estado==2) crearClassroom(obj);
                else if(cbEstado.Text == "Denegado" && obj.estado == 0) crearClassroom(obj);
                else if(cbEstado.Text == "Aprobado" && obj.estado == 1) crearClassroom(obj);
            }
        }
    }
}
