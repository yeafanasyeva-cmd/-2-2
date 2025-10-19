using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class GeometryHelper //слой с геометрич действиями
    {
        public static List<Triangle> CreateTriangles(List<Point2D> points, int startIndex = 0)
        {
            var triangles = new List<Triangle>();

            for (int i = startIndex; i <= points.Count - 3; i += 3)
            {
                triangles.Add(new Triangle(points[i], points[i + 1], points[i + 2]));
            }

            return triangles;
        }

        public static List<Rectangle> CreateRectangles(List<Point2D> points, int startIndex = 0)
        {
            var rectangles = new List<Rectangle>();

            for (int i = startIndex; i <= points.Count - 4; i += 4)
            {
                rectangles.Add(new Rectangle(points[i], points[i + 1], points[i + 2], points[i + 3]));
            }

            return rectangles;
        }

        public static int CalculateUsedPoints(int triangleCount, int rectangleCount, int circleCount)
        {
            return triangleCount * 3 + rectangleCount * 4 + circleCount;
        }
    }
}
