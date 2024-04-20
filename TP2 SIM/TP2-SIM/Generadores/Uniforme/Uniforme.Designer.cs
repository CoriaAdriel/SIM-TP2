﻿using System.Drawing;

namespace TP2_SIM.Generadores.Uniforme
{
    partial class Uniforme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnPruebaChi = new System.Windows.Forms.Button();
            this.btnPruebaKS = new System.Windows.Forms.Button();
            this.txtN = new TP2_SIM.ControlesEspeciales.NumericTextBox();
            this.btnVerRandom = new System.Windows.Forms.Button();
            this.txtDesde = new TP2_SIM.ControlesEspeciales.NumericTextBox();
            this.txtHasta = new TP2_SIM.ControlesEspeciales.NumericTextBox();
            this.chtUniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd23 = new System.Windows.Forms.RadioButton();
            this.rd16 = new System.Windows.Forms.RadioButton();
            this.rd12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chtUniforme)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A (Desde)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "B (Hasta)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese la cantidad a generar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "DISTRIBUCIÓN UNIFORME";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(309, 103);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(89, 36);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnPruebaChi
            // 
            this.btnPruebaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPruebaChi.BackColor = System.Drawing.Color.Crimson;
            this.btnPruebaChi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaChi.Location = new System.Drawing.Point(13, 427);
            this.btnPruebaChi.Name = "btnPruebaChi";
            this.btnPruebaChi.Size = new System.Drawing.Size(106, 37);
            this.btnPruebaChi.TabIndex = 5;
            this.btnPruebaChi.Text = "Prueba Chi";
            this.btnPruebaChi.UseVisualStyleBackColor = false;
            this.btnPruebaChi.Click += new System.EventHandler(this.btnPruebaChi_Click);
            // 
            // btnPruebaKS
            // 
            this.btnPruebaKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPruebaKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnPruebaKS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebaKS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaKS.Location = new System.Drawing.Point(134, 427);
            this.btnPruebaKS.Name = "btnPruebaKS";
            this.btnPruebaKS.Size = new System.Drawing.Size(106, 37);
            this.btnPruebaKS.TabIndex = 6;
            this.btnPruebaKS.Text = "Prueba KS";
            this.btnPruebaKS.UseVisualStyleBackColor = false;
            // 
            // txtN
            // 
            this.txtN.AllowNumbersOnly = true;
            this.txtN.Location = new System.Drawing.Point(230, 68);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.MaxLength = 10;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(168, 28);
            this.txtN.TabIndex = 0;
            // 
            // btnVerRandom
            // 
            this.btnVerRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerRandom.BackColor = System.Drawing.Color.Crimson;
            this.btnVerRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRandom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRandom.Location = new System.Drawing.Point(404, 103);
            this.btnVerRandom.Name = "btnVerRandom";
            this.btnVerRandom.Size = new System.Drawing.Size(106, 37);
            this.btnVerRandom.TabIndex = 4;
            this.btnVerRandom.Text = "Ver RND";
            this.btnVerRandom.UseVisualStyleBackColor = false;
            this.btnVerRandom.Click += new System.EventHandler(this.btnVerRandom_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.AllowNumbersOnly = true;
            this.txtDesde.Location = new System.Drawing.Point(99, 110);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesde.MaxLength = 10;
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(42, 37);
            this.txtDesde.TabIndex = 1;
            // 
            // txtHasta
            // 
            this.txtHasta.AllowNumbersOnly = true;
            this.txtHasta.Location = new System.Drawing.Point(226, 111);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtHasta.MaxLength = 10;
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(49, 48);
            this.txtHasta.TabIndex = 2;
            // 
            // chtUniforme
            // 
            chartArea1.Name = "ChartArea1";
            this.chtUniforme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtUniforme.Legends.Add(legend1);
            this.chtUniforme.Location = new System.Drawing.Point(12, 155);
            this.chtUniforme.Name = "chtUniforme";
            this.chtUniforme.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chtUniforme.Series.Add(series1);
            this.chtUniforme.Size = new System.Drawing.Size(726, 231);
            this.chtUniforme.TabIndex = 7;
            this.chtUniforme.Text = "chart1";
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Location = new System.Drawing.Point(40, 24);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(43, 23);
            this.rd10.TabIndex = 8;
            this.rd10.TabStop = true;
            this.rd10.Text = "10";
            this.rd10.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd23);
            this.groupBox1.Controls.Add(this.rd16);
            this.groupBox1.Controls.Add(this.rd12);
            this.groupBox1.Controls.Add(this.rd10);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(425, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de Intervalos";
            // 
            // rd23
            // 
            this.rd23.AutoSize = true;
            this.rd23.Location = new System.Drawing.Point(220, 24);
            this.rd23.Name = "rd23";
            this.rd23.Size = new System.Drawing.Size(43, 23);
            this.rd23.TabIndex = 11;
            this.rd23.TabStop = true;
            this.rd23.Text = "23";
            this.rd23.UseVisualStyleBackColor = true;
            // 
            // rd16
            // 
            this.rd16.AutoSize = true;
            this.rd16.Location = new System.Drawing.Point(166, 24);
            this.rd16.Name = "rd16";
            this.rd16.Size = new System.Drawing.Size(43, 23);
            this.rd16.TabIndex = 10;
            this.rd16.TabStop = true;
            this.rd16.Text = "16";
            this.rd16.UseVisualStyleBackColor = true;
            // 
            // rd12
            // 
            this.rd12.AutoSize = true;
            this.rd12.Location = new System.Drawing.Point(107, 24);
            this.rd12.Name = "rd12";
            this.rd12.Size = new System.Drawing.Size(43, 23);
            this.rd12.TabIndex = 9;
            this.rd12.TabStop = true;
            this.rd12.Text = "12";
            this.rd12.UseVisualStyleBackColor = true;
            // 
            // Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chtUniforme);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.btnVerRandom);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnPruebaKS);
            this.Controls.Add(this.btnPruebaChi);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Uniforme";
            this.Text = "DISTRIBUCIÓN UNIFORME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Uniforme_FormClosed);
            this.Load += new System.EventHandler(this.Uniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtUniforme)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnPruebaChi;
        private System.Windows.Forms.Button btnPruebaKS;
        private ControlesEspeciales.NumericTextBox txtN;
        private System.Windows.Forms.Button btnVerRandom;
        private ControlesEspeciales.NumericTextBox txtDesde;
        private ControlesEspeciales.NumericTextBox txtHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtUniforme;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd23;
        private System.Windows.Forms.RadioButton rd16;
        private System.Windows.Forms.RadioButton rd12;
    }
}