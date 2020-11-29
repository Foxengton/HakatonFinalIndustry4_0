using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsQuery;
using NeuronNetwork;

namespace Industry4_0Library
{
	public class Predict
	{
		public string[] Circles { get; private set; }
		private Perceptron perceptron;

		public Predict()
		{
			//Динамика с прошлого года
			//Месяц
			//День месяца
			//День недели
			//Час
			//Ценовая зона
			//Округ
			perceptron = new Perceptron("industry4_0", new int[] { 1 + 12 + 31 + 7 + 24 + 2 + 6, 50, 1 }, new FunctionActivation.TypeFunc[] { FunctionActivation.TypeFunc.Default }, 20202);

			//Центр, Юг, Средняя Волга, Сибирь, Урал, Северо-Запад
			Circles = new string[] { "530000", "550000", "600000", "610000", "630000", "840000" };
		}

		public List<double[]> Prognose(int time, int day, int month, int year, int circle)
		{
			List<string[]> dataRows1 = GetRowForPrognose(day, month, year - 1, circle);
			List<string[]> dataRows2 = GetRowForPrognose(day, month, year, circle);

			List<double[]> result = new List<double[]>();
			for (int i = 0; i < dataRows1.Count; i++)
			{
				int value1 = Convert.ToInt32(dataRows1[i][4]);
				int value2 = Convert.ToInt32(dataRows2[i][4]);

				double ratio = value2 / (double)value1 - 0.5;
				string[] data = new string[] { i.ToString(), $"{day}.{month}", dataRows1[i][2], Circles[circle] };

				result.Add(new double[] { value2, perceptron.Predict(CreateRow(ratio, data))[0] });
			}

			return result;
		}

		private List<string[]> GetRowForPrognose(int day, int month, int year, int circle)
		{
			List<string[]> result = new List<string[]>();

			using (StreamReader reader = new StreamReader($"Генерация и потребление_{year - 1}.csv"))
			{
				string[] rows = reader.ReadToEnd().Split('\n');

				for (int i = 1; i < rows.Length - 1; i++)
				{
					string[] row = rows[i].Replace("\r", "").Split(';');

					string dayStr = day.ToString().Length == 1 ? "0" + day.ToString() : day.ToString();
					string monthStr = month.ToString().Length == 1 ? "0" + month.ToString() : month.ToString();

					if (row[1].Contains($"{dayStr}.{monthStr}") && row[3] == Circles[circle])
						result.Add(row);
				}
			}

			return result;
		}

		public void Train(int year)
		{
			string[] year0Data;
			using (StreamReader reader = new StreamReader($"Генерация и потребление_{year - 2}.csv"))
			{
				year0Data = reader.ReadToEnd().Split('\n');
			}

			string[] year1Data;
			using (StreamReader reader = new StreamReader($"Генерация и потребление_{year - 1}.csv"))
			{
				year1Data = reader.ReadToEnd().Split('\n');
			}

			string[] year2Data;
			using (StreamReader reader = new StreamReader($"Генерация и потребление_{year}.csv"))
			{
				year2Data = reader.ReadToEnd().Split('\n');
			}

			string[] year0Row;
			string[] year1Row;
			string[] year2Row;

			List<double[]> trainData = new List<double[]>();
			List<double[]> expectData = new List<double[]>();

			for (int i = 1; i < year1Data.Length - 1; i++)
			{
				year0Row = year0Data[i].Replace("\r", "").Split(';');
				year1Row = year1Data[i].Replace("\r", "").Split(';');
				year2Row = year2Data[i].Replace("\r", "").Split(';');

				double[] data = CreateRow(Convert.ToDouble(year1Row[4]) / Convert.ToDouble(year0Row[4]) - 0.5, year2Row);

				trainData.Add(data);
				expectData.Add(new double[] { Convert.ToDouble(year2Row[4]) / Convert.ToDouble(year1Row[4]) - 0.5 });
			}

			for (int i = 0; i < 10; i++)
				Console.WriteLine(perceptron.Train(trainData.ToArray(), expectData.ToArray(), 0.001));

			perceptron.SaveWeights();
		}

		private double[] CreateRow(double ratio, string[] data)
		{
			List<double> result = new List<double> { ratio };
			result.AddRange(GetDate(data[1]));
			result.AddRange(GetTime(data[0]));
			result.AddRange(GetCellZone(data[2]));
			result.AddRange(GetCircle(data[3]));
			return result.ToArray();
		}

		private double[] GetDate(string date)
		{
			double[] result = new double[12 + 31 + 7];
			int day = Convert.ToInt32(date.Split('.')[0]);
			int month = Convert.ToInt32(date.Split('.')[1]);

			result[day - 1] = 1;
			result[31 + month - 2] = 1;

			return result;
		}

		private double[] GetTime(string time)
		{
			double[] result = new double[24];
			result[Convert.ToInt32(time)] = 1;

			return result;
		}

		private double[] GetCellZone(string cellZone)
		{
			double[] result = new double[2];

			result[Convert.ToInt32(cellZone) - 1] = 1;

			return result;
		}

		private double[] GetCircle(string circle)
		{
			double[] result = new double[6];

			for (int i = 0; i < Circles.Length; i++)
			{
				if (Circles[i] == circle)
				{
					result[i] = 1;
					break;
				}
			}

			return result;
		}
	}
}
