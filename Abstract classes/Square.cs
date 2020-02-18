using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    class Square : Figure
    {
        float side = 5f;

        public override void CalculateArea()
        {
            FArea = side * side;
        }

        public override string GetFigureType()
        {
            return "Square";
        }
    }
}
