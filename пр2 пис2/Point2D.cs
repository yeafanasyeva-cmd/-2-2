using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class Point2D
    {
        public enum Color
        {
            Red,
            Green,
            Blue,
            LightBlue
        }

        public double X { get; }
        public double Y { get; }
        public Color PointColor { get; }
        public bool IsActive { get; set; } = true;

        public Point2D(double x, double y, Color color)
        {
            X = x;
            Y = y;
            PointColor = color;
        }

        public override string ToString()
        {
            return $"(X: {X}, Y: {Y}, Цвет: {PointColor})";
        }
    }
}
