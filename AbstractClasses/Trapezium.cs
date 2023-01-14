using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Trapezium:Figure
    {
        private double a;
        private double b;
        private double c;
        private double h;
        public double A
        {
            get { return a; }
            set { if(value>0) a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (value > 0) c = value; }
        }
        public double H
        {
            get { return h; }
            set { if (value > 0) h = value; }
        }

        public Trapezium(double a, double b, double c, double h)
        {
            A = a;
            B = b;
            C = c;
            H = h;
        }

        public override double Area()
        {
            return (a+b)*h/2;
        }

        public override double Perimeter()
        {
            return a+b+2*c;
        }
    }
}
