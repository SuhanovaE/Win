using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figure.Classes
{
     class Circle : Figures
    {
        private double Radius;
        public Circle(double r)
        {
            Radius = r;
        }
        override public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Square()
        {
            return Math.PI * Radius * Radius;
            
        }
    }
}
