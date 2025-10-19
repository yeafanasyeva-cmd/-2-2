using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    internal class InputValidator
    {
        public static void ValidateFilePath(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("Путь к файлу не может быть пустым");
        }

        public static void ValidatePointCount(int count)
        {
            if (count <= 0)
                throw new ArgumentException("Количество точек должно быть положительным числом");
        }

        public static void ValidateInputString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Входная строка не может быть пустой");
        }

        public static void ValidatePointData(string[] parts)
        {
            if (parts.Length < 3)
                throw new ArgumentException("Неверный формат ввода. Ожидается: x y цвет");
        }

        public static double ValidateAndParseCoordinate(string coordinate, string coordinateName)
        {
            if (!double.TryParse(coordinate, out double result))
                throw new ArgumentException($"Некорректная координата {coordinateName}: {coordinate}");

            return result;
        }
    }
}
