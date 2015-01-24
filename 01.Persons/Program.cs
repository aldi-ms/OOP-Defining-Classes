using System;

namespace _01.Persons
{
    class Program
    {
        public static void Main()
        {
            Person p = new Person("Alexandar", 22);
            Person p2 = new Person("Alex", 21, "test@test.bg");

            Console.WriteLine("p:\n{0}\n", p.ToString());
            Console.WriteLine("p2:\n{0}\n", p2.ToString());

            Console.ReadKey();
        }
    }
}
