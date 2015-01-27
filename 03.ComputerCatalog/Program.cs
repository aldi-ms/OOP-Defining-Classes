using System;
using System.Collections.Generic;

namespace _03.ComputerCatalog
{
    class Program
    {
        public static void Main()
        {
            List<Component> components = new List<Component>() {
                new Component("ASRock Extreme4 MB", "X99M", 210f),
                new Component("Intel i5 CPU", "2500k", 250f),
                new Component("Corsair RAM", "8GB", 50f),
                new Component("HD2000 Integrated VGA", 0f),
                new Component("Western Digital HDD", "1TB Blue", 120f)
            };

            Computer pc1 = new Computer("PC 1", components, 1020f);
            Computer pc2 = new Computer("PC 3", 400f);

            Console.WriteLine(pc1.ToString());
            Console.WriteLine();
            Console.WriteLine(pc2.ToString());

            Console.ReadKey();
        }
    }
}
