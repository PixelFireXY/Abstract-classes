using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    //base abstract class to use as a template for all the derived classes
    public abstract class Figure
    {
        public float FArea { get; protected set; }

        public abstract void CalculateArea();

        public virtual string GetFigureType()
        {
            return "Generic figure";
        }
    }
}
