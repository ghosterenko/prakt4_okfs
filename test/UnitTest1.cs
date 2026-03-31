using Shape;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void CreateRectangle ()
        {
            Rectangle rectangle = new Rectangle( );
            Assert.NotNull(rectangle);
        }
        [Fact]
        public void CreateTriangle ()
        {
            Triangle triangle = new Triangle( );
            Assert.NotNull(triangle);
        }
        [Fact]
        public void CheckMethodAreaForReacangle ()
        {
            Rectangle rectangle = new Rectangle( );
            rectangle.Width = 10;
            rectangle.Height = 10;
            var result = 100;
            Assert.Equal(result, rectangle.Area( ));

        }
        [Fact]
        public void CheckMethodPerimeterForReacangle ()
        {
            Rectangle rectangle = new Rectangle( );
            rectangle.Width = 10;
            rectangle.Height = 10;
            var result = 40;
            Assert.Equal(result, rectangle.Perimeter( ));
        }
        [Fact]
        public void ValidationCorrectDataRectangleAreaNegativeNumbers ()
        {
            Rectangle rectangle = new Rectangle( );
            rectangle.Width = 2;
            rectangle.Height = 0;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Area( ));

            Assert.Equal("error", ex.Message);

        }
        [Fact]
        public void ValidationCorrectDataRectanglePerimeterNegativeNumbers ()
        {
            Rectangle rectangle = new Rectangle( );
            rectangle.Width = -2;
            rectangle.Height = 0;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Perimeter( ));

            Assert.Equal("error", ex.Message);

        }
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