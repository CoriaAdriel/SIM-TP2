namespace TP2_SIM
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreseDatos = new System.Windows.Forms.Label();
            this.cbDistribucion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbUniforme = new System.Windows.Forms.GroupBox();
            this.gbExponencial = new System.Windows.Forms.GroupBox();
            this.gbNormal = new System.Windows.Forms.GroupBox();
            this.cbIntervalos = new System.Windows.Forms.ComboBox();
            this.chartDistribucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.gbChi = new System.Windows.Forms.GroupBox();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.DesdeChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecObsChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecEspChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKS = new System.Windows.Forms.GroupBox();
            this.dgvKS = new System.Windows.Forms.DataGridView();
            this.DesdeKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecObsKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecEspKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.gbUniforme.SuspendLayout();
            this.gbExponencial.SuspendLayout();
            this.gbNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.gbChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.gbKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).BeginInit();
            this.gbIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el tamaño de la muestra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el tipo de distribucion:";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Location = new System.Drawing.Point(487, 9);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(214, 16);
            this.lblIngreseDatos.TabIndex = 2;
            this.lblIngreseDatos.Text = "Ingrese los parametos necesarios:";
            // 
            // cbDistribucion
            // 
            this.cbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistribucion.FormattingEnabled = true;
            this.cbDistribucion.Items.AddRange(new object[] {
            "Uniforme [a,b]",
            "Exponencial",
            "Normal"});
            this.cbDistribucion.Location = new System.Drawing.Point(243, 104);
            this.cbDistribucion.Name = "cbDistribucion";
            this.cbDistribucion.Size = new System.Drawing.Size(159, 24);
            this.cbDistribucion.TabIndex = 3;
            this.cbDistribucion.SelectionChangeCommitted += new System.EventHandler(this.cbDistribucion_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "A (desde)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "B (hasta)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lambda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Media";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desviacion";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(243, 27);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(112, 48);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 11;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(112, 77);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 12;
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(111, 57);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 22);
            this.txtLambda.TabIndex = 13;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(111, 45);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 22);
            this.txtMedia.TabIndex = 14;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Location = new System.Drawing.Point(111, 74);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(100, 22);
            this.txtDesviacion.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 155);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(85, 34);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Seleccione la cantidad de Intervalos:";
            // 
            // gbUniforme
            // 
            this.gbUniforme.Controls.Add(this.label4);
            this.gbUniforme.Controls.Add(this.label5);
            this.gbUniforme.Controls.Add(this.txtA);
            this.gbUniforme.Controls.Add(this.txtB);
            this.gbUniforme.Location = new System.Drawing.Point(490, 31);
            this.gbUniforme.Name = "gbUniforme";
            this.gbUniforme.Size = new System.Drawing.Size(232, 133);
            this.gbUniforme.TabIndex = 19;
            this.gbUniforme.TabStop = false;
            this.gbUniforme.Text = "Uniforme";
            // 
            // gbExponencial
            // 
            this.gbExponencial.Controls.Add(this.label6);
            this.gbExponencial.Controls.Add(this.txtLambda);
            this.gbExponencial.Location = new System.Drawing.Point(490, 31);
            this.gbExponencial.Name = "gbExponencial";
            this.gbExponencial.Size = new System.Drawing.Size(232, 133);
            this.gbExponencial.TabIndex = 20;
            this.gbExponencial.TabStop = false;
            this.gbExponencial.Text = "Exponencial";
            // 
            // gbNormal
            // 
            this.gbNormal.Controls.Add(this.label7);
            this.gbNormal.Controls.Add(this.label8);
            this.gbNormal.Controls.Add(this.txtMedia);
            this.gbNormal.Controls.Add(this.txtDesviacion);
            this.gbNormal.Location = new System.Drawing.Point(490, 31);
            this.gbNormal.Name = "gbNormal";
            this.gbNormal.Size = new System.Drawing.Size(232, 133);
            this.gbNormal.TabIndex = 21;
            this.gbNormal.TabStop = false;
            this.gbNormal.Text = "Normal";
            // 
            // cbIntervalos
            // 
            this.cbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervalos.FormattingEnabled = true;
            this.cbIntervalos.Items.AddRange(new object[] {
            "10",
            "12",
            "16",
            "23"});
            this.cbIntervalos.Location = new System.Drawing.Point(243, 63);
            this.cbIntervalos.Name = "cbIntervalos";
            this.cbIntervalos.Size = new System.Drawing.Size(100, 24);
            this.cbIntervalos.TabIndex = 22;
            // 
            // chartDistribucion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDistribucion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDistribucion.Legends.Add(legend1);
            this.chartDistribucion.Location = new System.Drawing.Point(12, 202);
            this.chartDistribucion.Name = "chartDistribucion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDistribucion.Series.Add(series1);
            this.chartDistribucion.Size = new System.Drawing.Size(710, 392);
            this.chartDistribucion.TabIndex = 28;
            this.chartDistribucion.Text = "chart1";
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(762, 12);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.RowTemplate.Height = 24;
            this.dgvMuestra.Size = new System.Drawing.Size(240, 582);
            this.dgvMuestra.TabIndex = 29;
            // 
            // gbChi
            // 
            this.gbChi.Controls.Add(this.dgvChi);
            this.gbChi.Location = new System.Drawing.Point(1037, 12);
            this.gbChi.Name = "gbChi";
            this.gbChi.Size = new System.Drawing.Size(599, 299);
            this.gbChi.TabIndex = 32;
            this.gbChi.TabStop = false;
            this.gbChi.Text = "Prueba Chi Cuadrado";
            // 
            // dgvChi
            // 
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesdeChi,
            this.HastaChi,
            this.FrecObsChi,
            this.FrecEspChi,
            this.ChiAcumulado});
            this.dgvChi.Location = new System.Drawing.Point(6, 19);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(587, 272);
            this.dgvChi.TabIndex = 0;
            // 
            // DesdeChi
            // 
            this.DesdeChi.Frozen = true;
            this.DesdeChi.HeaderText = "Desde";
            this.DesdeChi.MinimumWidth = 6;
            this.DesdeChi.Name = "DesdeChi";
            this.DesdeChi.Width = 125;
            // 
            // HastaChi
            // 
            this.HastaChi.Frozen = true;
            this.HastaChi.HeaderText = "Hasta";
            this.HastaChi.MinimumWidth = 6;
            this.HastaChi.Name = "HastaChi";
            this.HastaChi.Width = 125;
            // 
            // FrecObsChi
            // 
            this.FrecObsChi.Frozen = true;
            this.FrecObsChi.HeaderText = "FrecObs";
            this.FrecObsChi.MinimumWidth = 6;
            this.FrecObsChi.Name = "FrecObsChi";
            this.FrecObsChi.Width = 125;
            // 
            // FrecEspChi
            // 
            this.FrecEspChi.Frozen = true;
            this.FrecEspChi.HeaderText = "FrecEsp";
            this.FrecEspChi.MinimumWidth = 6;
            this.FrecEspChi.Name = "FrecEspChi";
            this.FrecEspChi.Width = 125;
            // 
            // ChiAcumulado
            // 
            this.ChiAcumulado.HeaderText = "C(ac)";
            this.ChiAcumulado.MinimumWidth = 6;
            this.ChiAcumulado.Name = "ChiAcumulado";
            this.ChiAcumulado.Width = 125;
            // 
            // gbKS
            // 
            this.gbKS.Controls.Add(this.dgvKS);
            this.gbKS.Location = new System.Drawing.Point(1037, 317);
            this.gbKS.Name = "gbKS";
            this.gbKS.Size = new System.Drawing.Size(599, 277);
            this.gbKS.TabIndex = 33;
            this.gbKS.TabStop = false;
            this.gbKS.Text = "Prueba K-S";
            // 
            // dgvKS
            // 
            this.dgvKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesdeKS,
            this.HastaKS,
            this.FrecObsKS,
            this.FrecEspKS,
            this.PoKS,
            this.PeKS,
            this.CalcKS,
            this.MaxKS});
            this.dgvKS.Location = new System.Drawing.Point(6, 21);
            this.dgvKS.Name = "dgvKS";
            this.dgvKS.RowHeadersWidth = 51;
            this.dgvKS.RowTemplate.Height = 24;
            this.dgvKS.Size = new System.Drawing.Size(587, 250);
            this.dgvKS.TabIndex = 0;
            // 
            // DesdeKS
            // 
            this.DesdeKS.HeaderText = "Desde";
            this.DesdeKS.MinimumWidth = 6;
            this.DesdeKS.Name = "DesdeKS";
            this.DesdeKS.Width = 125;
            // 
            // HastaKS
            // 
            this.HastaKS.HeaderText = "Hasta";
            this.HastaKS.MinimumWidth = 6;
            this.HastaKS.Name = "HastaKS";
            this.HastaKS.Width = 125;
            // 
            // FrecObsKS
            // 
            this.FrecObsKS.HeaderText = "FrecObs";
            this.FrecObsKS.MinimumWidth = 6;
            this.FrecObsKS.Name = "FrecObsKS";
            this.FrecObsKS.Width = 125;
            // 
            // FrecEspKS
            // 
            this.FrecEspKS.HeaderText = "FrecEsp";
            this.FrecEspKS.MinimumWidth = 6;
            this.FrecEspKS.Name = "FrecEspKS";
            this.FrecEspKS.Width = 125;
            // 
            // PoKS
            // 
            this.PoKS.HeaderText = "Po(ac)";
            this.PoKS.MinimumWidth = 6;
            this.PoKS.Name = "PoKS";
            this.PoKS.Width = 125;
            // 
            // PeKS
            // 
            this.PeKS.HeaderText = "Pe(ac)";
            this.PeKS.MinimumWidth = 6;
            this.PeKS.Name = "PeKS";
            this.PeKS.Width = 125;
            // 
            // CalcKS
            // 
            this.CalcKS.HeaderText = "|Po(AC)-Pe(AC)|";
            this.CalcKS.MinimumWidth = 6;
            this.CalcKS.Name = "CalcKS";
            this.CalcKS.Width = 125;
            // 
            // MaxKS
            // 
            this.MaxKS.HeaderText = "Max";
            this.MaxKS.MinimumWidth = 6;
            this.MaxKS.Name = "MaxKS";
            this.MaxKS.Width = 125;
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.Controls.Add(this.label1);
            this.gbIngresoDatos.Controls.Add(this.label2);
            this.gbIngresoDatos.Controls.Add(this.cbDistribucion);
            this.gbIngresoDatos.Controls.Add(this.txtN);
            this.gbIngresoDatos.Controls.Add(this.label9);
            this.gbIngresoDatos.Controls.Add(this.cbIntervalos);
            this.gbIngresoDatos.Location = new System.Drawing.Point(12, 12);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Size = new System.Drawing.Size(411, 140);
            this.gbIngresoDatos.TabIndex = 34;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Datos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1665, 618);
            this.Controls.Add(this.gbIngresoDatos);
            this.Controls.Add(this.gbKS);
            this.Controls.Add(this.gbChi);
            this.Controls.Add(this.dgvMuestra);
            this.Controls.Add(this.chartDistribucion);
            this.Controls.Add(this.gbNormal);
            this.Controls.Add(this.gbExponencial);
            this.Controls.Add(this.gbUniforme);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblIngreseDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Programa generador de numeros aleatorios";
            this.gbUniforme.ResumeLayout(false);
            this.gbUniforme.PerformLayout();
            this.gbExponencial.ResumeLayout(false);
            this.gbExponencial.PerformLayout();
            this.gbNormal.ResumeLayout(false);
            this.gbNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.gbChi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.gbKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).EndInit();
            this.gbIngresoDatos.ResumeLayout(false);
            this.gbIngresoDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.ComboBox cbDistribucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbUniforme;
        private System.Windows.Forms.GroupBox gbExponencial;
        private System.Windows.Forms.GroupBox gbNormal;
        private System.Windows.Forms.ComboBox cbIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribucion;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.GroupBox gbChi;
        private System.Windows.Forms.GroupBox gbKS;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridView dgvKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesdeChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObsChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEspChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesdeKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObsKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEspKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxKS;
        private System.Windows.Forms.GroupBox gbIngresoDatos;
    }
}

