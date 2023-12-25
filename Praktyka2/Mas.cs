using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktyka2
{
    internal class Mas
    {
        private int[] mass;

        public Mas()
        {
            mass = new int[0];
        }

        public Mas(int size)
        {
            Random rand = new Random();
            mass = new int[size];

            for (int i = 0; i < size; i++)
            {
                mass[i] = rand.Next(-10, 10);
            }
        }

        public int Length
        {
            get { return mass.Length; }
        }

        public int this[int index]
        {
            get { return mass[index]; }
        }

        public int[] Getter()
        {
            return mass;
        }

        public int CountNegativeElements()
        {
            int count = 0;

            foreach (int element in mass)
            {
                if (element < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

