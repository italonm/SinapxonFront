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
    public partial class frmExplorarCurso : Form
    {
        private int altura = 0, boxAltura = 113;
        public frmExplorarCurso()
        {
            InitializeComponent();
            generarBloqueClassroom();
            generarBloqueClassroom();
        }


        private void generarBloqueClassroom()
        {
            // 
            // lblNombreProfesor
            // 
            Label lblNombreProfesor = new Label();
            lblNombreProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNombreProfesor.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreProfesor.ForeColor = System.Drawing.Color.White;
            lblNombreProfesor.Location = new System.Drawing.Point(62, 83+altura);
            lblNombreProfesor.Name = "lblNombreProfesor";
            lblNombreProfesor.Size = new System.Drawing.Size(187, 23);
            lblNombreProfesor.Text = "Nombre del profesor";
            panelClassrooms.Controls.Add(lblNombreProfesor);

            // 
            // pbUsuarios
            // 
            PictureBox pbUsuarios = new PictureBox();
            pbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            pbUsuarios.Image = global::Sinapxon.Properties.Resources.baseline_group_white_18dp;
            pbUsuarios.Location = new System.Drawing.Point(66, 117+altura);
            pbUsuarios.Name = "pbUsuarios";
            pbUsuarios.Size = new System.Drawing.Size(36, 36);
            pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pbUsuarios.TabStop = false;
            panelClassrooms.Controls.Add(pbUsuarios);

            // 
            // lblNumeroAlumnos
            // 
            Label lblNumeroAlumnos = new Label();
            lblNumeroAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            lblNumeroAlumnos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumeroAlumnos.ForeColor = System.Drawing.Color.White;
            lblNumeroAlumnos.Location = new System.Drawing.Point(109, 126+altura);
            lblNumeroAlumnos.Name = "lblNumeroAlumnos";
            lblNumeroAlumnos.Size = new System.Drawing.Size(85, 19);
            lblNumeroAlumnos.Text = "0 Alumnos";
            panelClassrooms.Controls.Add(lblNumeroAlumnos);

            //
            // btnVerClassroom
            //
            Button btnVerClassroom = new Button();
            btnVerClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            btnVerClassroom.FlatAppearance.BorderSize = 0;
            btnVerClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerClassroom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVerClassroom.ForeColor = System.Drawing.Color.White;
            btnVerClassroom.Location = new System.Drawing.Point(358, 92+altura);
            btnVerClassroom.Name = "btnVisualizarClassroom";
            btnVerClassroom.Size = new System.Drawing.Size(125, 41);
            btnVerClassroom.Text = "Ver classroom";
            btnVerClassroom.UseVisualStyleBackColor = false;
            btnVerClassroom.Click += new System.EventHandler(this.BtnVerClassroom_Click);
            panelClassrooms.Controls.Add(btnVerClassroom);

            // 
            // pictureBox Bloque azul
            // 
            PictureBox pbBloque = new PictureBox();
            pbBloque.Image = global::Sinapxon.Properties.Resources.Barra_PD;
            pbBloque.Location = new System.Drawing.Point(22, 56+altura);
            pbBloque.Name = "pbBloque";
            pbBloque.Size = new System.Drawing.Size(500, 113);
            pbBloque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBloque.TabStop = false;
            panelClassrooms.Controls.Add(pbBloque);

            altura = altura + boxAltura;
        }

        private void BtnVerClassroom_Click(object sender, EventArgs e)
        {
            frmExplorarClassroom formExplorarClassroom = new frmExplorarClassroom();
            formExplorarClassroom.Visible = true;
        }
    }
}
