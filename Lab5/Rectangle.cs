namespace Lab5
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        private double _width;
        public double _height;

        public double calculateArea()
        {

            return _width * _height;
        }
    }
}
