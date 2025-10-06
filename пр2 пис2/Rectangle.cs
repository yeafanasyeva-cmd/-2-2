using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class Rectangle
    {
        public Point2D Point1 { get; }
        public Point2D Point2 { get; }
        public Point2D Point3 { get; }
        public Point2D Point4 { get; }
        public bool IsActive { get; set; } = false;

        public Rectangle(Point2D point1, Point2D point2, Point2D point3, Point2D point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        public override string ToString()
        {
            return $"Прямоугольник: {Point1}, {Point2}, {Point3}, {Point4}";
        }
    }
}
