using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double Radius { set; get; }

        public double GetDiameter()
        {
            return 2*Radius;
        }

        public double GetPerimeter()
        {
            return  2*Math.PI*Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
