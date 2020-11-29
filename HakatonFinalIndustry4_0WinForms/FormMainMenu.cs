using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Industry4_0Library;

namespace HakatonFinalIndustry4_0WinForms
{
	public partial class FormMainMenu : Form
	{
		private Predict predict;
		public FormMainMenu()
		{
			InitializeComponent();

			predict = new Predict();

			SelectedCircle.SelectedIndex = 0;
			SelectedPeriod.SelectedIndex = 0;
			SelectedSize.SelectedIndex = 0;
		}

		private void ButtonPredict_Click(object sender, EventArgs e)
		{
			DateTime time = dateTimePicker.Value;

			// = = = = = FUTURE = = = = = //
			DateTime timeFuture = time.AddDays(1);
			List<double[]> data = predict.Prognose(timeFuture.Hour, timeFuture.Day, timeFuture.Month, timeFuture.Year, SelectedCircle.SelectedIndex);

			chartFuture.Titles[0].Text = $"За следующий период: {timeFuture.Day}.{timeFuture.Month}.{timeFuture.Year}";
			chartFuture.ChartAreas.Clear();
			chartFuture.ChartAreas.Add(new ChartArea("Math functions") { BackColor = Color.FromArgb(0, 0, 64) });
			
			Series mySeriesOfPoint = new Series()
			{
				ChartType = SeriesChartType.Column,
				ChartArea = "Math functions",
				Color = Color.FromArgb(255, 192, 192)
			};
			for (int i = 0; i < data.Count; i++)
				mySeriesOfPoint.Points.AddXY(i, data[i][0] * data[i][1]);

			chartFuture.Series.Clear();
			chartFuture.Series.Add(mySeriesOfPoint);

			// = = = = = PRESENT = = = = = //
			data = predict.Prognose(time.Hour, time.Day, time.Month, time.Year, SelectedCircle.SelectedIndex);

			chartFuture.Titles[0].Text = $"За текущий период: {time.Day}.{time.Month}.{time.Year}";
			chartPresent.ChartAreas.Clear();
			chartPresent.ChartAreas.Add(new ChartArea("Math functions") { BackColor = Color.FromArgb(0, 0, 64) });

			mySeriesOfPoint = new Series()
			{
				ChartType = SeriesChartType.Column,
				ChartArea = "Math functions",
				Color = Color.LightGray
			};
			for (int i = 0; i < data.Count; i++)
				mySeriesOfPoint.Points.AddXY(i, data[i][0] * data[i][1]);

			chartPresent.Series.Clear();
			chartPresent.Series.Add(mySeriesOfPoint);

			// = = = = = PAST = = = = = //
			DateTime timePast = time.AddDays(-1);
			data = predict.Prognose(timePast.Hour, timePast.Day, timePast.Month, timePast.Year, SelectedCircle.SelectedIndex);

			chartPast.Titles[0].Text = $"За прошлый период: {timePast.Day}.{timePast.Month}.{timePast.Year}";
			chartPast.ChartAreas.Clear();
			chartPast.ChartAreas.Add(new ChartArea("Math functions") { BackColor = Color.FromArgb(0, 0, 64) });

			mySeriesOfPoint = new Series()
			{
				ChartType = SeriesChartType.Column,
				ChartArea = "Math functions",
				Color = Color.FromArgb(128, 128, 255)
			};
			for (int i = 0; i < data.Count; i++)
				mySeriesOfPoint.Points.AddXY(i, data[i][0] * data[i][1]);

			chartPast.Series.Clear();
			chartPast.Series.Add(mySeriesOfPoint);
		}
	}
}
