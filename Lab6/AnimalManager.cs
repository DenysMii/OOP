namespace Lab6
{
    static class AnimalManager
    {
        static List<Animal> animals = new List<Animal>();
        public static void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public static void playSounds()
        {
            foreach (SoundProducingAnimal animal in animals)
            {
                animal.makeSound();
            }
        }
    }
}
