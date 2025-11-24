using пр2_пис2;

Console.WriteLine("Программа для создания фигур из точек");

try
{
    List<Point2D> points = ReadPoints();

    var triangles = new List<Triangle>();
    var rectangles = new List<Rectangle>();
    var circles = new List<Circle>();

    AskUserForFigureCreation(points, triangles, rectangles, circles);
    PrintResults(triangles, rectangles, circles, points);
    SaveToFile(triangles, rectangles, circles);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

static List<Point2D> ReadPoints()
{
    Console.Write("Введите количество точек: ");
    int count = int.Parse(Console.ReadLine());
    InputValidator.ValidatePointCount(count);

    var points = new List<Point2D>();

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Точка {i + 1} (x y цвет): ");
        string pointInput = Console.ReadLine();

            try
            {
                points.Add(PointCreator.CreatePointFromString(pointInput));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте еще раз:");
                i--;
            }   
    }

    return points;
}

static void AskUserForFigureCreation(List<Point2D> points, List<Triangle> triangles, List<Rectangle> rectangles, List<Circle> circles)
{
    Console.WriteLine($"\nУ вас {points.Count} точек. Во что преобразовать?");
    Console.WriteLine("1 - Треугольники (по 3 точки на треугольник)");
    Console.WriteLine("2 - Прямоугольники (по 4 точки на прямоугольник)");
    Console.WriteLine("3 - Круги (по 1 точке на круг)");
    Console.WriteLine("4 - Автоматически (треугольники + прямоугольники + круги из остатков)");
    Console.Write("Выберите вариант: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            triangles.AddRange(GeometryHelper.CreateTriangles(points));
            Console.WriteLine($"Создано {triangles.Count} треугольников");
            break;

        case "2":
            rectangles.AddRange(GeometryHelper.CreateRectangles(points));
            Console.WriteLine($"Создано {rectangles.Count} прямоугольников");
            break;

        case "3":
            foreach (var point in points)
            {
                circles.Add(new Circle(point));
            }
            Console.WriteLine($"Создано {circles.Count} кругов");
            break;

        case "4":
        default:
            triangles.AddRange(GeometryHelper.CreateTriangles(points));

            int pointsAfterTriangles = triangles.Count * 3;
            if (points.Count - pointsAfterTriangles >= 4)
            {
                var newRectangles = GeometryHelper.CreateRectangles(points, pointsAfterTriangles);
                rectangles.AddRange(newRectangles);
                Console.WriteLine($"Создано {triangles.Count} треугольников и {rectangles.Count} прямоугольников");
            }
            else
            {
                Console.WriteLine($"Создано {triangles.Count} треугольников (для прямоугольников не хватило точек)");
            }

            int usedPoints = triangles.Count * 3 + rectangles.Count * 4;
            if (points.Count > usedPoints)
            {
                Console.WriteLine($"\nОсталось {points.Count - usedPoints} неиспользованных точек.");
                Console.Write("Преобразовать их в круги? (y/n): ");

                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes" || answer == "д" || answer == "да")
                {
                    for (int i = usedPoints; i < points.Count; i++)
                    {
                        circles.Add(new Circle(points[i]));
                    }
                    Console.WriteLine($"Создано дополнительно {circles.Count} кругов");
                }
            }
            break;
    }
}

static void PrintResults(List<Triangle> triangles, List<Rectangle> rectangles, List<Circle> circles, List<Point2D> points)
{
    if (triangles.Count > 0)
    {
        Console.WriteLine("\n=== ТРЕУГОЛЬНИКИ ===");
        foreach (var triangle in triangles)
        {
            Console.WriteLine(triangle);
        }
    }

    if (rectangles.Count > 0)
    {
        Console.WriteLine("\n=== ПРЯМОУГОЛЬНИКИ ===");
        foreach (var rectangle in rectangles)
        {
            Console.WriteLine(rectangle);
        }
    }

    if (circles.Count > 0)
    {
        Console.WriteLine("\n=== КРУГИ ===");
        foreach (var circle in circles)
        {
            Console.WriteLine(circle.Draw());
        }
    }

    int usedPoints = GeometryHelper.CalculateUsedPoints(triangles.Count, rectangles.Count, circles.Count);
    if (points.Count > usedPoints)
    {
        Console.WriteLine("\n=== НЕИСПОЛЬЗОВАННЫЕ ТОЧКИ ===");
        for (int i = usedPoints; i < points.Count; i++)
        {
            Console.WriteLine(points[i]);
        }
    }
}

static void SaveToFile(List<Triangle> triangles, List<Rectangle> rectangles, List<Circle> circles)
{
    FileProcessor.SaveFiguresToFile(triangles, rectangles, circles, "results.txt");
    Console.WriteLine("\nРезультаты сохранены в results.txt");
}