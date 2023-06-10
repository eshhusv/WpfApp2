using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Triangle
    {
        public double leg1 { get; set; }
        public double leg2 { get; set; }
        public Triangle(double Leg1, double Leg2)
        {
            Leg1 = leg1;
            Leg2 = leg2;
        }
    }
}