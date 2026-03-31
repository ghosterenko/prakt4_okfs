using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public override double Area ()
        {

            if (SideA < 1 || SideB < 1 || SideC < 1)
                throw new ArgumentException("error");

            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double Perimeter ()
        {
            if (SideA < 1 || SideB < 1 || SideC < 1)
                throw new ArgumentException("error");
            return SideA + SideB + SideC;
        }

        public override string ToString ()
        {
            throw new NotImplementedException( );
        }
    }
}
