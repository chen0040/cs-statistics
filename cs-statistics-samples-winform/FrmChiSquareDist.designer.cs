namespace Statistics.WinformUI
{
    partial class FrmChiSquareDist
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPlotChart = new System.Windows.Forms.Button();
            this.btnCalculateQuantile = new System.Windows.Forms.Button();
            this.btnCalcPercentile = new System.Windows.Forms.Button();
            this.txtPercentile = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtDF1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chtCDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chtPDF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCDF)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPlotChart);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalculateQuantile);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalcPercentile);
            this.splitContainer1.Panel1.Controls.Add(this.txtPercentile);
            this.splitContainer1.Panel1.Controls.Add(this.txtF);
            this.splitContainer1.Panel1.Controls.Add(this.txtDF1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(830, 433);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnPlotChart
            // 
            this.btnPlotChart.Location = new System.Drawing.Point(95, 175);
            this.btnPlotChart.Name = "btnPlotChart";
            this.btnPlotChart.Size = new System.Drawing.Size(121, 23);
            this.btnPlotChart.TabIndex = 1;
            this.btnPlotChart.Text = "Plot Chart";
            this.btnPlotChart.UseVisualStyleBackColor = true;
            this.btnPlotChart.Click += new System.EventHandler(this.btnPlotChart_Click);
            // 
            // btnCalculateQuantile
            // 
            this.btnCalculateQuantile.Location = new System.Drawing.Point(14, 251);
            this.btnCalculateQuantile.Name = "btnCalculateQuantile";
            this.btnCalculateQuantile.Size = new System.Drawing.Size(201, 23);
            this.btnCalculateQuantile.TabIndex = 1;
            this.btnCalculateQuantile.Text = "Calculate F given P ( y < Chi^2 )";
            this.btnCalculateQuantile.UseVisualStyleBackColor = true;
            this.btnCalculateQuantile.Click += new System.EventHandler(this.btnCalculateQuantile_Click);
            // 
            // btnCalcPercentile
            // 
            this.btnCalcPercentile.Location = new System.Drawing.Point(15, 222);
            this.btnCalcPercentile.Name = "btnCalcPercentile";
            this.btnCalcPercentile.Size = new System.Drawing.Size(201, 23);
            this.btnCalcPercentile.TabIndex = 1;
            this.btnCalcPercentile.Text = "Calculate P ( y < Chi^2 ) given Chi^2";
            this.btnCalcPercentile.UseVisualStyleBackColor = true;
            this.btnCalcPercentile.Click += new System.EventHandler(this.btnCalcPercentile_Click);
            // 
            // txtPercentile
            // 
            this.txtPercentile.Location = new System.Drawing.Point(116, 120);
            this.txtPercentile.Name = "txtPercentile";
            this.txtPercentile.Size = new System.Drawing.Size(100, 20);
            this.txtPercentile.TabIndex = 0;
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(116, 97);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 20);
            this.txtF.TabIndex = 0;
            this.txtF.Text = "-2";
            // 
            // txtDF1
            // 
            this.txtDF1.Location = new System.Drawing.Point(116, 9);
            this.txtDF1.Name = "txtDF1";
            this.txtDF1.Size = new System.Drawing.Size(100, 20);
            this.txtDF1.TabIndex = 0;
            this.txtDF1.Tag = "1";
            this.txtDF1.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "y follows F-Distribution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "P ( y < Chi^2 ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi^2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DF";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chtCDF);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chtCDF
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCDF.ChartAreas.Add(chartArea1);
            this.chtCDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtCDF.Legends.Add(legend1);
            this.chtCDF.Location = new System.Drawing.Point(3, 3);
            this.chtCDF.Name = "chtCDF";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCDF.Series.Add(series1);
            this.chtCDF.Size = new System.Drawing.Size(580, 401);
            this.chtCDF.TabIndex = 1;
            this.chtCDF.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chtPDF);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chtPDF
            // 
            chartArea2.Name = "ChartArea1";
            this.chtPDF.ChartAreas.Add(chartArea2);
            this.chtPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chtPDF.Legends.Add(legend2);
            this.chtPDF.Location = new System.Drawing.Point(3, 3);
            this.chtPDF.Name = "chtPDF";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtPDF.Series.Add(series2);
            this.chtPDF.Size = new System.Drawing.Size(580, 401);
            this.chtPDF.TabIndex = 1;
            this.chtPDF.Text = "chart2";
            // 
            // FrmChiSquareDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 433);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmChiSquareDist";
            this.Text = "Chi^2 - Distribution";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtCDF)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcPercentile;
        private System.Windows.Forms.TextBox txtPercentile;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtDF1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPlotChart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCDF;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPDF;
        private System.Windows.Forms.Button btnCalculateQuantile;
    }
}

