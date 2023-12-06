namespace Lab6
{

    internal class Cat : Animal, SoundProducingAnimal
    {
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Color { get; private set; }
        public void makeSound()
        {
            Console.WriteLine($"{Name} мурчить");
        }
    }
}
