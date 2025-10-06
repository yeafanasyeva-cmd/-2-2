using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class Triangle : Figure
    {
        public Point2D A { get; }
        public Point2D B { get; }
        public Point2D C { get; }
        public bool IsActive { get; set; } = false;

        public Triangle(Point2D a, Point2D b, Point2D c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override string ToString()
        {
            return $"[A: {A}, B: {B}, C: {C}]";
        }
        public override string Draw()
        {
            return $"[A: {A}, B: {B}, C: {C}]";
        }
    }
}
