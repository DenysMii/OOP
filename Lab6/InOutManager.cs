using System.Drawing;
using System.Text;

namespace Lab6
{
    static class InOutManager
    {
        public static void Instruction()
        {
            Console.WriteLine("AnimalManager:");
            Console.WriteLine("\tadd (name) - для додавання об'єкта класу Animal до масиву ");
            Console.WriteLine("\t\tname: dog - додати собаку");
            Console.WriteLine("\t\tname: cat - додати кота");
            Console.WriteLine("\tsound - для відтворення звуків усіх тварин у масив");
            Console.WriteLine("\thelp - для виведення довідки");
            Console.WriteLine("\texit - для виходу з програми\n");
        }
        public static void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool Exit = false;
            while (!Exit)
            {
                Console.Write("AnimalManager: ");

                switch (Console.ReadLine())
                {
                    case "add dog":
                        Console.Write("Введіть ім'я собаки: ");
                        string name = Console.ReadLine();

                        Console.Write("Введіть породу собаки: ");
                        string breed = Console.ReadLine();

                        AnimalManager.addAnimal(new Dog(name, breed));
                        break;
                    case "add cat":
                        Console.Write("Введіть ім'я собаки: ");
                        name = Console.ReadLine();

                        Console.Write("Введіть колір кішки: ");
                        string color = Console.ReadLine();

                        AnimalManager.addAnimal(new Cat(name, color));
                        break;
                    case "sound":
                        AnimalManager.playSounds();
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
