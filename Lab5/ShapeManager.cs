namespace Lab5
{
    static class ShapeManager
    {
        static List<Shape> shapes = new List<Shape>();
        public static void addShape(Shape shape)
        {
            shapes.Add(shape);
        }
        private static double[] calculateAllAreas()
        {
            double[] areas = new double[shapes.Count];
            for (int i = 0; i < shapes.Count; i++)
            {
                areas[i] = shapes[i].calculateArea();
            }
            return areas;

        }
        public static void printAllAreas()
        {
            double[] areas = calculateAllAreas();
            if(areas.Length ==0)
            {
                Console.WriteLine("\tМасив пустий");
            }
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"\tПлоща {shapes[i].GetType().Name}\t#{i + 1}: {areas[i]}");
            }
        }
    }
}
