using davaleba__9.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace davaleba__9.interfaces
{
    internal interface IAnimal
    {
        string MakeSound();
    }

    public abstract class Animal : IAnimal
    {
        public abstract string MakeSound();


        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Name and Age
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "miau";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "moo";
        }
    }
}

