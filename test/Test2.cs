using Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Test2
    {
        [Fact]
        public void CheckMethodForTriangleArea ()
        {
            Triangle triangle = new Triangle( );
            triangle.SideA = 13;
            triangle.SideB = 14;
            triangle.SideC = 15;

            var res = 84;
            Assert.Equal(res, triangle.Area( ));
        }
        [Fact]
        public void CheckMethodForTrianglePerimetr ()
        {
            Triangle triangle = new Triangle( );
            triangle.SideA = 10;
            triangle.SideB = 10;
            triangle.SideC = 10;

            var res = 30;
            Assert.Equal(res, triangle.Perimeter( ));
        }
    }
}
