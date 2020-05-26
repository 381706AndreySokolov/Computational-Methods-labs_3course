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


namespace VM_lab_4
{
    public partial class Form1 : Form
    {
		// коэффициенты функции начального распределения
		double phi_a;
		double phi_b;
		double phi_c;

		// коэффициенты функции воздействия на стержень
		double b_a;
		double b_b;
		double b_c;

		int T; // время воздействия на стержень
		int l; // длина стержня
		double h ; // длина шага по х
		double tau; // длина шага по времени

		int xSteps;
		int tSteps;

		double[,] yRes;

		public Form1()
        {
            InitializeComponent();
			chart.ChartAreas[0].AxisX.IsMarginVisible = false;
			chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
			chart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
			chart.ChartAreas[0].AxisX.RoundAxisValues();
			chart.ChartAreas[0].AxisX.Interval = 1;

			this.KeyDown += new KeyEventHandler(PrintGreen);

			// Progress Bar
			progressBar1.Minimum = 0;
			progressBar1.Value = 0;
			progressBar1.Step = 1;

			this.KeyPreview = true;
		}

		private void Run_Click(object sender, EventArgs e)
        {
			chart.Series.Clear();
			chart.Legends.Clear();
			T = Convert.ToInt32(textBoxT.Text);
			l = Convert.ToInt32(textBoxL.Text);
			h = Convert.ToDouble(textBoxH.Text.Replace(".", ","));
			tau = Convert.ToDouble(textBoxTau.Text.Replace(".", ","));

			phi_a = 1.0 / (double)l;
			phi_b = Convert.ToDouble(textBoxFi1.Text.Replace(".", ","));
			phi_c = Convert.ToDouble(textBoxFi2.Text.Replace(".", ","));
			b_a = Convert.ToDouble(textBoxB0.Text.Replace(".", ","));
			b_b = Convert.ToDouble(textBoxB1.Text.Replace(".", ","));
			b_c = Convert.ToDouble(textBoxB2.Text.Replace(".", ","));

			// Число шагов по x
			xSteps = (int)((double)l / h) + 1;

			// Число шагов по времени
			tSteps = (int)((double)T / tau) + 1;

			progressBar1.Minimum = 0;
			progressBar1.Maximum = tSteps;
			progressBar1.Value = 0;
			progressBar1.Step = 1;

			yRes = new double[xSteps, tSteps];
			var timer = System.Diagnostics.Stopwatch.StartNew();

			double x = 0;

			// Начальное распределение температуры
			for (int idx = 0; idx < xSteps; ++idx)
			{
				yRes[idx, 0] = FuncPhi(x);
				x += h;
			}

			// Инициализация коэффициентов трехдиагональной матрицы
			double[] upDiagonal = new double[xSteps - 1];
			double[] midDiagonal = new double[xSteps];
			double[] downDiagonal = new double[xSteps - 1];

			for (int idx = 0; idx < xSteps - 1; ++idx)
			{
				if (idx == 0) 
					upDiagonal[idx] = -2 * tau;
				else
					upDiagonal[idx] = -1 * tau;
			}
			for (int idx = 0; idx < xSteps; ++idx)
			{
				midDiagonal[idx] = h * h + 2 * tau;
			}
			for (int idx = 0; idx < xSteps - 1; ++idx)
			{
				if (idx == xSteps - 2)
					downDiagonal[idx] = -2 * tau;
				else
					downDiagonal[idx] = -1 * tau;
			}


			// Вычисление температуры
			for (int t = 1; t < tSteps; ++t)
			{
				x = 0;
				// Вычисление вектора правой части СЛАУ - d
				double[] d = new double[xSteps];
				double simpson = SimpsonMethod(t - 1);
				for (int idx = 0; idx < xSteps; ++idx)
				{
					d[idx] = yRes[idx, t - 1] * h * h * ((tau * (FuncB(x) - simpson)) + 1);
					x += h;
				}

				// Решение СЛАУ методом прогонки
				Solve(downDiagonal, midDiagonal, upDiagonal, d, t);

				this.Invoke(new Action(() => { progressBar1.PerformStep(); }));
			}

			timer.Stop();

			labelWorkTime.Text = "Время работы: " + ((timer.Elapsed).TotalMilliseconds).ToString("n");

			// Далее идет отрисовка графика, сама задача решена
			chart.ChartAreas[0].AxisX.Minimum = 0;
			chart.ChartAreas[0].AxisX.Maximum = l;

			chart.Series.Add("0");
			chart.Series["0"].ChartType = SeriesChartType.Spline;
			chart.Series["0"].Color = Color.Blue;
			//chart.Series["0"].BorderWidth = 2;

			chart.Series.Add("1");
			chart.Series["1"].ChartType = SeriesChartType.Spline;
			chart.Series["1"].Color = Color.Red;
			//chart.Series["1"].BorderWidth = 2;

			chart.Series.Add("2");
			chart.Series["2"].ChartType = SeriesChartType.Spline;
			chart.Series["2"].Color = Color.Green;
			chart.Series["2"].BorderWidth = 2;
			chart.Series["2"].Enabled = false;

			x = 0.0;
			for (int idx = 0; idx < xSteps; ++idx)
			{
				chart.Series["0"].Points.AddXY(x, yRes[idx, 0]);
				chart.Series["1"].Points.AddXY(x, yRes[idx, tSteps - 1]);
				chart.Series["2"].Points.AddXY(x, yRes[idx, tSteps - 1]);
				x += h;
			}
			progressBar1.Value = tSteps;
			labelWorkTime.Focus();
		}

