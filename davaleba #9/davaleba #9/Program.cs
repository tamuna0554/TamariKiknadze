// See https://aka.ms/new-console-template for more information
using davaleba__9.interfaces;




IAnimal[] animals = new IAnimal[]
            {
                new Dog("Roki", 1),
                new Cat("Charli", 2),
                new Cow("Monika", 3)
            };

foreach (var animal in animals)
{
    Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
}
