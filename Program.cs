using System;

namespace LSPViolation
{
    class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating meat.");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle is flying high in the sky.");
        }
    }

    class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich is eating plants.");
        }

        public override void Fly()
        {
            throw new NotSupportedException("Ostriches cannot fly.");
        }
    }

    internal class Program
    {
        static void MakeBirdFly(Bird bird)
        {
            bird.Fly();
        }

        static void Main(string[] args)
        {
            Bird eagle = new Eagle();
            Bird ostrich = new Ostrich();

            eagle.Eat();
            eagle.Fly();
            MakeBirdFly(eagle);

            Console.WriteLine();
            ostrich.Eat();
            MakeBirdFly(ostrich);   // ❌ Runtime Exception

            Console.ReadKey();
        }
    }
}