using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03_LSP
{
    using System;

    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }
    }

    public class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : FlyingBird
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

    }

    internal class Program
    {

        static void main(string[] args)
        {
            Eagle eagle = new Eagle();
            Ostrich ostrich = new Ostrich();

            eagle.Eat();
            eagle.Fly();
            ostrich.Eat();

            Console.ReadKey();
        }
    }

}
