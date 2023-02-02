using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_CW4
{
    class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line has been drawn.\n");
        }
    }
}
