using System;
using System.Text;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть координати 1 точки: ");
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
            Point point1 = new Point(x, y);

            Console.WriteLine("Введіть координати 2 точки: ");
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());

            Point point2 = new Point(x, y);


            Console.WriteLine($"point1 == point2: {point1 == point2}");
            Console.WriteLine($"point1 != point2: {point1 != point2}");
            Console.WriteLine($"point1 < point2: {point1 < point2}");
            Console.WriteLine($"point1 > point2: {point1 > point2}");
            Console.WriteLine($"point1: {point1.ToString()}");
            Console.WriteLine($"point2: {point2.ToString()}");
        }
    }


    class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static bool operator ==(Point a, Point b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
        public static bool operator <(Point a, Point b)
        {
            return a.x < b.x && a.y < b.y;
        }
        public static bool operator >(Point a, Point b)
        {
            return a.x > b.x && a.y > b.y;
        }
        public override string ToString()
        {
            return $"X: {x}; Y: {y}";
        }

    }
}
