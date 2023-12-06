using System.Text;

namespace Lab5
{
    static class InOutManager
    {
        public static void Instruction()
        {
            Console.WriteLine("ShapeManager:");
            Console.WriteLine("\tadd (name) - для додавання об'єкта класу Shape до масиву ");
            Console.WriteLine("\t\tname: circle - додати круг");
            Console.WriteLine("\t\tname: rect - додати прямокутник");
            Console.WriteLine("\tarea - для виведення площ усіх фігур у масиві");
            Console.WriteLine("\thelp - для виведення довідки");
            Console.WriteLine("\texit - для виходу з програми\n");
        }
        public static void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool Exit = false;
            while (!Exit)
            {
                Console.Write("ShapeManager: ");

                switch (Console.ReadLine())
                {
                    case "add circle":
                        Console.Write("Введіть радіус: ");
                        try
                        {
                            ShapeManager.addShape(new Circle(double.Parse(Console.ReadLine())));
                        }
                        catch (Exception ex) { Console.WriteLine("Некоректний тип данних!\n"); }
                        break;
                    case "add rect":

                        try
                        {
                            Console.Write("Введіть довжину: ");
                            double width = double.Parse(Console.ReadLine());

                            Console.Write("Введіть висоту: ");
                            double height = double.Parse(Console.ReadLine());

                            ShapeManager.addShape(new Rectangle(width, height));
                        }
                        catch (Exception ex) { Console.WriteLine("Некоректний тип данних!\n"); }
                        break;
                    case "area":
                        ShapeManager.printAllAreas();
                        break;
                    case "help":
                        Instruction();
                        break;
                    case "exit":
                        Exit = true;
                        break;

                }
            }
            
            
        }
    }
}
