using System;

namespace _03.ComputerCatalog
{
    class Program
    {
        public static void Main()
        {
            Component mb = new Component("ASRock Extreme4 MB", "X99M", 210f);
            Component cpu = new Component("Intel i5 CPU", "2500k", 250f);
            Component ram = new Component("Corsair RAM", "8GB", 50f);
            Component vga = new Component("HD2000 Integrated VGA", 0f);
            Component hdd = new Component("Western Digital HDD", "1TB Blue", 120f);

            Computer pc1 = new Computer("PC 1", mb, cpu, vga, ram, hdd, 1020f);
            Computer pc2 = new Computer("PC 2", mb, cpu, new Component("RAM 2GB", 15), 560f);
            Computer pc3 = new Computer("PC 3", 400f);

            Console.WriteLine(pc1.ToString());
            Console.WriteLine();
            Console.WriteLine(pc2.ToString());
            Console.WriteLine();
            Console.WriteLine(pc3.ToString());

            Console.ReadKey();
        }
    }
}
