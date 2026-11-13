namespace SolidHomework;

// O - Open/Closed Principle (Aciq/Qapali Prinsip)
// Task: Kvadrat ve duzbucaqlinin sahesini hesabla.
// Qayda: Yeni fiqur elave ederken movcud hesablayici kodunu deyismeye ehtiyac olmasin.
interface IShape
{
    double Area();
}

class Square : IShape
{
    public double Side { get; }
    public Square(double side) => Side = side;
    public double Area() => Side * Side;
}

class RectangleShape : IShape
{
    public double Width { get; }
    public double Height { get; }
    public RectangleShape(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Area() => Width * Height;
}

static class OpenClosed
{
    public static void Run()
    {
        Console.WriteLine("2. OCP:");
        IShape[] shapes = { new Square(4), new RectangleShape(3, 5) };
        foreach (IShape shape in shapes)
            Console.WriteLine($"Sahe: {shape.Area()}");
        Console.WriteLine();
    }
}