		// Очистить график
        private void Clear_Click(object sender, EventArgs e)
        {
			chart.Series.Clear();
		}

		// Функция начального распределения температуры
		double FuncPhi(double x)
		{
			return phi_a + phi_b * Math.Cos(Math.PI * x / l) + phi_c * Math.Cos(2.0 * Math.PI * x / l);
		}

		// Функция, определяющая воздействие на стержень
		double FuncB(double x)
		{
			return b_a + b_b * Math.Cos(Math.PI * x / l) + b_c * Math.Cos(2.0 * Math.PI * x / l);
		}
		
		// Вычисление интеграла методом Симпсона в формуле управления
		private double SimpsonMethod(int t)
		{
			double x = h;
			double res = FuncB(0) * yRes[0, t];
			for (int i = 1; i < xSteps - 1; ++i)
			{
				res += FuncB(x) * ((i % 2 == 0) ? 2 : 4) * yRes[i, t];
				x += h;
			}
			res += FuncB(x) * yRes[xSteps - 1, t];
			return res * (h / 3);
		}

		// Решенне СЛАУ трехдиагональной матрицы методом прогонки
		public void Solve(double[] downDiagonal, double[] midDiagonal, double[] upDiagonal, double[] d, int t)
		{
			int length = midDiagonal.Length;

			if (length == downDiagonal.Length + 1 && length == upDiagonal.Length + 1 && length == d.Length)
			{
				double[] alpha = new double[length - 1];
				double[] beta = new double[length - 1];

				alpha[0] = -upDiagonal[0] / midDiagonal[0];
				beta[0] = d[0] / midDiagonal[0];

				for (int i = 1; i < length - 1; i++)
				{
					double gamma = midDiagonal[i] + downDiagonal[i - 1] * alpha[i - 1];
					alpha[i] = -upDiagonal[i] / gamma;
					beta[i] = (d[i] - downDiagonal[i - 1] * beta[i - 1]) / gamma;
				}
				yRes[length - 1, t] = (d[length - 1] - downDiagonal[length - 2] * beta[length - 2])
					/ (midDiagonal[length - 1] + downDiagonal[length - 2] * alpha[length - 2]);

				for (int i = length - 2; i >= 0; i--)
				{
					yRes[i, t] = alpha[i] * yRes[i + 1, t] + beta[i];
				}
			}
		}

		private void PrintGreen(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space) {
				if (!chart.Series["2"].Enabled)
					chart.Series["2"].Enabled = true;
				else
					chart.Series["2"].Enabled = false;
				e.Handled = false;
			}
		}
	}
}
