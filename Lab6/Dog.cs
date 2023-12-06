using System.Xml.Linq;

namespace Lab6
{
    class Dog : Animal, SoundProducingAnimal
    {
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
        public string Breed { get; private set; }
        public void makeSound()
        {
            Console.WriteLine($"{Name} гавкає");
        }
    }
}
