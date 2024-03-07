
namespace laboratorioRepaso1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.dataGridViewReporteSueldos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalcularSueldos = new System.Windows.Forms.Button();
            this.comboBoxEmpleadoEspecifico = new System.Windows.Forms.ComboBox();
            this.labelBuscarEmpleado = new System.Windows.Forms.Label();
            this.buttonBuscarEmpleado = new System.Windows.Forms.Button();
            this.textBoxEspecifico = new System.Windows.Forms.TextBox();
            this.labelEmpleadoEspecifico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteSueldos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(32, 37);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(346, 237);
            this.dataGridViewEmpleado.TabIndex = 0;
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(408, 37);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(315, 237);
            this.dataGridViewAsistencia.TabIndex = 1;
            // 
            // buttonLeer
            // 
            this.buttonLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeer.Location = new System.Drawing.Point(32, 340);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(162, 37);
            this.buttonLeer.TabIndex = 2;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // dataGridViewReporteSueldos
            // 
            this.dataGridViewReporteSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporteSueldos.Location = new System.Drawing.Point(750, 37);
            this.dataGridViewReporteSueldos.Name = "dataGridViewReporteSueldos";
            this.dataGridViewReporteSueldos.Size = new System.Drawing.Size(347, 237);
            this.dataGridViewReporteSueldos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asistencias de empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sueldos mensuales";
            // 
            // buttonCalcularSueldos
            // 
            this.buttonCalcularSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularSueldos.Location = new System.Drawing.Point(216, 340);
            this.buttonCalcularSueldos.Name = "buttonCalcularSueldos";
            this.buttonCalcularSueldos.Size = new System.Drawing.Size(162, 37);
            this.buttonCalcularSueldos.TabIndex = 7;
            this.buttonCalcularSueldos.Text = "Calcular sueldos";
            this.buttonCalcularSueldos.UseVisualStyleBackColor = true;
            this.buttonCalcularSueldos.Click += new System.EventHandler(this.buttonCalcularSueldos_Click);
            // 
            // comboBoxEmpleadoEspecifico
            // 
            this.comboBoxEmpleadoEspecifico.FormattingEnabled = true;
            this.comboBoxEmpleadoEspecifico.Location = new System.Drawing.Point(411, 355);
            this.comboBoxEmpleadoEspecifico.Name = "comboBoxEmpleadoEspecifico";
            this.comboBoxEmpleadoEspecifico.Size = new System.Drawing.Size(250, 21);
            this.comboBoxEmpleadoEspecifico.TabIndex = 9;
            this.comboBoxEmpleadoEspecifico.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleadoEspecifico_SelectedIndexChanged);
            this.comboBoxEmpleadoEspecifico.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmpleadoEspecifico_SelectionChangeCommitted);
            // 
            // labelBuscarEmpleado
            // 
            this.labelBuscarEmpleado.AutoSize = true;
            this.labelBuscarEmpleado.Location = new System.Drawing.Point(408, 334);
            this.labelBuscarEmpleado.Name = "labelBuscarEmpleado";
            this.labelBuscarEmpleado.Size = new System.Drawing.Size(138, 13);
            this.labelBuscarEmpleado.TabIndex = 10;
            this.labelBuscarEmpleado.Text = "Ver empleado en especifico";
            // 
            // buttonBuscarEmpleado
            // 
            this.buttonBuscarEmpleado.Location = new System.Drawing.Point(408, 392);
            this.buttonBuscarEmpleado.Name = "buttonBuscarEmpleado";
            this.buttonBuscarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarEmpleado.TabIndex = 11;
            this.buttonBuscarEmpleado.Text = "Buscar";
            this.buttonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarEmpleado.Click += new System.EventHandler(this.buttonBuscarEmpleado_Click);
            // 
            // textBoxEspecifico
            // 
            this.textBoxEspecifico.Location = new System.Drawing.Point(750, 356);
            this.textBoxEspecifico.Name = "textBoxEspecifico";
            this.textBoxEspecifico.Size = new System.Drawing.Size(347, 20);
            this.textBoxEspecifico.TabIndex = 12;
            // 
            // labelEmpleadoEspecifico
            // 
            this.labelEmpleadoEspecifico.AutoSize = true;
            this.labelEmpleadoEspecifico.Location = new System.Drawing.Point(750, 334);
            this.labelEmpleadoEspecifico.Name = "labelEmpleadoEspecifico";
            this.labelEmpleadoEspecifico.Size = new System.Drawing.Size(155, 13);
            this.labelEmpleadoEspecifico.TabIndex = 13;
            this.labelEmpleadoEspecifico.Text = "Datos del empleado especifico:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.labelEmpleadoEspecifico);
            this.Controls.Add(this.textBoxEspecifico);
            this.Controls.Add(this.buttonBuscarEmpleado);
            this.Controls.Add(this.labelBuscarEmpleado);
            this.Controls.Add(this.comboBoxEmpleadoEspecifico);
            this.Controls.Add(this.buttonCalcularSueldos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReporteSueldos);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteSueldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button buttonLeer;
        private System.Windows.Forms.DataGridView dataGridViewReporteSueldos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalcularSueldos;
        private System.Windows.Forms.ComboBox comboBoxEmpleadoEspecifico;
        private System.Windows.Forms.Label labelBuscarEmpleado;
        private System.Windows.Forms.Button buttonBuscarEmpleado;
        private System.Windows.Forms.TextBox textBoxEspecifico;
        private System.Windows.Forms.Label labelEmpleadoEspecifico;
    }
}

