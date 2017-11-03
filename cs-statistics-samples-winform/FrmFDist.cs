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
    public partial class FrmFDist : Form
    {
        public FrmFDist()
        {
            InitializeComponent();

            chtCDF.Series[0].ChartType = SeriesChartType.Line;
            chtCDF.Series[0].LegendText = "CDF";

            chtCDF.Titles.Add("F-Distribution CDF");

            chtPDF.Series[0].ChartType = SeriesChartType.Line;
            chtPDF.Series[0].LegendText = "PDF";

            chtPDF.Titles.Add("F-Distribution PDF");
        }

        private void btnCalcPercentile_Click(object sender, EventArgs e)
        {
            int DF1 = int.Parse(txtDF1.Text);
            int DF2 = int.Parse(txtDF2.Text);
            double F = double.Parse(txtF.Text);
            double p = FDistribution.GetPercentile(F, DF1, DF2);
            txtPercentile.Text = p.ToString("0.000");
        }

        private void btnPlotChart_Click(object sender, EventArgs e)
        {
            double deltaF = 0.1;
            int DF1 = int.Parse(txtDF1.Text);
            int DF2 = int.Parse(txtDF2.Text);
            chtCDF.Series[0].Points.Clear();
            for (double f = deltaF; f < 10; f+=deltaF)
            {
                chtCDF.Series[0].Points.AddXY(f, FDistribution.GetPercentile(f, DF1, DF2));
            }

            chtPDF.Series[0].Points.Clear();
            for (double f = deltaF; f < 10; f += deltaF)
            {
                chtPDF.Series[0].Points.AddXY(f, FDistribution.GetPDF(f, DF1, DF2));
            }
        }

        private void btnCalculateQuantile_Click(object sender, EventArgs e)
        {
            int DF1 = int.Parse(txtDF1.Text);
            int DF2 = int.Parse(txtDF2.Text);
            double P = double.Parse(txtPercentile.Text);
            double F = FDistribution.GetQuantile(P, DF1, DF2);
            txtF.Text = F.ToString();
        }
    }
}
