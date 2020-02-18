using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance with the derived class (abstract classes cannot be instantiated)
            Square square = new Square();

            //call a method to calculate the area of the figure
            square.CalculateArea();

            //print the result
            Console.WriteLine(string.Format("The {0} side value is: {1}", square.GetFigureType(), square.FArea));

            Console.ReadLine();
        }
    }
}
