using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    // if a class doesn't specify a base class, then it automatically inherits from Object
    class Octogon : Object, IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octogon(int length)
        {
            NumberOfSides = 8;
            SideLength = length; 
        }
        

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2)); 
        }
    }
}
