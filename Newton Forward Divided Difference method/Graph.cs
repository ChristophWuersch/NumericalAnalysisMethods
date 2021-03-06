﻿using System.Windows.Forms;

namespace Newton_Forward_Divided_Difference_method
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            double[] xArray = { 0.101, 0.106, 0.111, 0.116, 0.121, 0.126, 0.131, 0.136, 0.141, 0.146 };
            double[] yArray = { 1.26183, 1.27644, 1.29122, 1.30617, 1.32130, 1.33660, 1.35207, 1.36773, 1.38357, 1.39959 };

            const float LeftBorder = 0.05f;
            const float RightBorder = 0.35f;
            const float Step = 0.001f;

            NewtonPolynomial.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            PointsSetTwoDimensionalSpace pointsSet = PointsSearch.LookForPointsUsingForwardNewtonFormula(
                LeftBorder, RightBorder, Step, xArray, yArray);

            NewtonPolynomial.Series[0].Points.DataBindXY(pointsSet.X, pointsSet.Y);
        }
    }
}
