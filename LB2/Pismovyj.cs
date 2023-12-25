using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    internal class Spad : Stil
    {
        private string material;
        private double varObrobky;

        public Spad(string name, double size, string material, double varObrobky) : base(name, size)
        {
            this.material = material;
            this.varObrobky = varObrobky;
        }

        public string getcolor()
        {
            return material;
        }

        public void setcolor(string material)
        {
            this.material = material;
        }
        public double getVarObrobky()
        {
            return varObrobky;
        }

        public void setVarObrobky(double varObrobky)
        {
            this.varObrobky = varObrobky;
        }

        public double fullPrice()
        {
            return varObrobky * 10;
        }
    }
}
