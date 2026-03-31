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
            rectangle.Width = -2;
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
       
    }
}