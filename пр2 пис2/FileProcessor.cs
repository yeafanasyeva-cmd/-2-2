using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр2_пис2;

namespace пр2_пис2
{
    internal class FileProcessor
    {
        public static List<Point2D> ReadPointsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден: {filePath}");
            }

            var points = new List<Point2D>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                try
                {
                    points.Add(CreatePointFromInput(line));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка в строке {i + 1}: {ex.Message}");
                }
            }

            return points;
        }

        public static void SaveTrianglesToFile(List<Triangle> triangles, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            writer.WriteLine($"Количество треугольников: {triangles.Count}");
            writer.WriteLine("Созданные треугольники:");

            for (int i = 0; i < triangles.Count; i++)
            {
                writer.WriteLine($"Треугольник {i + 1}: {triangles[i]}");
            }
        }

        public static void SaveRectanglesToFile(List<Rectangle> rectangles, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            writer.WriteLine($"Количество прямоугольников: {rectangles.Count}");
            writer.WriteLine("Созданные прямоугольники:");

            foreach (var rectangle in rectangles)
            {
                writer.WriteLine(rectangle.ToString());
            }
        }

        private static Point2D CreatePointFromInput(string input)
        {
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
            {
                throw new ArgumentException("Неверный формат ввода. Ожидается: x y цвет");
            }

            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            Point2D.Color color = ParseColor(parts[2]);

            return new Point2D(x, y, color);
        }

        private static Point2D.Color ParseColor(string colorString)
        {
            string lowerColor = colorString.ToLower();

            switch (lowerColor)
            {
                case "red": return Point2D.Color.Red;
                case "green": return Point2D.Color.Green;
                case "blue": return Point2D.Color.Blue;
                case "light_blue": return Point2D.Color.LightBlue;
                default: return Point2D.Color.Blue;
            }
        }
    }
}
