﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Backward_Divided_Difference_method
{
    static class PointSearch
    {
        public static PointsSetTwoDimensionalSpace LookForPointsUsingBackwardNewtonFormula(
            float leftBorder, float rightBorder, float step, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            for (var i = leftBorder; i <= rightBorder; i += step)
            {
                x.Add(i);
                y.Add(Methods.NewtonBackwardMethod(i, xArray.Length, xArray, yArray, step));
            }

            return new PointsSetTwoDimensionalSpace(x, y);
        }
    }
}
