using Xunit;

namespace Facade.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IShape circle = new Circle();
            IShape square = new Square();
            IShape rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
            circle.Draw();
            circle.Draw();
            square.Draw();
        }

        [Fact]
        public void Test2()
        {
            ComplexShapeMaker complexShapeMaker = new ComplexShapeMaker();
            complexShapeMaker.DrawComplexForm();
        }
    }
}