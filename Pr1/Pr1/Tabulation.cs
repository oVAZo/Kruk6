﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Tabulation
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {

            double result = Math.Pow(Math.Abs(x), 5) * (1 / Math.Tan(x + 2));
            return result;
        }
        private double f2(double x)
        {
            double result = (5 * x + Math.Pow(x, 2)) /  Math.Pow(Math.Pow(x, 2) + 3 , 3);
            return result;

        }

        private double f3(double x)
        {
            double P = Math.PI;
            double numerator = Math.Pow(Math.Sin(x + 3), 2);
            double denominator = Math.Pow(x, 5) - 1 / Math.Tan(P * Math.Pow(x, 3));

            double result = numerator / denominator;
            return result;

        }


        public void tab(double xn = 3.35, double xk = 36.26, double h = 0.2, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
