using System;

namespace _02.LaptopShop
{
    class Program
    {
        public static void Main()
        {
            Battery bat = new Battery("Li-Ion", 4, 4300, 4.1f);
            Laptop laptop = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8,
                "Intel HD Graphics 4400",
                "128GB SSD",
                "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                bat,
                2259.00f
                );

            Laptop laptop2 = new Laptop("Kitaiche", 300f);

            Console.WriteLine("Laptop1, full description:");
            Console.WriteLine(laptop.ToString());

            Console.WriteLine("\nLaptop2, mandatory properties only:");
            Console.WriteLine(laptop2.ToShortString());

            Console.ReadKey();
        }
    }
}
