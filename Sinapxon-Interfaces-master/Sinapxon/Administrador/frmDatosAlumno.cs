using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Administrador
{
    public partial class frmDatosAlumno : Form
    {
        private frmAdministrador _padre = null;
        private int tipo;
        private int tipoX;
        private Administrador.alumno alumno;
        private BindingList<Administrador.alumno> listado;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoAlumno;

        //==============================================================================================================================================================
        //AL SELECCIONAR UN ALUMNO
        public frmDatosAlumno(Administrador.alumno alumnoselec, frmAdministrador padre)
        {
            //Inicializo Formulario
            tipo = 1;
            tipoX = 1;
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = "Editar Alumno";

            //Listado paises
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";
            txtIdAlumno.Text = alumnoselec.codigo;
            txtNombre.Text = alumnoselec.nombre;
            txtApMat.Text = alumnoselec.apellidoMaterno;
            txtApPat.Text = alumnoselec.apellidoPaterno;
            txtDNI.Text = alumnoselec.dni;
            txtCorreo.Text = alumnoselec.correo;
            cboPais.Text = alumnoselec.pais.nombre;
            txtTelf.Text = alumnoselec.telefono;
            txtNickname.Text = alumnoselec.nickname;
            txtPassword.Text = alumnoselec.password;
            dtFechNac.Text = alumnoselec.fecha.ToShortDateString();
            if (alumnoselec.estado == 0)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = true;
            }
            if (alumnoselec.estado == 1)
            {
                rbActivo.Checked = true;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = false;
            }
            if (alumnoselec.estado == 2)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = true;
                rbInactivo.Checked = false;
            }
            this.alumno = new Administrador.alumno();
            this.alumno = alumnoselec;
            estadoComponentes(Estado.Actualizar);
        }


        //==============================================================================================================================================================
        //AL CREAR UN ALUMNO
        public frmDatosAlumno(frmAdministrador padre)
        {
            tipo = 2;
            tipoX = 2;
            //Inicializo Formulario
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = "Añadir Alumno";
            this.alumno = new Administrador.alumno();

            //Listado paises
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";

            estadoComponentes(Estado.Inicial);
        }



        //==============================================================================================================================================================
        //LIMPIEZA DE DATOS
        public void limpiarComponentes()
        {
            txtIdAlumno.Text = "";
            txtNombre.Text = "";
            txtApMat.Text = "";
            txtApPat.Text = "";
            txtDNI.Text = "";
            txtCorreo.Text = "";
            cboPais.SelectedIndex = -1;
            txtTelf.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
            dtFechNac.Value = DateTime.Today;
            rbActivo.Checked = false;
            rbBloqueado.Checked = false;
            rbInactivo.Checked = false;
        }

        //==============================================================================================================================================================
        //ESTADOS
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdAlumno.Enabled = true;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    dtFechNac.Enabled = true;
                    cboPais.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtIdAlumno.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    break;
            }
        }

        //==============================================================================================================================================================
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        //==============================================================================================================================================================
        //GUARDAR
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text == "")
            {
                MessageBox.Show("Debe asignar un ID al alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    int id_al = Int32.Parse(txtIdAlumno.Text);
                }
                catch
                {
                    MessageBox.Show("El código no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Int32.Parse(txtIdAlumno.Text) > 999999)
                {
                    MessageBox.Show("El código no es válido/n Ingrese 6 máximo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else {
                    if (txtDNI.Text == "")
                    {
                        MessageBox.Show("Debe colocar el DNI del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            int dni = Int32.Parse(txtDNI.Text);
                        }
                        catch
                        {
                            MessageBox.Show("El DNI no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (txtNombre.Text == "")
                        {
                            MessageBox.Show("Debe colocar el nombre del alumno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if ((txtApPat.Text == "") || (txtApMat.Text == ""))
                            {
                                MessageBox.Show("Debe completar los campos de apellidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                int dias = DateTime.Now.Date.Subtract(dtFechNac.Value.Date).Days;
                                int edad = dias / 365;

                                if (edad < 18)
                                {
                                    MessageBox.Show("No se puede registrar menores de edad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                {
                                    if (cboPais.Text == "")
                                    {
                                        MessageBox.Show("Debe elegir un país", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    else
                                    {
                                        if (txtTelf.Text != "")
                                        {
                                            try
                                            {
                                                int telf = Int32.Parse(txtTelf.Text);
                                            }
                                            catch
                                            {
                                                MessageBox.Show("El número telefónico no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (txtCorreo.Text == "")
                                            {
                                                MessageBox.Show("Debe ingresar un correo electrónico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                            else
                                            {
                                                String expresion;
                                                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                                                if (Regex.IsMatch(txtCorreo.Text, expresion))
                                                {
                                                    if (Regex.Replace(txtCorreo.Text, expresion, String.Empty).Length != 0)
                                                    {
                                                        MessageBox.Show("El correo electrónico no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("El correo electrónico no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            }
  

            String nombaux = txtNombre.Text.ToLower();
            nombaux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombaux);
            String apPataux = txtApPat.Text.ToLower();
            apPataux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apPataux);
            String apMataux = txtApMat.Text.ToLower();
            apMataux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apMataux);

            String correob = txtCorreo.Text.ToLower();
            String cb = txtIdAlumno.Text;
            String dnib = txtDNI.Text;
            String nickb = txtNickname.Text.ToLower();
            listado = new BindingList<Administrador.alumno>(DBController.listarAlumnos(""));

            foreach (Administrador.alumno alaux in listado)
            {
                    
                String correol = alaux.correo.ToLower();
                String cl = alaux.codigo;
                String dnil = alaux.dni;
                String nickl = alaux.nickname.ToLower();
                if (tipoX == 2)
                {
                    if (string.Equals(cl, cb))
                    {
                        MessageBox.Show("Ya existe un alumno registrado con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (string.Equals(dnil, dnib))
                        {
                            MessageBox.Show("Ya existe un alumno registrado con el DNI ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (string.Equals(correob, correol)){
                                MessageBox.Show("Ya existe un alumno registrado con el correo ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (string.Equals(nickb, nickl))
                                {
                                    MessageBox.Show("Ya existe un alumno registrado con el nickname ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    if (!string.Equals(cl, cb))
                    {
                        if (string.Equals(dnil, dnib))
                        {
                            MessageBox.Show("Ya existe un alumno registrado con el DNI ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (string.Equals(correob, correol))
                            {
                                MessageBox.Show("Ya existe un alumno registrado con el correo ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (string.Equals(nickb, nickl))
                                {
                                    MessageBox.Show("Ya existe un alumno registrado con el nickname ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }
                }
            }


            alumno = new Administrador.alumno();
            alumno.codigo = txtIdAlumno.Text;
            alumno.nombre = txtNombre.Text;
            alumno.apellidoMaterno = txtApMat.Text;
            alumno.apellidoPaterno = txtApPat.Text;
            alumno.dni = txtDNI.Text;
            alumno.correo = txtCorreo.Text;
            alumno.pais = (Administrador.pais)cboPais.SelectedItem;
            alumno.telefono = txtTelf.Text;
            alumno.nickname = txtNickname.Text;
            alumno.password = txtPassword.Text;
            alumno.fecha = dtFechNac.Value;
            alumno.fechaSpecified = true;
            if (rbActivo.Checked == true)
            {
                alumno.estado = 1;
            }
            if (rbBloqueado.Checked == true)
            {
                alumno.estado = 2;
            }
            if (rbInactivo.Checked == true)
            {
                alumno.estado = 0;
            }

            //GUARDAR NUEVO ALUMNO
            if (estadoAlumno == Estado.Nuevo)
            {
                DBController.insertarAlumno(alumno);
                MessageBox.Show("El alumno se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoX = 1;
            }
            //ACTUALIZAR ALUMNO SELECCIONADO
            else if (estadoAlumno == Estado.Modificar)
            {
                DBController.actualizarAlumno(alumno);
                MessageBox.Show("El alumno se ha sido actualizado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //NUEVO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            alumno = new Administrador.alumno();
            estadoAlumno = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        //==============================================================================================================================================================
        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este alumno?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarAlumno(alumno.codigo);
                MessageBox.Show("El alumno ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
            if (tipo == 2)
            {
                btnNuevo.Enabled = false;
            }
            limpiarComponentes();
        }

        //==============================================================================================================================================================
        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            if (tipoX==1)txtIdAlumno.Enabled = false;
            btnEliminar.Enabled = true;
            estadoAlumno = Estado.Modificar;
        }

        //==============================================================================================================================================================
        //CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            btnModificar.Enabled = true;
            if (tipo == 1)
            {
                btnNuevo.Enabled = false;
            }       
        }

        //==============================================================================================================================================================
        //GENERAR CONTRASEÑA
        private void btnGenerarContr_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GenerarNuevaContrasenia();
            txtPassword.UseSystemPasswordChar = true;
        }

        public string GenerarNuevaContrasenia() {
            Random rd = new Random(DateTime.Now.Millisecond);
            int nuevaCotrasenia = rd.Next(100000, 9999999);
            return nuevaCotrasenia.ToString();
        }

        //==============================================================================================================================================================
        //REGRESAR
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionarAlumno formGestionarAlumno = new frmGestionarAlumno(this.Padre);
            _padre.openChildForm(formGestionarAlumno);
        }

        //==============================================================================================================================================================
        //MOSTRAR CONTRASEÑA
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
