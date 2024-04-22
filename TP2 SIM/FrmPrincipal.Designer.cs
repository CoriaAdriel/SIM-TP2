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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblIngreseDatos = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el tamaño de la muestra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el tipo de distribucion:";
            // 
            // cbDistribucion
            // 
            this.cbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistribucion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistribucion.FormattingEnabled = true;
            this.cbDistribucion.Items.AddRange(new object[] {
            "Uniforme [a,b]",
            "Exponencial",
            "Normal"});
            this.cbDistribucion.Location = new System.Drawing.Point(263, 111);
            this.cbDistribucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDistribucion.Name = "cbDistribucion";
            this.cbDistribucion.Size = new System.Drawing.Size(139, 25);
            this.cbDistribucion.TabIndex = 2;
            this.cbDistribucion.SelectionChangeCommitted += new System.EventHandler(this.cbDistribucion_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "A (desde)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "B (hasta)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lambda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Media";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desviacion";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(263, 28);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(143, 25);
            this.txtN.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(98, 51);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(88, 25);
            this.txtA.TabIndex = 11;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(98, 82);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(88, 25);
            this.txtB.TabIndex = 12;
            // 
            // txtLambda
            // 
            this.txtLambda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLambda.Location = new System.Drawing.Point(97, 60);
            this.txtLambda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(88, 25);
            this.txtLambda.TabIndex = 13;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(97, 48);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(88, 25);
            this.txtMedia.TabIndex = 14;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesviacion.Location = new System.Drawing.Point(97, 78);
            this.txtDesviacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(88, 25);
            this.txtDesviacion.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.IndianRed;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(19, 186);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(149, 37);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Seleccione la cantidad de Intervalos:";
            // 
            // gbUniforme
            // 
            this.gbUniforme.Controls.Add(this.label4);
            this.gbUniforme.Controls.Add(this.label5);
            this.gbUniforme.Controls.Add(this.txtA);
            this.gbUniforme.Controls.Add(this.txtB);
            this.gbUniforme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUniforme.ForeColor = System.Drawing.Color.Silver;
            this.gbUniforme.Location = new System.Drawing.Point(430, 31);
            this.gbUniforme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUniforme.Name = "gbUniforme";
            this.gbUniforme.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbUniforme.Size = new System.Drawing.Size(203, 149);
            this.gbUniforme.TabIndex = 19;
            this.gbUniforme.TabStop = false;
            this.gbUniforme.Text = "Uniforme";
            // 
            // gbExponencial
            // 
            this.gbExponencial.Controls.Add(this.label6);
            this.gbExponencial.Controls.Add(this.txtLambda);
            this.gbExponencial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExponencial.ForeColor = System.Drawing.Color.Silver;
            this.gbExponencial.Location = new System.Drawing.Point(430, 31);
            this.gbExponencial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbExponencial.Name = "gbExponencial";
            this.gbExponencial.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbExponencial.Size = new System.Drawing.Size(203, 149);
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
            this.gbNormal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNormal.ForeColor = System.Drawing.Color.Silver;
            this.gbNormal.Location = new System.Drawing.Point(430, 31);
            this.gbNormal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNormal.Name = "gbNormal";
            this.gbNormal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNormal.Size = new System.Drawing.Size(203, 149);
            this.gbNormal.TabIndex = 21;
            this.gbNormal.TabStop = false;
            this.gbNormal.Text = "Normal";
            // 
            // cbIntervalos
            // 
            this.cbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntervalos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntervalos.FormattingEnabled = true;
            this.cbIntervalos.Items.AddRange(new object[] {
            "10",
            "12",
            "16",
            "23"});
            this.cbIntervalos.Location = new System.Drawing.Point(263, 68);
            this.cbIntervalos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIntervalos.Name = "cbIntervalos";
            this.cbIntervalos.Size = new System.Drawing.Size(139, 25);
            this.cbIntervalos.TabIndex = 1;
            // 
            // chartDistribucion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDistribucion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDistribucion.Legends.Add(legend1);
            this.chartDistribucion.Location = new System.Drawing.Point(10, 233);
            this.chartDistribucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartDistribucion.Name = "chartDistribucion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDistribucion.Series.Add(series1);
            this.chartDistribucion.Size = new System.Drawing.Size(623, 370);
            this.chartDistribucion.TabIndex = 28;
            this.chartDistribucion.Text = "chart1";
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AllowUserToResizeRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(667, 13);
            this.dgvMuestra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.RowHeadersVisible = false;
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.RowTemplate.Height = 24;
            this.dgvMuestra.Size = new System.Drawing.Size(210, 590);
            this.dgvMuestra.TabIndex = 29;
            // 
            // gbChi
            // 
            this.gbChi.Controls.Add(this.dgvChi);
            this.gbChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChi.ForeColor = System.Drawing.Color.Silver;
            this.gbChi.Location = new System.Drawing.Point(908, 13);
            this.gbChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbChi.Name = "gbChi";
            this.gbChi.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbChi.Size = new System.Drawing.Size(524, 296);
            this.gbChi.TabIndex = 32;
            this.gbChi.TabStop = false;
            this.gbChi.Text = "Prueba Chi Cuadrado";
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.AllowUserToDeleteRows = false;
            this.dgvChi.AllowUserToResizeRows = false;
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvChi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesdeChi,
            this.HastaChi,
            this.FrecObsChi,
            this.FrecEspChi,
            this.ChiAcumulado});
            this.dgvChi.Location = new System.Drawing.Point(7, 18);
            this.dgvChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.ReadOnly = true;
            this.dgvChi.RowHeadersVisible = false;
            this.dgvChi.RowHeadersWidth = 51;
            this.dgvChi.RowTemplate.Height = 24;
            this.dgvChi.Size = new System.Drawing.Size(513, 268);
            this.dgvChi.TabIndex = 0;
            // 
            // DesdeChi
            // 
            this.DesdeChi.Frozen = true;
            this.DesdeChi.HeaderText = "Desde";
            this.DesdeChi.MinimumWidth = 6;
            this.DesdeChi.Name = "DesdeChi";
            this.DesdeChi.ReadOnly = true;
            this.DesdeChi.Width = 75;
            // 
            // HastaChi
            // 
            this.HastaChi.Frozen = true;
            this.HastaChi.HeaderText = "Hasta";
            this.HastaChi.MinimumWidth = 6;
            this.HastaChi.Name = "HastaChi";
            this.HastaChi.ReadOnly = true;
            this.HastaChi.Width = 72;
            // 
            // FrecObsChi
            // 
            this.FrecObsChi.Frozen = true;
            this.FrecObsChi.HeaderText = "FrecObs";
            this.FrecObsChi.MinimumWidth = 6;
            this.FrecObsChi.Name = "FrecObsChi";
            this.FrecObsChi.ReadOnly = true;
            this.FrecObsChi.Width = 88;
            // 
            // FrecEspChi
            // 
            this.FrecEspChi.Frozen = true;
            this.FrecEspChi.HeaderText = "FrecEsp";
            this.FrecEspChi.MinimumWidth = 6;
            this.FrecEspChi.Name = "FrecEspChi";
            this.FrecEspChi.ReadOnly = true;
            this.FrecEspChi.Width = 84;
            // 
            // ChiAcumulado
            // 
            this.ChiAcumulado.HeaderText = "C(ac)";
            this.ChiAcumulado.MinimumWidth = 6;
            this.ChiAcumulado.Name = "ChiAcumulado";
            this.ChiAcumulado.ReadOnly = true;
            this.ChiAcumulado.Width = 68;
            // 
            // gbKS
            // 
            this.gbKS.Controls.Add(this.dgvKS);
            this.gbKS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKS.ForeColor = System.Drawing.Color.Silver;
            this.gbKS.Location = new System.Drawing.Point(908, 315);
            this.gbKS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbKS.Name = "gbKS";
            this.gbKS.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbKS.Size = new System.Drawing.Size(524, 294);
            this.gbKS.TabIndex = 33;
            this.gbKS.TabStop = false;
            this.gbKS.Text = "Prueba K-S";
            // 
            // dgvKS
            // 
            this.dgvKS.AllowUserToAddRows = false;
            this.dgvKS.AllowUserToDeleteRows = false;
            this.dgvKS.AllowUserToResizeRows = false;
            this.dgvKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvKS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKS.Location = new System.Drawing.Point(11, 23);
            this.dgvKS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvKS.Name = "dgvKS";
            this.dgvKS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKS.RowHeadersVisible = false;
            this.dgvKS.RowHeadersWidth = 51;
            this.dgvKS.RowTemplate.Height = 24;
            this.dgvKS.Size = new System.Drawing.Size(513, 265);
            this.dgvKS.TabIndex = 0;
            // 
            // DesdeKS
            // 
            this.DesdeKS.FillWeight = 61.78946F;
            this.DesdeKS.HeaderText = "Desde";
            this.DesdeKS.MinimumWidth = 6;
            this.DesdeKS.Name = "DesdeKS";
            this.DesdeKS.ReadOnly = true;
            this.DesdeKS.Width = 75;
            // 
            // HastaKS
            // 
            this.HastaKS.FillWeight = 61.78946F;
            this.HastaKS.HeaderText = "Hasta";
            this.HastaKS.MinimumWidth = 6;
            this.HastaKS.Name = "HastaKS";
            this.HastaKS.ReadOnly = true;
            this.HastaKS.Width = 72;
            // 
            // FrecObsKS
            // 
            this.FrecObsKS.FillWeight = 61.78946F;
            this.FrecObsKS.HeaderText = "FrecObs";
            this.FrecObsKS.MinimumWidth = 6;
            this.FrecObsKS.Name = "FrecObsKS";
            this.FrecObsKS.ReadOnly = true;
            this.FrecObsKS.Width = 88;
            // 
            // FrecEspKS
            // 
            this.FrecEspKS.FillWeight = 61.78946F;
            this.FrecEspKS.HeaderText = "FrecEsp";
            this.FrecEspKS.MinimumWidth = 6;
            this.FrecEspKS.Name = "FrecEspKS";
            this.FrecEspKS.ReadOnly = true;
            this.FrecEspKS.Width = 84;
            // 
            // PoKS
            // 
            this.PoKS.FillWeight = 61.78946F;
            this.PoKS.HeaderText = "Po(ac)";
            this.PoKS.MinimumWidth = 6;
            this.PoKS.Name = "PoKS";
            this.PoKS.ReadOnly = true;
            this.PoKS.Width = 77;
            // 
            // PeKS
            // 
            this.PeKS.FillWeight = 190.8629F;
            this.PeKS.HeaderText = "Pe(ac)";
            this.PeKS.MinimumWidth = 6;
            this.PeKS.Name = "PeKS";
            this.PeKS.ReadOnly = true;
            this.PeKS.Width = 76;
            // 
            // CalcKS
            // 
            this.CalcKS.FillWeight = 238.4003F;
            this.CalcKS.HeaderText = "|Po(AC)-Pe(AC)|";
            this.CalcKS.MinimumWidth = 6;
            this.CalcKS.Name = "CalcKS";
            this.CalcKS.ReadOnly = true;
            this.CalcKS.Width = 143;
            // 
            // MaxKS
            // 
            this.MaxKS.FillWeight = 61.78946F;
            this.MaxKS.HeaderText = "Max";
            this.MaxKS.MinimumWidth = 6;
            this.MaxKS.Name = "MaxKS";
            this.MaxKS.ReadOnly = true;
            this.MaxKS.Width = 63;
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.Controls.Add(this.label1);
            this.gbIngresoDatos.Controls.Add(this.label2);
            this.gbIngresoDatos.Controls.Add(this.cbDistribucion);
            this.gbIngresoDatos.Controls.Add(this.txtN);
            this.gbIngresoDatos.Controls.Add(this.label9);
            this.gbIngresoDatos.Controls.Add(this.cbIntervalos);
            this.gbIngresoDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresoDatos.ForeColor = System.Drawing.Color.Silver;
            this.gbIngresoDatos.Location = new System.Drawing.Point(10, 31);
            this.gbIngresoDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIngresoDatos.Size = new System.Drawing.Size(412, 149);
            this.gbIngresoDatos.TabIndex = 34;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Datos";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseDatos.ForeColor = System.Drawing.Color.Silver;
            this.lblIngreseDatos.Location = new System.Drawing.Point(426, 9);
            this.lblIngreseDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(167, 19);
            this.lblIngreseDatos.TabIndex = 2;
            this.lblIngreseDatos.Text = "Parámetros Requeridos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1364, 534);
            this.Controls.Add(this.gbIngresoDatos);
            this.Controls.Add(this.gbKS);
            this.Controls.Add(this.gbNormal);
            this.Controls.Add(this.gbChi);
            this.Controls.Add(this.gbExponencial);
            this.Controls.Add(this.dgvMuestra);
            this.Controls.Add(this.chartDistribucion);
            this.Controls.Add(this.gbUniforme);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblIngreseDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa generador de numeros aleatorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesdeKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObsKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEspKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxKS;
    }
}

