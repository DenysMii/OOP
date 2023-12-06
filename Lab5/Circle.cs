namespace Lab5
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double _radius { get; private set; }
        public double calculateArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return Math.Round(area, digits: 3);
        }
    }
}
