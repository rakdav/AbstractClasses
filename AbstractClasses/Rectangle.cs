using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Rectangle:Figure
    {
        private double width;
        private double height;
        public double Width
        { 
            get { return width; } 
            set {
                    if(value>0) width = value; 
                } 
        }
        public double Height
        {
            get { return height; }
            set { if(value>0) height = value; }
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return width*height;
        }

        public override double Perimeter()
        {
           return 2*(width+height);
        }
    }
}
