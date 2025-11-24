using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр2_пис2;

namespace пр2_пис2
{
    public class FileProcessor
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

        public static void SaveFiguresToFile(List<Figure> figures, string filePath)
        {
            using var writer = new StreamWriter(filePath);

            var triangles = figures.OfType<Triangle>().ToList();
            var rectangles = figures.OfType<Rectangle>().ToList();
            var circles = figures.OfType<Circle>().ToList();
            var coloredTriangles = figures.OfType<ColoredTriangle>().ToList();

            foreach (var f in figures)
            {
                writer.WriteLine(f.Draw());
            }
            writer.WriteLine();
            }
        }
    }
}
