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
    public partial class frmConfirmarIngresoClassroom : Form
    {
        private Alumno.AlumnoServicesClient DBController = new AlumnoServicesClient();

        public frmConfirmarIngresoClassroom()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(Login.LoginInfo.pswrd == txtPassword.Text)
            {
                DBController.insertarAlumnoAlClassroom(Login.LoginInfo.persona.codigo, Explorar_classroomInfo.classroom.codigo);
                MessageBox.Show("Ingreso satisfactorio, ingrese a sus classroom", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
