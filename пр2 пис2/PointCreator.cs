using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    public class PointCreator
    {
        public static Point2D CreatePointFromString(string input)
        {
            InputValidator.ValidateInputString(input);

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            InputValidator.ValidatePointData(parts);

            double x = InputValidator.ValidateAndParseCoordinate(parts[0], "X");
            double y = InputValidator.ValidateAndParseCoordinate(parts[1], "Y");
            Point2D.Color color = ColorParser.ParseColor(parts[2]);

            return new Point2D(x, y, color);
        }
    }
}
