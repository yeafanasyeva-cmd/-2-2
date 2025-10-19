using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class ColorParser
    {
        public static Point2D.Color ParseColor(string colorString)
        {
            InputValidator.ValidateInputString(colorString);

            string lowerColor = colorString.ToLower();

            switch (lowerColor)
            {
                case "red": return Point2D.Color.Red;
                case "green": return Point2D.Color.Green;
                case "blue": return Point2D.Color.Blue;
                case "light_blue": return Point2D.Color.LightBlue;
                default:
                    throw new ArgumentException($"Неизвестный цвет: {colorString}. Допустимые цвета: red, green, blue, light_blue");
            }
        }
    }
}
