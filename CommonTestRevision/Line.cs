using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTestRevision
{
    class Line
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Line() { }
        public Line(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double FindIntersectionX(Line l)
        {
            return (double)(B * l.C - l.B * C) / (A * l.B - B * l.A);
        }

        public double FindIntersectionY(Line l)
        {
            return 0;
        }
    }
}
