﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octogon = new Octogon(5);
            DisplayPolygon("Octogon", octogon);

            Console.ReadLine();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Number of Sides: {1}", polygonType, polygon.NumberOfSides);
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n {1}", polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}
