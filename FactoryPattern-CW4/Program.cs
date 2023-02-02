using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a ShapeFactory and IGeometricShape object.
            ShapeFactory shapeFactory = new ShapeFactory();
            IGeometricShape geometricShape;

            //Loops through all variables in the ShapeType Enum
            foreach (ShapeType shape in Enum.GetValues(typeof(ShapeType)))
            {
                geometricShape = shapeFactory.getShape(shape);
                if (geometricShape != null)
                {
                    geometricShape.draw();
                }
                else
                {
                    Console.WriteLine(shape.ToString() + " does not exist.\n");
                }
            }

            //Exit prompt
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
