using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using WpfMath;
//using Expr = MathNet.Symbolics.SymbolicExpression;
using System.Threading;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;



namespace Phase_Portrait_Drawer_ODE
{
    public partial class Form : System.Windows.Forms.Form
    {
        //static AutoResetEvent evt;
        //static Thread threadLatexToPNG;
        //static TexFormulaParser texFormulaParser = new TexFormulaParser();
        int buildCount = 0;
        int iter = -2000000;
        int colorNum = 0;

        public Form()
        {
            InitializeComponent();

            //evt = new AutoResetEvent(true);
            //threadLatexToPNG = new Thread(new ThreadStart(LatexToPNG));
            //threadLatexToPNG.Name = "Thread Latex to PNG";
            //threadLatexToPNG.IsBackground = true;
            //threadLatexToPNG.Start();

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            //chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //chart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart.ChartAreas[0].AxisX.RoundAxisValues();
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

        //private void LatexToPNG()
        //{
        //    while (true)
        //    {
        //        evt.WaitOne();

        //        string formula1 = textBoxFormula1.Text;
        //        string formula2 = textBoxFormula2.Text;

        //        try
        //        {
        //            if (MathNet.Symbolics.Infix.ParseOrUndefined(formula1) != MathNet.Symbolics.Expression.Undefined && MathNet.Symbolics.Infix.ParseOrUndefined(formula2) != MathNet.Symbolics.Expression.Undefined)
        //            {
        //                string latex1 = Expr.Parse(formula1).ToLaTeX();
        //                string latex2 = Expr.Parse(formula2).ToLaTeX();

        //                TexFormula texFormula1 = texFormulaParser.Parse(latex1);
        //                TexFormula texFormula2 = texFormulaParser.Parse(latex2);
        //                byte[] pngBytes1 = texFormula1.RenderToPng(400.0, 0.0, 0.0, "Arial");
        //                byte[] pngBytes2 = texFormula2.RenderToPng(400.0, 0.0, 0.0, "Arial");
        //                pictureBoxLaTeX1.Image = Image.FromStream(new MemoryStream(pngBytes1));
        //                pictureBoxLaTeX2.Image = Image.FromStream(new MemoryStream(pngBytes2));

        //                buttonDraw.BeginInvoke((MethodInvoker)(() => buttonDraw.Enabled = true));
        //            }
        //            else
        //            {
        //                pictureBoxLaTeX1.Image = null;
        //                pictureBoxLaTeX2.Image = null;
        //                buttonDraw.BeginInvoke((MethodInvoker)(() => buttonDraw.Enabled = false));
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            pictureBoxLaTeX1.Image = null;
        //            pictureBoxLaTeX2.Image = null;
        //            buttonDraw.BeginInvoke((MethodInvoker)(() => buttonDraw.Enabled = false));
        //        }
        //    }
        //}

        //private void TextBoxFormula_TextChanged(object sender, EventArgs e)
        //{
        //    evt.Set();
        //}

        //private void textBoxFormula2_TextChanged(object sender, EventArgs e)
        //{
        //    evt.Set();
        //}

        private double functionX(double x, double y)
        {
            return y;
        }

        private double functionY(double x, double y, double delta)
        {
            if (delta > 0.0d)
            {
                //Console.WriteLine("delta1 = {0}", delta);
                delta = Math.Abs(delta);
                return -1.0 * delta * y - Math.Sin(x);
            }
            else if (delta == 0.0d)
            {
                Console.WriteLine("delta2 = {0}", delta);
                //delta = Math.Abs(delta);
                return -1.0 * Math.Sin(x);
            }
            else
            {
                //Console.WriteLine("delta3 = {0}", delta);
                delta = Math.Abs(delta);
                //Console.WriteLine("delta3.1 = {0}", delta);
                double res = delta * y - Math.Sin(x);
                //Console.WriteLine("res = {0}", res);
                return res;
            }
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            //string formula1 = textBoxFormula1.Text;
            //string formula2 = textBoxFormula2.Text;
            buildCount++;

            //Func<double, double, double> functionX = Expr.Parse(formula1).Compile("x", "y");
            //Func<double, double, double> functionY = Expr.Parse(formula2).Compile("x", "y");
            double delta = Convert.ToDouble(textBoxDelta.Text.Replace(".", ","));
            double t0 = Convert.ToDouble(textBoxt0.Text.Replace(".", ","));
            double t1 = Convert.ToDouble(textBoxt1.Text.Replace(".", ","));
            double xStart = Convert.ToDouble(textBoxX.Text.Replace(".", ","));
            double yStart = Convert.ToDouble(textBoxY.Text.Replace(".", ","));
            double h = Convert.ToDouble(textBoxH.Text.Replace(".", ","));
            double xMin = Convert.ToDouble(textBoxXmin.Text.Replace(".", ","));
            double xMax = Convert.ToDouble(textBoxXmax.Text.Replace(".", ","));
            double yMin = Convert.ToDouble(textBoxYmin.Text.Replace(".", ","));
            double yMax = Convert.ToDouble(textBoxYmax.Text.Replace(".", ","));


            double x = xStart;
            double y = yStart;

            chart.Series.Add("Integral curve " + buildCount.ToString());
            chart.Series["Integral curve " + buildCount.ToString()].ChartType = SeriesChartType.Spline;
            chart.Series["Integral curve " + buildCount.ToString()]["LineTension"] = "0.2";
            chart.Series["Integral curve " + buildCount.ToString()].BorderWidth = 2;

            switch (colorNum)
            { 
                case 0: 
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Red;
                    break;
                case 1:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Blue;
                    break;
                case 2:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Green;
                    break;
                case 3:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Gold;
                    break;
                case 4:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Orange;
                    break;
                case 5:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.DarkSeaGreen;
                    break;
                case 6:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Plum;
                    break;
                default:
                    chart.Series["Integral curve " + buildCount.ToString()].Color = Color.Red;
                    break;
            }
            colorNum++;

            for (double t = t0; t <= t1; t += 0.1)
            {
                Console.WriteLine("res = {0}", t);
                double k1 = functionX(x,                 y);
                double k2 = functionX(x + 0.5d * h * k1, y + 0.5d * h * k1);
                double k3 = functionX(x + 0.5d * h * k2, y + 0.5d * h * k2);
                double k4 = functionX(x + h * k3,        y + h * k3);

                double l1 = functionY(x,                 y,                 delta);
                double l2 = functionY(x + 0.5d * h * l1, y + 0.5d * h * l1, delta);
                double l3 = functionY(x + 0.5d * h * k2, y + 0.5d * h * k2, delta);
                double l4 = functionY(x + h * l3,        y + h * l3,        delta);

                double k = 1d / 6d * (k1 + 2 * k2 + 2 * k3 + k4);
                double l = 1d / 6d * (l1 + 2 * l2 + 2 * l3 + l4);

                x = x + h * k;
                y = y + h * l;

                chart.Series["Integral curve " + buildCount.ToString()].Points.AddXY(x, y);

                //if (x > xMax || x < xMin || y > yMax || y < yMin)
                //    break;
            }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.Legends.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string formula1 = textBoxFormula1.Text;
            string formula2 = textBoxFormula2.Text;
            buildCount++;

            //Func<double, double, double> functionX = Expr.Parse(formula1).Compile("x", "y");
            //Func<double, double, double> functionY = Expr.Parse(formula2).Compile("x", "y");
            double delta = Convert.ToDouble(textBoxDelta.Text.Replace(".", ","));
            double t0 = Convert.ToDouble(textBoxt0.Text.Replace(".", ","));
            double t1 = Convert.ToDouble(textBoxt1.Text.Replace(".", ","));
            double xStart = Convert.ToDouble(textBoxX.Text.Replace(".", ","));
            double yStart = Convert.ToDouble(textBoxY.Text.Replace(".", ","));
            double h = Convert.ToDouble(textBoxH.Text.Replace(".", ","));
            double xMin = Convert.ToDouble(textBoxXmin.Text.Replace(".", ","));
            double xMax = Convert.ToDouble(textBoxXmax.Text.Replace(".", ","));
            double yMin = Convert.ToDouble(textBoxYmin.Text.Replace(".", ","));
            double yMax = Convert.ToDouble(textBoxYmax.Text.Replace(".", ","));

            double step = 2.0;
            if (iter > -2000)
                step = 3.0;
            for (double i = xMin; i < xMax; i+= step) 
            {
                for (double j = yMin; j < yMax; j+= step)
                {
                    double x = i;
                    double y = j;
                    Console.WriteLine("({0},{1})", i, j);

                    iter++;
                    chart.Series.Add("Integral curve " + iter.ToString());
                    chart.Series["Integral curve " + iter.ToString()].ChartType = SeriesChartType.Spline;
                    chart.Series["Integral curve " + iter.ToString()]["LineTension"] = "0.2";
                    chart.Series["Integral curve " + iter.ToString()].BorderWidth = 1;

                    switch (colorNum)
                    {
                        case 0:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Red;
                            break;
                        case 1:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Blue;
                            break;
                        case 2:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Green;
                            break;
                        case 3:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Gold;
                            break;
                        case 4:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Orange;
                            break;
                        case 5:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.DarkSeaGreen;
                            break;
                        case 6:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Plum;
                            break;
                        default:
                            chart.Series["Integral curve " + iter.ToString()].Color = Color.Red;
                            break;
                    }
                    for (double t = t0; t <= t1; t += 0.1)
                    {
                        double k1 = functionX(x, y);
                        double k2 = functionX(x + 0.5d * h * k1, y + 0.5d * h * k1);
                        double k3 = functionX(x + 0.5d * h * k2, y + 0.5d * h * k2);
                        double k4 = functionX(x + h * k3, y + h * k3);

                        double l1 = functionY(x, y, delta);
                        double l2 = functionY(x + 0.5d * h * l1, y + 0.5d * h * l1, delta);
                        double l3 = functionY(x + 0.5d * h * k2, y + 0.5d * h * k2, delta);
                        double l4 = functionY(x + h * l3, y + h * l3, delta);

                        double k = 1d / 6d * (k1 + 2 * k2 + 2 * k3 + k4);
                        double l = 1d / 6d * (l1 + 2 * l2 + 2 * l3 + l4);

                        x = x + h * k;
                        y = y + h * l;

                        chart.Series["Integral curve " + iter.ToString()].Points.AddXY(x, y);

                        if (x > xMax || x < xMin || y > yMax || y < yMin)
                            break;
                    }
                }
            }
            colorNum++;
        }
    }
}
