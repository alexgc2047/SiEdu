using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiEdu
{
    class formulas
    {
        public double f1(double x, double a, double m)
        {
            return (x - a) / (m - a);
        }

        public double f2(double x, double b, double m)
        {
            return (b - x) / (b - m);
        }
    }
}
