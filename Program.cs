namespace ConsoleApp7
{
    /// <summary>
    /// Интерфейс для фигур
    /// </summary>
    public interface IShape
    {
        double Area();
        double Perimeter();
    }

    /// <summary>
    /// Класс Circle (Круг)
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    /// <summary>
    /// Класс Square (Квадрат)
    /// </summary>
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return 4 * SideLength;
        }
    }

    /// <summary>
    /// Класс Triangle (Треугольник)
    /// </summary>
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Пример использования классов для расчета площади и периметра

            Circle circle = new Circle(5);
            double circleArea = circle.Area();
            double circlePerimeter = circle.Perimeter();
            Console.WriteLine($"Circle: Area = {circleArea}, Perimeter = {circlePerimeter}");

            Square square = new Square(7);
            double squareArea = square.Area();
            double squarePerimeter = square.Perimeter();
            Console.WriteLine($"Square: Area = {squareArea}, Perimeter = {squarePerimeter}");

            Triangle triangle = new Triangle(3, 4, 5);
            double triangleArea = triangle.Area();
            double trianglePerimeter = triangle.Perimeter();
            Console.WriteLine($"Triangle: Area = {triangleArea}, Perimeter = {trianglePerimeter}");

            Console.ReadLine();
        }
    }
}