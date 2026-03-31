using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area ()
        {
            if (Width < 1 || Height < 1)
                throw new ArgumentException("error");
            return Width * Height;
        }

        public override double Perimeter ()
        {
            if (Width < 1 || Height < 1)
                throw new ArgumentException("error");
            return (Width * 2) + (Height * 2);
        }

        public override string ToString ()
        {
            throw new NotImplementedException( );
        }
    }
}
