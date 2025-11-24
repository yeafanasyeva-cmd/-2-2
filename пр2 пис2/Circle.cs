using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    public class Circle : Figure
    {
        public Point2D Center { get; }

        public Circle(Point2D center)
        {
            Center = center;
        }
        public override string Draw()
        {
            return $"Круг: Центр - {Center}";
        }
        public override string GetFigureType()
        {
            return "Круг";
        }
        public override int GetPointCount()
        {
            return 1;
        }
        public override List<Point2D> GetPoints()
        {
            return new List<Point2D> { Center };
        }
        public override string ToString()
        {
            return Draw();
        }
    }
}
