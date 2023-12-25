using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public class CalculationAB
    {
        int a, b;

        public CalculationAB(int a, int b)
        {
            if (a >= b)
            {
                throw new ArgumentOutOfRangeException("A should be less than B");
            }
            this.a = a;
            this.b = b;
        }

        public int A { get { return a; } }
        public int B { get { return b; } }

        public int Sun()
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 44 == 0 && i % 2 != 0 && i % 5 == 3)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
