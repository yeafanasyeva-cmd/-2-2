using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class Circle : Figure
    {
        public Point2D A { get; }
        public Circle(Point2D p)
        {
            A = p;
        }
        public override string Draw()
        {
            return "Центр круга - {A}";
        }
    }
}
