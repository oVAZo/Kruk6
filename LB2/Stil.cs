using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    internal class Stil
    {
        private string name;
        private double size;

        public Stil(string name, double size)
        {
            this.name = name;
            this.size = size;

        }

        public string getname()
        {
            return name;
        }

        public void setname(string name)
        {
            this.name = name;
        }

        public double getsize()
        {
            return size;
        }

        public void setsize(double size)
        {
            this.size = size;
        }


        public double Price()
        {
            return (size * 2 / 3) + 50;
        }
    }
}
