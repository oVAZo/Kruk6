using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    internal class Semicycle
    {
        public double Radius;
        public double CenterX = 5;
        public double CenterY = 5;

        public Semicycle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return 0.5 * Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateArcLength()
        {
            return 0.5 * Math.PI * Radius;

        }

        public string CheckPoint(double x, double y)
        {
            // Використовуємо рівняння півкола: (x - centerX)^2 + (y - centerY)^2 <= radius^2
            double distanceSquared = Math.Pow(x - CenterX, 2) + Math.Pow(y - CenterY, 2);
            bool isInside = distanceSquared <= Math.Pow(Radius, 2);

            if (isInside)
            {
                return "Точки співпали";
            }
            else
            {
                return "Данна точка не співпала";
            }
        }
    }
}
