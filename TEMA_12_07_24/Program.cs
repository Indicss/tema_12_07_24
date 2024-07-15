using System;

namespace VirtualZoo
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} mananca.");
        }
    }

    interface IRunnable
    {
        void Run();
    }
    class Dog : Animal, IRunnable
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} latra.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} mananca oase.");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} alearga.");
        }
    }

    class Cat : Animal, IRunnable
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} miauna.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} mananca peste.");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} alearga.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Rex");
            Animal cat = new Cat("Mia");

            dog.MakeSound();
            dog.Eat();
            cat.MakeSound();
            cat.Eat();

            IRunnable runningDog = (IRunnable)dog;
            IRunnable runningCat = (IRunnable)cat;

            runningDog.Run();
            runningCat.Run();

            Console.ReadLine();
        }
    }
}
