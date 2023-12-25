using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public class Calculation_abc
    {

        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }

        public Calculation_abc(int num1, int num2, int num3)
        {
            Number1 = num1;
            Number2 = num2;
            Number3 = num3;
        }

        public int CalculateResult()
        {
            if (Number1 > 5 || Number2 > 5 || Number3 > 5)
            {
                // Якщо хоча б одне число більше за 5, знайти куб суми
                int sum = Number1 + Number2 + Number3;
                return (int)Math.Pow(sum, 3);
            }
            else
            {
                // Інакше знайти суму
                return Number1 + Number2 + Number3;
            }
        }
    }
}
