﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinapxon.Administrador
{
    public partial class frmAgregarRequisito : Form
    {
        private Administrador.curso curSeleccionado;
        BindingList<Administrador.curso> backup;
        BindingList<Administrador.curso> toShow;
        BindingList<Administrador.curso> cursos2;
        BindingList<Administrador.curso> cursos3;
        BindingList<Administrador.curso> req_de_curso;
        Administrador.curso cur;
        int busq = 0;
        private int index = 0;

        Administrador.AdministradorServicesClient DBController = new Administrador.AdministradorServicesClient();

        public curso CurSeleccionado { get => curSeleccionado; set => curSeleccionado = value; }

        public frmAgregarRequisito(String codigoCur, BindingList<Administrador.curso> cursos)
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            BindingList<Administrador.curso> temp = new BindingList<Administrador.curso>();

            bool isReq = false;
            //BindingList<Administrador.curso> cursos2 = new BindingList<Administrador.curso>();
            //buscarCursosReq(cursos2, codigoCur);
            BindingList<Administrador.curso> cursosFinal =  new BindingList<Administrador.curso>();
            BindingList<Administrador.curso> cursos2 = cursos;

            foreach (Administrador.curso curY in cursos2)
            {
                buscarCursosReq(cursosFinal, curY.codigo);
            }

            foreach (Administrador.curso curZ in cursos2)
            {
                cursosFinal.Add(curZ);
            }

            try
            {
                cursos3 = new BindingList<Administrador.curso>(DBController.listarCursosXRequsitos(codigoCur));
            }
            catch
            {
                cursos3 = new BindingList<Administrador.curso>();
            }
            if (cursos3.Count() != 0)
            {
                foreach (Administrador.curso curX in cursos3)
                {
                    cursosFinal.Add(curX);
                }
            }


            foreach (Administrador.curso cur in (BindingList<Administrador.curso>)dgvCursos.DataSource)
            {
                isReq = false;
                foreach (Administrador.curso cursoReq in cursosFinal)
                {
                    if (string.Equals(cur.codigo, cursoReq.codigo))
                    {
                        isReq = true;
                        break;
                    }
                }

                if (!isReq)
                {
                    if (string.Equals(cur.codigo, codigoCur))
                    {
                        continue;
                    }
                    temp.Add(cur);
                }
            }




            index += 1;
            dgvCursos.AutoGenerateColumns = false;


            backup = temp;
            BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
            for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
            {
                bdl.Add(backup[n_]);
            }
            dgvCursos.DataSource = bdl;
            BindingList<Administrador.curso> toShow = new BindingList<Administrador.curso>();
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buscarCursosReq(BindingList<Administrador.curso> curs, String codigo)
        //esto devuelve el arbol de requisitos de un cursp
        {
            try
            {
                req_de_curso = new BindingList<Administrador.curso>(DBController.listarRequisitos(codigo));
            }
            catch
            {
                req_de_curso = null;
            }

            if (req_de_curso != null)
            {
                foreach (Administrador.curso cur in req_de_curso)
                {
                    curs.Add(cur);
                    buscarCursosReq(curs, cur.codigo);
                }
            }
            else
            {
                return;
            }
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Administrador.curso cursoFila = (Administrador.curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (cursoFila != null)
            {
                dgvCursos.Rows[e.RowIndex].Cells[0].Value = cursoFila.codigo.ToString();
                dgvCursos.Rows[e.RowIndex].Cells[1].Value = cursoFila.nombre;
                dgvCursos.Rows[e.RowIndex].Cells[2].Value = cursoFila.descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                curSeleccionado = dgvCursos.CurrentRow.DataBoundItem as Administrador.curso;
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un requisito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toShow = new BindingList<Administrador.curso>();
            index = 0;

            //Hago búsqueda por código y nombre del curso
            foreach (Administrador.curso cur in backup)
            {
                String chi = cur.codigo + " " + cur.nombre;
                String nombreAux = txtNombre.Text.ToUpper();
                String codigoAux = txtCodigo.Text.ToUpper();

                String nombRev = cur.nombre.ToUpper();
                String codRev = cur.codigo.ToUpper();

                if (nombRev.Contains(nombreAux) && codRev.Contains(codigoAux))
                {
                    toShow.Add(cur);
                }
            }

            if (txtNombre.Text == "" & txtCodigo.Text == "")
            {
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; n_ < index * 20; n_++)
                {
                    bdl.Add(backup[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
            else
            {
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                busq = 1;
                for (int n_ = (index - 1) * 20; (n_ < toShow.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(toShow[n_]);
                }
                dgvCursos.DataSource = bdl;

                if (toShow.Count() == 0)
                {
                    if (txtNombre.Text != "" && txtCodigo.Text == "")
                    {
                        MessageBox.Show("No se encontraron resultados con el nombre ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text == "" && txtCodigo.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados con el código ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtNombre.Text != "" && txtCodigo.Text != "")
                    {
                        MessageBox.Show("No se encontraron resultados, ingrese datos válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.curso> aux = new BindingList<Administrador.curso>();
            backup = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index > 1)
            {
                index -= 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; (n_ >= 0) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BindingList<Administrador.curso> aux = new BindingList<Administrador.curso>();
            backup = new BindingList<Administrador.curso>(DBController.listarCursosSin(""));
            if (busq != 1) aux = backup;
            else aux = toShow;
            if (index * 20 <= aux.Count() - 1)
            {
                index += 1;
                BindingList<Administrador.curso> bdl = new BindingList<Administrador.curso>();
                for (int n_ = (index - 1) * 20; (n_ < aux.Count()) && (n_ < index * 20); n_++)
                {
                    bdl.Add(aux[n_]);
                }
                dgvCursos.DataSource = bdl;
            }
        }
    }
}
