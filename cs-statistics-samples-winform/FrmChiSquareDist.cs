using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Statistics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistics.WinformUI
{
    public partial class FrmChiSquareDist : Form
    {
        public FrmChiSquareDist()
        {
            InitializeComponent();

            chtCDF.Series[0].ChartType = SeriesChartType.Line;
            chtCDF.Series[0].LegendText = "CDF";

            chtCDF.Titles.Add("Chi^2-Distribution CDF");

            chtPDF.Series[0].ChartType = SeriesChartType.Line;
            chtPDF.Series[0].LegendText = "PDF";

            chtPDF.Titles.Add("Chi^2-Distribution PDF");
        }

        private void btnCalcPercentile_Click(object sender, EventArgs e)
        {
            int DF1 = int.Parse(txtDF1.Text);
            double F = double.Parse(txtF.Text);
            double p = ChiSquare.GetPercentile(F, DF1);
            txtPercentile.Text = p.ToString("0.000");
        }

        private void btnPlotChart_Click(object sender, EventArgs e)
        {
            double deltaF = 0.1;
            int DF1 = int.Parse(txtDF1.Text);
            chtCDF.Series[0].Points.Clear();
            for (double f = deltaF; f < 10; f+=deltaF)
            {
                chtCDF.Series[0].Points.AddXY(f, ChiSquare.GetPercentile(f, DF1));
            }

            chtPDF.Series[0].Points.Clear();
            for (double f = deltaF; f < 10; f += deltaF)
            {
                chtPDF.Series[0].Points.AddXY(f, ChiSquare.GetPDF(f, DF1));
            }
        }

        private void btnCalculateQuantile_Click(object sender, EventArgs e)
        {
            int DF1 = int.Parse(txtDF1.Text);
            double P = double.Parse(txtPercentile.Text);
            double F = ChiSquare.GetQuantile(P, DF1);
            txtF.Text = F.ToString();
        }
    }
}
