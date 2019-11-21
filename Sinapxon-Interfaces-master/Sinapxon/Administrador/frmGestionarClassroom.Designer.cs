﻿namespace Sinapxon.Administrador
{
    partial class frmGestionarClassroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSolicitudesPendientes = new System.Windows.Forms.DataGridView();
            this.ID_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInspeccionarSolicitud = new System.Windows.Forms.Button();
            this.dgvSolicitudesAprobadas = new System.Windows.Forms.DataGridView();
            this.ID_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesDesaprobadas = new System.Windows.Forms.DataGridView();
            this.ID_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_curso_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_curso_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor_desaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSolicitudes = new System.Windows.Forms.TabControl();
            this.tabPageSolPendientes = new System.Windows.Forms.TabPage();
            this.tabPageSolAprobadas = new System.Windows.Forms.TabPage();
            this.tabPageSolDesaprobadas = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesDesaprobadas)).BeginInit();
            this.tabControlSolicitudes.SuspendLayout();
            this.tabPageSolPendientes.SuspendLayout();
            this.tabPageSolAprobadas.SuspendLayout();
            this.tabPageSolDesaprobadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes de classrooms";
            // 
            // dgvSolicitudesPendientes
            // 
            this.dgvSolicitudesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_solicitud,
            this.Codigo_curso,
            this.Nombre_curso,
            this.Profesor});
            this.dgvSolicitudesPendientes.Location = new System.Drawing.Point(22, 76);
            this.dgvSolicitudesPendientes.Name = "dgvSolicitudesPendientes";
            this.dgvSolicitudesPendientes.Size = new System.Drawing.Size(845, 400);
            this.dgvSolicitudesPendientes.TabIndex = 1;
            this.dgvSolicitudesPendientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesPendientes_CellFormatting);
            // 
            // ID_solicitud
            // 
            this.ID_solicitud.HeaderText = "ID solicitud";
            this.ID_solicitud.Name = "ID_solicitud";
            this.ID_solicitud.Width = 80;
            // 
            // Codigo_curso
            // 
            this.Codigo_curso.HeaderText = "Codigo Curso";
            this.Codigo_curso.Name = "Codigo_curso";
            // 
            // Nombre_curso
            // 
            this.Nombre_curso.HeaderText = "Nombre del curso";
            this.Nombre_curso.Name = "Nombre_curso";
            this.Nombre_curso.Width = 250;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            // 
            // btnInspeccionarSolicitud
            // 
            this.btnInspeccionarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnInspeccionarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnInspeccionarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccionarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccionarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnInspeccionarSolicitud.Location = new System.Drawing.Point(568, 18);
            this.btnInspeccionarSolicitud.Name = "btnInspeccionarSolicitud";
            this.btnInspeccionarSolicitud.Size = new System.Drawing.Size(298, 46);
            this.btnInspeccionarSolicitud.TabIndex = 2;
            this.btnInspeccionarSolicitud.Text = "Inspeccionar solicitud";
            this.btnInspeccionarSolicitud.UseVisualStyleBackColor = false;
            this.btnInspeccionarSolicitud.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSolicitudesAprobadas
            // 
            this.dgvSolicitudesAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesAprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_aprobado,
            this.Codigo_curso_aprobado,
            this.Nombre_curso_aprobado,
            this.Profesor_aprobado});
            this.dgvSolicitudesAprobadas.Location = new System.Drawing.Point(27, 39);
            this.dgvSolicitudesAprobadas.Name = "dgvSolicitudesAprobadas";
            this.dgvSolicitudesAprobadas.Size = new System.Drawing.Size(845, 440);
            this.dgvSolicitudesAprobadas.TabIndex = 3;
            this.dgvSolicitudesAprobadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesAprobadas_CellFormatting);
            // 
            // ID_aprobado
            // 
            this.ID_aprobado.HeaderText = "ID solicitud";
            this.ID_aprobado.Name = "ID_aprobado";
            this.ID_aprobado.Width = 80;
            // 
            // Codigo_curso_aprobado
            // 
            this.Codigo_curso_aprobado.HeaderText = "Codigo del curso";
            this.Codigo_curso_aprobado.Name = "Codigo_curso_aprobado";
            // 
            // Nombre_curso_aprobado
            // 
            this.Nombre_curso_aprobado.HeaderText = "Nombre del curso";
            this.Nombre_curso_aprobado.Name = "Nombre_curso_aprobado";
            this.Nombre_curso_aprobado.Width = 250;
            // 
            // Profesor_aprobado
            // 
            this.Profesor_aprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor_aprobado.HeaderText = "Profesor";
            this.Profesor_aprobado.Name = "Profesor_aprobado";
            // 
            // dgvSolicitudesDesaprobadas
            // 
            this.dgvSolicitudesDesaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesDesaprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_desaprobado,
            this.Codigo_curso_desaprobado,
            this.Nombre_curso_desaprobado,
            this.Profesor_desaprobado});
            this.dgvSolicitudesDesaprobadas.Location = new System.Drawing.Point(27, 39);
            this.dgvSolicitudesDesaprobadas.Name = "dgvSolicitudesDesaprobadas";
            this.dgvSolicitudesDesaprobadas.Size = new System.Drawing.Size(845, 440);
            this.dgvSolicitudesDesaprobadas.TabIndex = 4;
            this.dgvSolicitudesDesaprobadas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSolicitudesDesaprobadas_CellFormatting);
            // 
            // ID_desaprobado
            // 
            this.ID_desaprobado.HeaderText = "ID Solicitud";
            this.ID_desaprobado.Name = "ID_desaprobado";
            this.ID_desaprobado.Width = 80;
            // 
            // Codigo_curso_desaprobado
            // 
            this.Codigo_curso_desaprobado.HeaderText = "Codigo del curso";
            this.Codigo_curso_desaprobado.Name = "Codigo_curso_desaprobado";
            // 
            // Nombre_curso_desaprobado
            // 
            this.Nombre_curso_desaprobado.HeaderText = "Nombre del curso";
            this.Nombre_curso_desaprobado.Name = "Nombre_curso_desaprobado";
            this.Nombre_curso_desaprobado.Width = 250;
            // 
            // Profesor_desaprobado
            // 
            this.Profesor_desaprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor_desaprobado.HeaderText = "Profesor";
            this.Profesor_desaprobado.Name = "Profesor_desaprobado";
            // 
            // tabControlSolicitudes
            // 
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolPendientes);
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolAprobadas);
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolDesaprobadas);
            this.tabControlSolicitudes.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSolicitudes.Location = new System.Drawing.Point(34, 136);
            this.tabControlSolicitudes.Name = "tabControlSolicitudes";
            this.tabControlSolicitudes.SelectedIndex = 0;
            this.tabControlSolicitudes.Size = new System.Drawing.Size(907, 533);
            this.tabControlSolicitudes.TabIndex = 5;
            // 
            // tabPageSolPendientes
            // 
            this.tabPageSolPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageSolPendientes.Controls.Add(this.dgvSolicitudesPendientes);
            this.tabPageSolPendientes.Controls.Add(this.btnInspeccionarSolicitud);
            this.tabPageSolPendientes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolPendientes.Location = new System.Drawing.Point(4, 32);
            this.tabPageSolPendientes.Name = "tabPageSolPendientes";
            this.tabPageSolPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolPendientes.Size = new System.Drawing.Size(899, 497);
            this.tabPageSolPendientes.TabIndex = 0;
            this.tabPageSolPendientes.Text = "Pendientes";
            // 
            // tabPageSolAprobadas
            // 
            this.tabPageSolAprobadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageSolAprobadas.Controls.Add(this.dgvSolicitudesAprobadas);
            this.tabPageSolAprobadas.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolAprobadas.Location = new System.Drawing.Point(4, 32);
            this.tabPageSolAprobadas.Name = "tabPageSolAprobadas";
            this.tabPageSolAprobadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolAprobadas.Size = new System.Drawing.Size(899, 497);
            this.tabPageSolAprobadas.TabIndex = 1;
            this.tabPageSolAprobadas.Text = "Aprobadas";
            // 
            // tabPageSolDesaprobadas
            // 
            this.tabPageSolDesaprobadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageSolDesaprobadas.Controls.Add(this.dgvSolicitudesDesaprobadas);
            this.tabPageSolDesaprobadas.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSolDesaprobadas.Location = new System.Drawing.Point(4, 32);
            this.tabPageSolDesaprobadas.Name = "tabPageSolDesaprobadas";
            this.tabPageSolDesaprobadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolDesaprobadas.Size = new System.Drawing.Size(899, 497);
            this.tabPageSolDesaprobadas.TabIndex = 2;
            this.tabPageSolDesaprobadas.Text = "Desaprobadas";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Sinapxon.Properties.Resources.round_arrow_left_white_36dp;
            this.btnAtras.Location = new System.Drawing.Point(34, 41);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // frmGestionarClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.tabControlSolicitudes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarClassroom";
            this.Text = "frmGestionarClassroom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesDesaprobadas)).EndInit();
            this.tabControlSolicitudes.ResumeLayout(false);
            this.tabPageSolPendientes.ResumeLayout(false);
            this.tabPageSolAprobadas.ResumeLayout(false);
            this.tabPageSolDesaprobadas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSolicitudesPendientes;
        private System.Windows.Forms.Button btnInspeccionarSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridView dgvSolicitudesAprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso_aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_aprobado;
        private System.Windows.Forms.DataGridView dgvSolicitudesDesaprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_curso_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_curso_desaprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor_desaprobado;
        private System.Windows.Forms.TabControl tabControlSolicitudes;
        private System.Windows.Forms.TabPage tabPageSolPendientes;
        private System.Windows.Forms.TabPage tabPageSolAprobadas;
        private System.Windows.Forms.TabPage tabPageSolDesaprobadas;
        private System.Windows.Forms.Button btnAtras;
    }
}