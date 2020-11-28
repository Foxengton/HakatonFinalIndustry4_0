using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
			Console.WriteLine();

			DateTime time = dateTimePicker.Value;

			predict.Prognose(time.Day, time.Month, time.Year, SelectedCircle.SelectedIndex);
		}
	}
}
