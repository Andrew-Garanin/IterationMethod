using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace IterationMethod
{
    public partial class Form1 : Form
    {
        double p_A;
        double p_B;
        double p_C;
        double p_D;
        double p_alpha;
        double p_beta;
        double p_gamma;
        int param_m;
        int param_n;
        int param_p;
        double p_x0;
        GraphPane pane;


        public Form1()
        {
            InitializeComponent();
        }

        public bool ValidateParamsAndSizes(double param)
        {
            if (param < -100 || param > 100)
                return false;
            return true;
        }

        public bool ValidateNumberIterationsParams(double param)
        {
            if (param <= 0 || param > 500)
                return false;
            return true;
        }

        public bool ValidateP(int param)
        {
            if (param < 1 || param > 25)
                return false;
            return true;
        }

        public bool ValidateX0(double x0, double c, double d)
        {
            if (x0 < c || x0 > d)
                return false;
            return true;
        }

        public bool FillValues()
        {
            try
            {
                p_A = Convert.ToDouble(A.Text);
                if (!ValidateParamsAndSizes(p_A))
                {
                    MessageBox.Show("Параметр A должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_B = Convert.ToDouble(B.Text);
                if (!ValidateParamsAndSizes(p_B))
                {
                    MessageBox.Show("Параметр B должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_C = Convert.ToDouble(C.Text);
                if (!ValidateParamsAndSizes(p_C))
                {
                    MessageBox.Show("Параметр C должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_D = Convert.ToDouble(D.Text);
                if (!ValidateParamsAndSizes(p_D))
                {
                    MessageBox.Show("Параметр D должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_alpha = Convert.ToDouble(alpha.Text);
                if (!ValidateParamsAndSizes(p_alpha))
                {
                    MessageBox.Show("Параметр α должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_beta = Convert.ToDouble(beta.Text);
                if (!ValidateParamsAndSizes(p_beta))
                {
                    MessageBox.Show("Параметр β должен принадлежать диапозону [-100;100].");
                    return false;
                }
                p_gamma = Convert.ToDouble(gamma.Text);
                if (!ValidateParamsAndSizes(p_gamma))
                {
                    MessageBox.Show("Параметр γ должен принадлежать диапозону [-100;100].");
                    return false;
                }

                param_m = Convert.ToInt32(m.Text);
                if (!ValidateNumberIterationsParams(param_m))
                {
                    MessageBox.Show("Параметр m должен принадлежать диапозону (0;500].");
                    return false;
                }
                param_n = Convert.ToInt32(n.Text);
                if (!ValidateNumberIterationsParams(param_n))
                {
                    MessageBox.Show("Параметр n должен принадлежать диапозону (0;500].");
                    return false;
                }

                param_p = Convert.ToInt32(p.Text);
                if (!ValidateP(param_p))
                {
                    MessageBox.Show("Параметр p должен принадлежать диапозону [1;25].");
                    return false;
                }
                p_x0 = Convert.ToDouble(x0.Text);
                if (!ValidateX0(p_x0, p_C, p_D))
                {
                    MessageBox.Show("Параметр x0 должен принадлежать диапозону [C;D].");
                    return false;
                }
                return true;
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public double Function(double x, double alpha, double beta, double gamma)
        {
            if (x - gamma != 0)
            {
                return alpha * Math.Sin(Math.Tan(beta * x)) * Math.Sin(gamma * x);
            }
            else
            {
                Random rand = new Random();
                return rand.NextDouble() * (p_D - p_C) + p_C;
            }
        }

        private void ButtonN_Click(object sender, EventArgs e)
        {
            if (!FillValues())
                return;
            pane = pointChart.GraphPane;
            pane.Legend.IsVisible = false;
            pane.Title = "";
            PointPairList points = new PointPairList();

            double h = Math.Abs(p_B - p_A) * 0.001;
            pane.YAxis.Title = "X";
            if (checkAlpha.Checked)
                pane.XAxis.Title = "α";
            if (checkBeta.Checked)
                pane.XAxis.Title = "β";
            if (checkGamma.Checked)
                pane.XAxis.Title = "γ";
            List<Double> paramsValues = new List<Double>();
            for (double param_i = p_A; param_i <= p_B; param_i += h)
            {
                paramsValues.Add(Math.Round(param_i, 5));
            }

            foreach (double p_i in paramsValues)
            {
                List<Double> x_j = new List<Double>();
                double newValue = p_x0;
                for (int j = 1; j < param_m; j++)
                {
                    if (checkAlpha.Checked)
                    {
                        newValue = Function(newValue, p_i, p_beta, p_gamma);
                    }
                    if (checkBeta.Checked)
                    {
                        newValue = Function(newValue, p_alpha, p_i, p_gamma);
                    }
                    if (checkGamma.Checked)
                    {
                        newValue = Function(newValue, p_alpha, p_beta, p_i);
                    }
                }

                x_j.Add(newValue);
                for (int curN = 0; curN < param_n; curN++)
                {
                    if (checkAlpha.Checked && curN % param_p ==0)
                    {
                        double value = Function(x_j[x_j.Count - 1], p_i, p_beta, p_gamma);
                        x_j.Add(value);
                        points.Add(p_i, value);
                    }
                    if (checkBeta.Checked && curN % param_p == 0)
                    {
                        double value = Function(x_j[x_j.Count - 1], p_alpha, p_i, p_gamma);
                        x_j.Add(value);
                        points.Add(p_i, value);

                    }
                    if (checkGamma.Checked && curN % param_p == 0)
                    {
                        double value = Function(x_j[x_j.Count - 1], p_alpha, p_beta, p_i);
                        x_j.Add(value);
                        points.Add(p_i, value);

                    }
                }
            }

            LineItem curve = pane.AddCurve(" ", points, Color.Red, SymbolType.Circle);
            curve.Line.IsVisible = false;
            curve.Symbol.Fill.Color = Color.Red;
            curve.Symbol.Fill.Type = FillType.Solid;
            curve.Symbol.Size = 1;


            pane.XAxis.Min = p_A;
            pane.XAxis.Max = p_B;
            pane.YAxis.Min = p_C;
            pane.YAxis.Max = p_D;

            pointChart.AxisChange();
            pointChart.Invalidate();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            pointChart.GraphPane.CurveList.Clear();
            pointChart.Invalidate();
        }
    }
}
