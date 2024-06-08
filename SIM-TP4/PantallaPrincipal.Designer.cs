namespace SIM_TP4
{
    partial class PantallaPrincipal
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chckbNuevoServicio = new System.Windows.Forms.CheckBox();
            this.gbNormativas = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLambdaNormativas = new System.Windows.Forms.TextBox();
            this.txtEmpleadosNormativas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbObras = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLambdaObras = new System.Windows.Forms.TextBox();
            this.txtEmpleadosObras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPlanos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLambdaPlanos = new System.Windows.Forms.TextBox();
            this.txtEmpleadosPlanos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLambdaPermisos = new System.Windows.Forms.TextBox();
            this.txtEmpleadosPermisos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gbSimulacion = new System.Windows.Forms.GroupBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtSimulaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.gbNormativas.SuspendLayout();
            this.gbObras.SuspendLayout();
            this.gbPlanos.SuspendLayout();
            this.gbPermisos.SuspendLayout();
            this.gbSimulacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Location = new System.Drawing.Point(731, 481);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(151, 38);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // chckbNuevoServicio
            // 
            this.chckbNuevoServicio.AutoSize = true;
            this.chckbNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chckbNuevoServicio.ForeColor = System.Drawing.Color.Silver;
            this.chckbNuevoServicio.Location = new System.Drawing.Point(503, 157);
            this.chckbNuevoServicio.Name = "chckbNuevoServicio";
            this.chckbNuevoServicio.Size = new System.Drawing.Size(331, 24);
            this.chckbNuevoServicio.TabIndex = 10;
            this.chckbNuevoServicio.Text = "Simular servicio adicional de Obras";
            this.chckbNuevoServicio.UseVisualStyleBackColor = true;
            // 
            // gbNormativas
            // 
            this.gbNormativas.Controls.Add(this.label9);
            this.gbNormativas.Controls.Add(this.txtLambdaNormativas);
            this.gbNormativas.Controls.Add(this.txtEmpleadosNormativas);
            this.gbNormativas.Controls.Add(this.label10);
            this.gbNormativas.Controls.Add(this.label11);
            this.gbNormativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbNormativas.ForeColor = System.Drawing.Color.Silver;
            this.gbNormativas.Location = new System.Drawing.Point(12, 400);
            this.gbNormativas.Name = "gbNormativas";
            this.gbNormativas.Size = new System.Drawing.Size(438, 119);
            this.gbNormativas.TabIndex = 9;
            this.gbNormativas.TabStop = false;
            this.gbNormativas.Text = "Normativas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "clientes por hora.";
            // 
            // txtLambdaNormativas
            // 
            this.txtLambdaNormativas.Location = new System.Drawing.Point(183, 68);
            this.txtLambdaNormativas.Name = "txtLambdaNormativas";
            this.txtLambdaNormativas.Size = new System.Drawing.Size(72, 26);
            this.txtLambdaNormativas.TabIndex = 8;
            this.txtLambdaNormativas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambdaNormativas_KeyPress);
            // 
            // txtEmpleadosNormativas
            // 
            this.txtEmpleadosNormativas.Location = new System.Drawing.Point(251, 25);
            this.txtEmpleadosNormativas.Name = "txtEmpleadosNormativas";
            this.txtEmpleadosNormativas.Size = new System.Drawing.Size(100, 26);
            this.txtEmpleadosNormativas.TabIndex = 7;
            this.txtEmpleadosNormativas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpladosNormativas_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tasa de Atencion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Cantidad de empleados:";
            // 
            // gbObras
            // 
            this.gbObras.Controls.Add(this.label6);
            this.gbObras.Controls.Add(this.txtLambdaObras);
            this.gbObras.Controls.Add(this.txtEmpleadosObras);
            this.gbObras.Controls.Add(this.label7);
            this.gbObras.Controls.Add(this.label8);
            this.gbObras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbObras.ForeColor = System.Drawing.Color.Silver;
            this.gbObras.Location = new System.Drawing.Point(12, 272);
            this.gbObras.Name = "gbObras";
            this.gbObras.Size = new System.Drawing.Size(438, 122);
            this.gbObras.TabIndex = 8;
            this.gbObras.TabStop = false;
            this.gbObras.Text = "Obras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "clientes por hora.";
            // 
            // txtLambdaObras
            // 
            this.txtLambdaObras.Location = new System.Drawing.Point(183, 68);
            this.txtLambdaObras.Name = "txtLambdaObras";
            this.txtLambdaObras.Size = new System.Drawing.Size(72, 26);
            this.txtLambdaObras.TabIndex = 8;
            this.txtLambdaObras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambdaObras_KeyPress);
            // 
            // txtEmpleadosObras
            // 
            this.txtEmpleadosObras.Location = new System.Drawing.Point(251, 25);
            this.txtEmpleadosObras.Name = "txtEmpleadosObras";
            this.txtEmpleadosObras.Size = new System.Drawing.Size(100, 26);
            this.txtEmpleadosObras.TabIndex = 7;
            this.txtEmpleadosObras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpladosObras_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tasa de Atencion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad de empleados:";
            // 
            // gbPlanos
            // 
            this.gbPlanos.Controls.Add(this.label3);
            this.gbPlanos.Controls.Add(this.txtLambdaPlanos);
            this.gbPlanos.Controls.Add(this.txtEmpleadosPlanos);
            this.gbPlanos.Controls.Add(this.label4);
            this.gbPlanos.Controls.Add(this.label5);
            this.gbPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPlanos.ForeColor = System.Drawing.Color.Silver;
            this.gbPlanos.Location = new System.Drawing.Point(12, 146);
            this.gbPlanos.Name = "gbPlanos";
            this.gbPlanos.Size = new System.Drawing.Size(438, 120);
            this.gbPlanos.TabIndex = 7;
            this.gbPlanos.TabStop = false;
            this.gbPlanos.Text = "Planos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "clientes por hora.";
            // 
            // txtLambdaPlanos
            // 
            this.txtLambdaPlanos.Location = new System.Drawing.Point(183, 68);
            this.txtLambdaPlanos.Name = "txtLambdaPlanos";
            this.txtLambdaPlanos.Size = new System.Drawing.Size(72, 26);
            this.txtLambdaPlanos.TabIndex = 8;
            this.txtLambdaPlanos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambdaPlanos_KeyPress);
            // 
            // txtEmpleadosPlanos
            // 
            this.txtEmpleadosPlanos.Location = new System.Drawing.Point(251, 25);
            this.txtEmpleadosPlanos.Name = "txtEmpleadosPlanos";
            this.txtEmpleadosPlanos.Size = new System.Drawing.Size(100, 26);
            this.txtEmpleadosPlanos.TabIndex = 7;
            this.txtEmpleadosPlanos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpladosPlanos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tasa de Atencion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad de empleados:";
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.label2);
            this.gbPermisos.Controls.Add(this.txtLambdaPermisos);
            this.gbPermisos.Controls.Add(this.txtEmpleadosPermisos);
            this.gbPermisos.Controls.Add(this.label1);
            this.gbPermisos.Controls.Add(this.lbl1);
            this.gbPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPermisos.ForeColor = System.Drawing.Color.Silver;
            this.gbPermisos.Location = new System.Drawing.Point(12, 12);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(438, 128);
            this.gbPermisos.TabIndex = 6;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "clientes por hora.";
            // 
            // txtLambdaPermisos
            // 
            this.txtLambdaPermisos.Location = new System.Drawing.Point(183, 77);
            this.txtLambdaPermisos.Name = "txtLambdaPermisos";
            this.txtLambdaPermisos.Size = new System.Drawing.Size(72, 26);
            this.txtLambdaPermisos.TabIndex = 3;
            this.txtLambdaPermisos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLmbdaPermisos_KeyPress);
            // 
            // txtEmpleadosPermisos
            // 
            this.txtEmpleadosPermisos.Location = new System.Drawing.Point(251, 34);
            this.txtEmpleadosPermisos.Name = "txtEmpleadosPermisos";
            this.txtEmpleadosPermisos.Size = new System.Drawing.Size(100, 26);
            this.txtEmpleadosPermisos.TabIndex = 2;
            this.txtEmpleadosPermisos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpladosPermisos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tasa de Atencion:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(211, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Cantidad de empleados:";
            // 
            // gbSimulacion
            // 
            this.gbSimulacion.Controls.Add(this.txtDesde);
            this.gbSimulacion.Controls.Add(this.txtSimulaciones);
            this.gbSimulacion.Controls.Add(this.label13);
            this.gbSimulacion.Controls.Add(this.label14);
            this.gbSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbSimulacion.ForeColor = System.Drawing.Color.Silver;
            this.gbSimulacion.Location = new System.Drawing.Point(503, 12);
            this.gbSimulacion.Name = "gbSimulacion";
            this.gbSimulacion.Size = new System.Drawing.Size(379, 128);
            this.gbSimulacion.TabIndex = 12;
            this.gbSimulacion.TabStop = false;
            this.gbSimulacion.Text = "Simulacion";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(181, 77);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(72, 26);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Location = new System.Drawing.Point(256, 34);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(100, 26);
            this.txtSimulaciones.TabIndex = 2;
            this.txtSimulaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSimulaciones_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "visualizar Desde:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cantidad de simulaciones:";
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDefault.Location = new System.Drawing.Point(574, 481);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(151, 38);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(913, 542);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.gbSimulacion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.chckbNuevoServicio);
            this.Controls.Add(this.gbNormativas);
            this.Controls.Add(this.gbObras);
            this.Controls.Add(this.gbPlanos);
            this.Controls.Add(this.gbPermisos);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficina de Permisos de Construccion";
            this.gbNormativas.ResumeLayout(false);
            this.gbNormativas.PerformLayout();
            this.gbObras.ResumeLayout(false);
            this.gbObras.PerformLayout();
            this.gbPlanos.ResumeLayout(false);
            this.gbPlanos.PerformLayout();
            this.gbPermisos.ResumeLayout(false);
            this.gbPermisos.PerformLayout();
            this.gbSimulacion.ResumeLayout(false);
            this.gbSimulacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chckbNuevoServicio;
        private System.Windows.Forms.GroupBox gbNormativas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLambdaNormativas;
        private System.Windows.Forms.TextBox txtEmpleadosNormativas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbObras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLambdaObras;
        private System.Windows.Forms.TextBox txtEmpleadosObras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbPlanos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLambdaPlanos;
        private System.Windows.Forms.TextBox txtEmpleadosPlanos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLambdaPermisos;
        private System.Windows.Forms.TextBox txtEmpleadosPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox gbSimulacion;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDefault;
    }
}

