using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    public class Triangle : Figure
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

        public override string Draw()
        {
            return $"[Треугольник: A: {A}, B: {B}, C: {C}]";
        }

        public override string GetFigureType()
        {
            return "Треугольник";
        }

        public override int GetPointCount()
        {
            return 3;
        }

        public override List<Point2D> GetPoints()
        {
            return new List<Point2D> { A, B, C };
        }

        public override string ToString()
        {
            return Draw();
        }
    }
}
