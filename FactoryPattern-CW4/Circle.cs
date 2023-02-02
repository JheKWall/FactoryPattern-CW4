using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CW4
{
    class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle has been drawn.\n");
        }
    }
}
