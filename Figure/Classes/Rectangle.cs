using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Classes
{
    class Rectangle : Figures
    {
        private double Sidel, Side2;
        public Rectangle(double s1, double s2)
        {
            Sidel = s1;
            Side2 = s2;
        }
        override public double Perimeter()
        {
            return 2 * (Sidel + Side2);
        }
        override public double Square()
        {
            return Sidel * Side2;
        }
    }

}
