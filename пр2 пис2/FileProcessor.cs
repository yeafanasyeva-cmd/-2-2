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
            var points = new List<Point2D>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                try
                {
                    points.Add(PointCreator.CreatePointFromString(line));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка в строке {i + 1}: {ex.Message}");
                }
            }

            return points;
        }

        public static void SaveFiguresToFile(List<Triangle> triangles, List<Rectangle> rectangles, List<Circle> circles, string filePath)
        {
            using var writer = new StreamWriter(filePath);

            if (triangles.Count > 0)
            {
                writer.WriteLine($"Количество треугольников: {triangles.Count}");
                writer.WriteLine("Треугольники:");
                for (int i = 0; i < triangles.Count; i++)
                {
                    writer.WriteLine($"Треугольник {i + 1}: {triangles[i]}");
                }
                writer.WriteLine();
            }

            if (rectangles.Count > 0)
            {
                writer.WriteLine($"Количество прямоугольников: {rectangles.Count}");
                writer.WriteLine("Прямоугольники:");
                foreach (var rectangle in rectangles)
                {
                    writer.WriteLine(rectangle.ToString());
                }
                writer.WriteLine();
            }

            if (circles.Count > 0)
            {
                writer.WriteLine($"Количество кругов: {circles.Count}");
                writer.WriteLine("Круги:");
                foreach (var circle in circles)
                {
                    writer.WriteLine(circle.Draw());
                }
            }
        }
    }
}
