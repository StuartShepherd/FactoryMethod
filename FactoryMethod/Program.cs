using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory method design pattern example");
            Console.WriteLine("Factory method is a creational design pattern which solves the problem of creating product objects without specifying their concrete classes.");
            Console.WriteLine();

            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine();

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());

        }

        // the client code works with an instance of a concrete creator, albeit through its base interface. 
        // as long as the client keeps working with the creator via the base interface, you can pass it any creator's subclass.
        public static void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.");
            Console.WriteLine(creator.SomeOperation());
        }
    }
}
