﻿using Sinapxon.Login;
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
    public partial class frmAlumno : Form
    {
        private Form formularioActivo = null;
        public frmAlumno()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            lblNombreUsuario.Text = LoginInfo.persona.nombre;
        }

        public void openChildForm(Form formularioHijo)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void BtnMisClassrooms_Click(object sender, EventArgs e)
        {
            frmMisClassrooms misClassrooms = new frmMisClassrooms(this);
            openChildForm(misClassrooms);
        }

        private void BtnExplorar_Click(object sender, EventArgs e)
        {
            frmExplorarCursos explorarCursos = new frmExplorarCursos(this);
            openChildForm(explorarCursos);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }
    }
}
