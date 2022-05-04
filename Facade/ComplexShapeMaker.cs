using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ComplexShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _square;

        public ComplexShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawComplexForm()
        {
            _circle.Draw();
            _rectangle.Draw();
            _circle.Draw();
            _circle.Draw();
            _square.Draw();
        }
    }
}
