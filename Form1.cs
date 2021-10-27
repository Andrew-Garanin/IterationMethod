using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        double p_delta;
        double p_epsilon;
        int param_m;
        int param_n;
        int param_p;
        double p_x0;
        GraphPane pane;


        public Form1()
        {
            InitializeComponent();
        }

        public void FillValues()
        {
            p_A = Convert.ToDouble(A.Text);
            p_B = Convert.ToDouble(B.Text);
            p_C = Convert.ToDouble(C.Text);
            p_D = Convert.ToDouble(D.Text);
            p_alpha = Convert.ToDouble(alpha.Text);
            p_beta = Convert.ToDouble(beta.Text);
            p_gamma = Convert.ToDouble(gamma.Text);
            p_delta = Convert.ToDouble(delta.Text);
            p_epsilon = Convert.ToDouble(epsilon.Text);
            param_m = Convert.ToInt32(m.Text);
            param_n = Convert.ToInt32(n.Text);
            param_p = Convert.ToInt32(p.Text);
            p_x0 = Convert.ToDouble(x0.Text);
        }

        public double Function(double x1, double alpha1, double beta1, double gamma1, double delta1, double epsilon1)
        {
            if (x1 - gamma1 != 0)
            {
                //return alpha1 * Math.Sin(beta1 / Math.Pow((x1 - gamma1), 2)) + delta1 * Math.Cos(epsilon1 * x1);
                //return (alpha1 * Math.Sin(beta1 / ((x1 - gamma1) * (x1 - gamma1))) + delta1 * Math.Cos(epsilon1 * x1));
                //return Math.Sin(alpha1)+x1;
                return alpha1 * Math.Sin(Math.Tan(beta1 * x1)) * Math.Sin(gamma1 * x1);
            }
            else
            {
                Random rand = new Random();
                return rand.NextDouble() * (p_D - p_C) + p_C;
            }
        }

        private void ButtonN_Click(object sender, EventArgs e)
        {
            FillValues();
            pane = pointChart.GraphPane;
            PointPairList points = new PointPairList();

            double h = Math.Abs(p_B - p_A) * 0.001;
            pane.YAxis.Title = "X";
            if (checkAlpha.Checked)
                pane.XAxis.Title = "α";
            if (checkBeta.Checked)
                pane.XAxis.Title = "β";
            if (checkGamma.Checked)
                pane.XAxis.Title = "γ";
            if (checkDelta.Checked)
                pane.XAxis.Title = "∂";
            if (checkEpsilon.Checked)
                pane.XAxis.Title = "ε";
            List<Double> paramsValues = new List<Double>();
            for (double param_i = p_A; param_i <= p_B; param_i += h)
            {
                paramsValues.Add(Math.Round(param_i, 5));
            }

            foreach (double p_i in paramsValues)
            { 
                List<Double> x_j = new List<Double>();
                x_j.Add(p_x0);
                for (int j = 1; j < param_m; j++) 
                {
                    
                        if (checkAlpha.Checked)
                        {
                            double value = Function(x_j[j - 1], p_i, p_beta, p_gamma, p_delta, p_epsilon);
                            x_j.Add(value);
                            if (j < param_n)
                            {
                                points.Add(p_i, value);
                            }
                        }
                        if (checkBeta.Checked)
                        {
                            double value = Function(x_j[j - 1], p_alpha, p_i, p_gamma, p_delta, p_epsilon);
                            x_j.Add(value);
                            if (j < param_n)
                            {
                                points.Add(p_i, value);
                            }
                        }
                        if (checkGamma.Checked)
                        {
                            double value = Function(x_j[j - 1], p_alpha, p_beta, p_i, p_delta, p_epsilon);
                            x_j.Add(value);
                            if (j < param_n)
                            {
                                points.Add(p_i, value);
                            }
                        }

                        if (checkDelta.Checked)
                        {
                            double value = Function(x_j[j - 1], p_alpha, p_beta, p_gamma, p_i, p_epsilon);
                            x_j.Add(value);
                            if (j < param_n)
                            {
                                points.Add(p_i, value);
                            }
                        }
                        if (checkEpsilon.Checked)
                        {
                            double value = Function(x_j[j - 1], p_alpha, p_beta, p_gamma, p_delta, p_i);
                            x_j.Add(value);
                            if (j < param_n)
                            {
                                points.Add(p_i, value);
                            }
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

        private void ButtonP_Click(object sender, EventArgs e)
        {
            FillValues();
            pane = pointChart.GraphPane;
            PointPairList points = new PointPairList();
            double h = Math.Abs(p_B - p_A) * 0.001;
            pane.YAxis.Title = "X";
            if (checkAlpha.Checked)
                pane.XAxis.Title = "α";
            if (checkBeta.Checked)
                pane.XAxis.Title = "β";
            if (checkGamma.Checked)
                pane.XAxis.Title = "γ";
            if (checkDelta.Checked)
                pane.XAxis.Title = "∂";
            if (checkEpsilon.Checked)
                pane.XAxis.Title = "ε";
            List<Double> paramsValues = new List<Double>();
            for (double param_i = p_A; param_i <= p_B; param_i += h)
            {
                paramsValues.Add(Math.Round(param_i, 5));
            }

            foreach (double p_i in paramsValues)
            {
                List<Double> x_j = new List<Double>();
                x_j.Add(p_x0);
                for (int j = 1; j < param_m; j++)
                {

                    if (checkAlpha.Checked)
                    {
                        double value = Function(x_j[j - 1], p_i, p_beta, p_gamma, p_delta, p_epsilon);
                        x_j.Add(value);
                        if (j < param_n && j % param_p == 0)
                        {
                            points.Add(p_i, value);
                        }
                    }
                    if (checkBeta.Checked)
                    {
                        double value = Function(x_j[j - 1], p_alpha, p_i, p_gamma, p_delta, p_epsilon);
                        x_j.Add(value);
                        if (j < param_n && j % param_p == 0)
                        {
                            points.Add(p_i, value);
                        }
                    }
                    if (checkGamma.Checked)
                    {
                        double value = Function(x_j[j - 1], p_alpha, p_beta, p_i, p_delta, p_epsilon);
                        x_j.Add(value);
                        if (j < param_n && j % param_p == 0)
                        {
                            points.Add(p_i, value);
                        }
                    }

                    if (checkDelta.Checked)
                    {
                        double value = Function(x_j[j - 1], p_alpha, p_beta, p_gamma, p_i, p_epsilon);
                        x_j.Add(value);
                        if (j < param_n && j % param_p == 0)
                        {
                            points.Add(p_i, value);
                        }
                    }
                    if (checkEpsilon.Checked)
                    {
                        double value = Function(x_j[j - 1], p_alpha, p_beta, p_gamma, p_delta, p_i);
                        x_j.Add(value);
                        if (j < param_n && j % param_p == 0)
                        {
                            points.Add(p_i, value);
                        }
                    }
                }
            }
            LineItem curve = pane.AddCurve(" ", points, Color.Blue, SymbolType.Circle);
            curve.Line.IsVisible = false;
            curve.Symbol.Fill.Color = Color.Blue;
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
