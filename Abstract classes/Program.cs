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
            Square square = new Square();

            square.CalculateArea();

            Console.WriteLine(string.Format("The {0} side value is: {1}", square.GetFigureType(), square.FArea));

            Console.ReadLine();
        }
    }
}
