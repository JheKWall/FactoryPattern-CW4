using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CW4
{
    class ShapeFactory
    {
        public IGeometricShape getShape(ShapeType shape)
        {
            switch(shape)
            {
                case ShapeType.Circle:
                    Circle circle = new Circle();
                    return circle;

                case ShapeType.Rectangle:
                    Rectangle rectangle = new Rectangle();
                    return rectangle;

                case ShapeType.Line:
                    Line line = new Line();
                    return line;

                case ShapeType.Triangle:
                    return null;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
