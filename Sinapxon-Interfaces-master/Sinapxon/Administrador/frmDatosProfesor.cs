using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Administrador
{
    public partial class frmDatosProfesor : Form
    {
        private frmAdministrador _padre = null;
        private int tipo;
        private int tipoX;
        private Administrador.profesor profesor;
        private BindingList<Administrador.profesor> listado;
        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();
        private Estado estadoProfesor;

        //==============================================================================================================================================================
        //AL SELECCIONAR UN PROFESOR
        public frmDatosProfesor(Administrador.profesor profesorselec, frmAdministrador padre)
        {
            //Inicializo Formulario
            tipo = 1;
            tipoX = 1;
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = "Editar Profesor";

            //Listado paises
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";

            txtIdProfesor.Text = profesorselec.codigo;
            txtNombre.Text = profesorselec.nombre;
            txtApMat.Text = profesorselec.apellidoMaterno;
            txtApPat.Text = profesorselec.apellidoPaterno;
            txtDNI.Text = profesorselec.dni;
            txtCorreo.Text = profesorselec.correo;
            cboPais.Text = profesorselec.pais.nombre;
            txtGrado.Text = profesorselec.gradoInstruccion;
            txtTelf.Text = profesorselec.telefono;
            txtNickname.Text = profesorselec.nickname;
            txtPassword.Text = profesorselec.password;
            txtAInt.Text = profesorselec.areaInteres;
            dtFechNac.Text = profesorselec.fecha.ToShortDateString();
            if (profesorselec.estado == 0)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = true;
            }
            if (profesorselec.estado == 1)
            {
                rbActivo.Checked = true;
                rbBloqueado.Checked = false;
                rbInactivo.Checked = false;
            }
            if (profesorselec.estado == 2)
            {
                rbActivo.Checked = false;
                rbBloqueado.Checked = true;
                rbInactivo.Checked = false;
            }
            this.profesor = new Administrador.profesor();
            this.profesor = profesorselec;
            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //AL CREAR UN PROFESOR
        public frmDatosProfesor(frmAdministrador padre)
        {
            tipo = 2;
            tipoX = 2;
            //Inicializo Formulario
            InitializeComponent();
            this.Padre = padre;
            lblTitulo.Text = "Añadir Alumno";
            this.profesor = new Administrador.profesor();

            //Listado paises
            BindingList<Administrador.pais> paises = new BindingList<Administrador.pais>(DBController.listarPaises());
            cboPais.DataSource = paises;
            cboPais.DisplayMember = "nombre";
            cboPais.ValueMember = "id_Pais";
            

            estadoComponentes(Estado.Inicial);
        }

        //==============================================================================================================================================================
        //LIMPIEZA COMPONENTES
        public void limpiarComponentes()
        {
            txtIdProfesor.Text = "";
            txtNombre.Text = "";
            txtApMat.Text = "";
            txtApPat.Text = "";
            txtDNI.Text = "";
            txtCorreo.Text = "";
            cboPais.SelectedIndex = -1;
            txtGrado.Text = "";
            txtTelf.Text = "";
            txtNickname.Text = "";
            txtPassword.Text = "";
            txtAInt.Text = "";
            dtFechNac.Value = DateTime.Today;
            rbActivo.Checked = false;
            rbBloqueado.Checked = false;
            rbInactivo.Checked = false;
        }

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
                    txtAInt.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtGrado.Enabled = false;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    btnGenerarContr.Enabled = false;
                    btnMostrar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbEstado.Enabled = true;
                    txtAInt.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApPat.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtGrado.Enabled = true;
                    txtIdProfesor.Enabled = true;
                    txtNickname.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelf.Enabled = true;
                    dtFechNac.Enabled = true;
                    cboPais.Enabled = true;
                    btnGenerarContr.Enabled = true;
                    btnMostrar.Enabled = true;
                    break;
                case Estado.Actualizar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    txtAInt.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtGrado.Enabled = false;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    btnGenerarContr.Enabled = false;
                    btnMostrar.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRegresar.Enabled = true;
                    btnCancelar.Enabled = false;
                    gbEstado.Enabled = false;
                    txtAInt.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApPat.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtGrado.Enabled = false;
                    txtIdProfesor.Enabled = false;
                    txtNickname.Enabled = false;
                    txtNombre.Enabled = false;
                    txtPassword.Enabled = false;
                    txtTelf.Enabled = false;
                    dtFechNac.Enabled = false;
                    cboPais.Enabled = false;
                    btnGenerarContr.Enabled = false;
                    btnMostrar.Enabled = false;
                    break;
            }
        }

        //==============================================================================================================================================================
        public frmAdministrador Padre { get => _padre; set => _padre = value; }

        //==============================================================================================================================================================
        //NUEVO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            limpiarComponentes();
            profesor = new Administrador.profesor();
            estadoProfesor = Estado.Nuevo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProfesor.Text == "")
            {
                MessageBox.Show("Debe asignar un ID al profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    int id_al = Int32.Parse(txtIdProfesor.Text);
                }
                catch
                {
                    MessageBox.Show("El código no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Int32.Parse(txtIdProfesor.Text) > 999999 || 100000 > Int32.Parse(txtIdProfesor.Text))
                {
                    MessageBox.Show("El código no es válido/n Ingrese número de 6 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtDNI.Text == "")
                    {
                        MessageBox.Show("Debe colocar el DNI del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("Debe colocar el nombre del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                                    MessageBox.Show("El correo electrónico no es válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El correo electrónico no es válido/n Ingrese números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }

                                            if (txtNickname.Text == "")
                                            {
                                                MessageBox.Show("Debe ingresar un nickname", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            String nombaux = txtNombre.Text.ToLower();
            nombaux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombaux);
            String apPataux = txtApPat.Text.ToLower();
            apPataux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apPataux);
            String apMataux = txtApMat.Text.ToLower();
            apMataux = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apMataux);

            String correob = txtCorreo.Text.ToLower();
            String cb = txtIdProfesor.Text;
            String dnib = txtDNI.Text;
            String nickb = txtNickname.Text.ToLower();
            listado = new BindingList<Administrador.profesor>(DBController.listarProfesores(""));

            foreach (Administrador.profesor profx in listado)
            {

                String correol = profx.correo.ToLower();
                String cl = profx.codigo;
                String dnil = profx.dni;
                String nickl = profx.nickname.ToLower();
                if (tipoX == 2)
                {
                    if (string.Equals(cl, cb))
                    {
                        MessageBox.Show("Ya existe un profesor registrado con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (string.Equals(dnil, dnib))
                        {
                            MessageBox.Show("Ya existe un profesor registrado con el DNI ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (string.Equals(correob, correol))
                            {
                                MessageBox.Show("Ya existe un profesor registrado con el correo ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (string.Equals(nickb, nickl))
                                {
                                    MessageBox.Show("Ya existe un profesor registrado con el nickname ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("Ya existe un profesor registrado con el DNI ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (string.Equals(correob, correol))
                            {
                                MessageBox.Show("Ya existe un profesor registrado con el correo ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                if (string.Equals(nickb, nickl))
                                {
                                    MessageBox.Show("Ya existe un profesor registrado con el nickname ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            profesor = new Administrador.profesor();
            profesor.codigo = txtIdProfesor.Text;
            profesor.nombre = nombaux;
            profesor.apellidoMaterno = apMataux;
            profesor.apellidoPaterno = apPataux;
            profesor.dni = txtDNI.Text;
            profesor.correo = correob;
            profesor.pais = (Administrador.pais)cboPais.SelectedItem;
            profesor.gradoInstruccion = txtGrado.Text;
            profesor.telefono = txtTelf.Text;
            profesor.nickname = txtNickname.Text;
            profesor.password = txtPassword.Text;
            profesor.areaInteres = txtAInt.Text;
            profesor.password = txtPassword.Text;
            profesor.fecha = dtFechNac.Value;
            profesor.fechaSpecified = true;
            if (rbActivo.Checked == true)
            {
                profesor.estado = 1;
            }
            if (rbBloqueado.Checked == true)
            {
                profesor.estado = 2;
            }
            if (rbInactivo.Checked == true)
            {
                profesor.estado = 0;
            }

            //GUARDAR NUEVO ALUMNO
            if (estadoProfesor == Estado.Nuevo)
            {
                DBController.insertarProfesor(profesor);
                MessageBox.Show("El profesor se ha registrado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipoX = 1;
            }
            //ACTUALIZAR ALUMNO SELECCIONADO
            else if (estadoProfesor == Estado.Modificar)
            {
                DBController.actualizarProfesor(profesor);
                MessageBox.Show("El profesor se ha sido actualizado con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            estadoComponentes(Estado.Actualizar);
        }

        //==============================================================================================================================================================
        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar este profesor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                DBController.eliminarProfesor(profesor.codigo);
                MessageBox.Show("El profesor ha sido eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoComponentes(Estado.Inicial);
            }
            frmGestionarProfesor formGestionarProfesor = new frmGestionarProfesor(this.Padre);
            _padre.openChildForm(formGestionarProfesor);
        }

        //==============================================================================================================================================================
        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            if (tipoX == 1) txtIdProfesor.Enabled = false;
            btnEliminar.Enabled = true;
            estadoProfesor= Estado.Modificar;
        }

        //==============================================================================================================================================================
        //GENERAR CONTRASEÑA
        private void btnGenerarContr_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GenerarNuevaContrasenia();
            txtPassword.UseSystemPasswordChar = true;
            EnviarCorreo(txtPassword.Text, txtNickname.Text ,txtCorreo.Text);
        }

        public string GenerarNuevaContrasenia()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            //int nuevaCotrasenia = rd.Next(100000, 9999999);
            String nuevaCotrasenia;
            nuevaCotrasenia = Guid.NewGuid().ToString("d").Substring(1, 8);
            //return nuevaCotrasenia.ToString();
            return nuevaCotrasenia;
        }

        //==============================================================================================================================================================
        //REGRESAR
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionarProfesor formGestionarProfesor = new frmGestionarProfesor(this.Padre);
            _padre.openChildForm(formGestionarProfesor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        //==============================================================================================================================================================
        //CANCELAR
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            btnModificar.Enabled = true;
            if (tipo == 1)
            {
                btnNuevo.Enabled = false;
            }
        }

        private void EnviarCorreo(string contrasenaNueva,string nickname, string correo)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("sinapxonsac.peru@gmail.com");
            mail.To.Add(correo);
            mail.Subject = "Nueva contraseña Sinapxon";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "Su datos de acceso son: \r\n Contraseña:" + contrasenaNueva + "\r\n" + "Usuario:"+ nickname;
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sinapxonsac.peru@gmail.com", "lp2grupoB");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Correo enviado, revise su bandeja de entrada");
        }
    }
}
