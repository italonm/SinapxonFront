namespace Sinapxon.Alumno
{
    partial class frmMiClassroom
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTema = new System.Windows.Forms.TabPage();
            this.tabPageEvaluacion = new System.Windows.Forms.TabPage();
            this.tabPageNotas = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabPageNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Nombre del curso";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageTema);
            this.tabControl.Controls.Add(this.tabPageEvaluacion);
            this.tabControl.Controls.Add(this.tabPageNotas);
            this.tabControl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(22, 71);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(80, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 580);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageTema
            // 
            this.tabPageTema.AutoScroll = true;
            this.tabPageTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageTema.Location = new System.Drawing.Point(4, 32);
            this.tabPageTema.Name = "tabPageTema";
            this.tabPageTema.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTema.Size = new System.Drawing.Size(912, 544);
            this.tabPageTema.TabIndex = 0;
            this.tabPageTema.Text = "Temas";
            // 
            // tabPageEvaluacion
            // 
            this.tabPageEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageEvaluacion.Location = new System.Drawing.Point(4, 32);
            this.tabPageEvaluacion.Name = "tabPageEvaluacion";
            this.tabPageEvaluacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvaluacion.Size = new System.Drawing.Size(912, 544);
            this.tabPageEvaluacion.TabIndex = 1;
            this.tabPageEvaluacion.Text = "Evaluaciones";
            // 
            // tabPageNotas
            // 
            this.tabPageNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPageNotas.Controls.Add(this.chart1);
            this.tabPageNotas.Location = new System.Drawing.Point(4, 32);
            this.tabPageNotas.Name = "tabPageNotas";
            this.tabPageNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotas.Size = new System.Drawing.Size(912, 544);
            this.tabPageNotas.TabIndex = 2;
            this.tabPageNotas.Text = "Notas";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(92, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(721, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frmMiClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMiClassroom";
            this.Text = "frmMiClassroom";
            this.tabControl.ResumeLayout(false);
            this.tabPageNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTema;
        private System.Windows.Forms.TabPage tabPageEvaluacion;
        private System.Windows.Forms.TabPage tabPageNotas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}