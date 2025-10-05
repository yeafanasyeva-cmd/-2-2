using пр2_пис2;

Console.WriteLine("Внимание: для треугольника нужно 3 точки");

List<Point2D> points = ReadPoints();

var triangles = CreateTriangles(points);

PrintResults(triangles, points);

static List<Point2D> ReadPoints()
{
    Console.Write("Введите количество точек: ");
    int count = int.Parse(Console.ReadLine());

    var points = new List<Point2D>();

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Точка {i + 1} (x y цвет): ");
        string input = Console.ReadLine();
        points.Add(CreatePoint(input));
    }

    return points;
}

static Point2D CreatePoint(string input)
{
    string[] parts = input.Split(' ');

    double x = double.Parse(parts[0]);
    double y = double.Parse(parts[1]);
    Point2D.Color color = ParseColor(parts[2]);

    return new Point2D(x, y, color);
}

static Point2D.Color ParseColor(string colorString)
{
    switch (colorString.ToLower())
    {
        case "red": return Point2D.Color.Red;
        case "green": return Point2D.Color.Green;
        case "blue": return Point2D.Color.Blue;
        case "light_blue": return Point2D.Color.LightBlue;
        default: return Point2D.Color.Blue;
    }
}

static List<Triangle> CreateTriangles(List<Point2D> points)
{
    var triangles = new List<Triangle>();

    for (int i = 0; i <= points.Count - 3; i += 3)
    {
        triangles.Add(new Triangle(points[i], points[i + 1], points[i + 2]));
    }

    return triangles;
}

static void PrintResults(List<Triangle> triangles, List<Point2D> points)
{
    Console.WriteLine("\nТреугольники:");
    foreach (var triangle in triangles)
    {
        Console.WriteLine(triangle);
    }

    int usedPoints = triangles.Count * 3;
    if (points.Count > usedPoints)
    {
        Console.WriteLine("\nЛишние точки:");
        for (int i = usedPoints; i < points.Count; i++)
        {
            Console.WriteLine(points[i]);
        }
    }
}