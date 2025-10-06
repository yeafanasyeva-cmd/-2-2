using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class ColoredTriangle : Triangle
    {
        public string Description { get; }
        public bool IsVisible { get; }
        public bool IsActive { get; set; } = false;

        public ColoredTriangle(Point2D a, Point2D b, Point2D c, string description)
            : base(a, b, c)
        {
            Description = description;
            IsVisible = true;
        }

        public bool HasUniformColor()
        {
            return A.PointColor == B.PointColor && B.PointColor == C.PointColor;
        }

        public override string Draw()
        {
            string colorInfo = HasUniformColor() ? " (одноцветный)" : " (разноцветный)";
            return $"[Цветной треугольник: {Description}{colorInfo}, A: {A}, B: {B}, C: {C}]";
        }
    }
}