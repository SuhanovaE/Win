using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.Classes
{
     class Triangle : Figures
    {
        private double Sidel, Side2, Side3;
        public bool Exists
        {
            get
            {
                return (Sidel + Side2 > Side3) && (Sidel + Side3 > Side2) && (Side2 + Side3 > Sidel);
            }
        }
        public Triangle(double s1, double s2, double s3)
        {
            Sidel = s1;
            Side2 = s2;
            Side3 = s3;
        }
        public override double Perimeter()
        {
            return Sidel + Side2 + Side3;
        }
       
        public override double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Sidel) * (p - Side2) * (p - Side3));
        }
    }
}
