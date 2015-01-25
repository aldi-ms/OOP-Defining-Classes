using System;

namespace _03.ComputerCatalog
{
    public class Computer
    {
        private float price;
        private string name;
        private Component
            motherboard,
            cpu,
            vga,
            ram,
            hdd;

        #region Constructors
        /// <summary>
        /// Full computer constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="motherboard"></param>
        /// <param name="cpu"></param>
        /// <param name="vga"></param>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        /// <param name="price"></param>
        public Computer(
            string name, 
            Component motherboard,
            Component cpu,
            Component vga,
            Component ram,
            Component hdd,
            float price)
        {
            this.name = name;
            this.motherboard = motherboard;
            this.cpu = cpu;
            this.vga = vga;
            this.ram = ram;
            this.hdd = hdd;
            this.price = price;
        }

        /// <summary>
        /// Constructor with computer name, motherboard, CPU, RAM and price.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="motherboard"></param>
        /// <param name="cpu"></param>
        /// <param name="ram"></param>
        /// <param name="price"></param>
        public Computer(string name, Component motherboard, Component cpu, Component ram, float price)
            :this(name, motherboard, cpu, null, ram, null, price)
        {

        }

        /// <summary>
        /// Default minimal constructor.
        /// </summary>
        /// <param name="name">Name of the computer.</param>
        /// <param name="price">Price of the computer.</param>
        public Computer(string name, float price) 
            :this(name, null, null, null, price)
        { }
        #endregion

        #region Properties
        public float Price
        {
            get { return this.price; }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Price should be non-negative number!",
                        "price");
                }
            }
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Computer name cannot be null or empty string!", 
                        "name");
                }
            }
        }

        public Component Motherboard
        {
            get { return this.motherboard; }

            set
            {
                if (value != null)
                {
                    this.motherboard = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "motherboard", 
                        "Computer motherboard cannot be null!");
                }
            }
        }

        public Component CPU
        {
            get { return this.cpu; }

            set
            {
                if (value != null)
                {
                    this.cpu = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "cpu",
                        "Computer CPU cannot be null!");
                }
            }
        }

        public Component VGA
        {
            get { return this.vga; }

            set
            {
                if (value != null)
                {
                    this.vga = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "vga",
                        "Computer VGA cannot be null!");
                }
            }
        }

        public Component RAM
        {
            get { return this.ram; }

            set
            {
                if (value != null)
                {
                    this.ram = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "ram",
                        "Computer RAM cannot be null!");
                }
            }
        }

        public Component HDD
        {
            get { return this.hdd; }

            set
            {
                if (value != null)
                {
                    this.hdd = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "hdd",
                        "Computer HDD cannot be null!");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendFormat("computer name: {0}\n", this.name);
            sb.AppendFormat("computer price: {0}lv\n", this.price);

            if (this.Motherboard != null)
                sb.AppendFormat("{0}\n", this.Motherboard.ToString());
            if (this.CPU != null)
                sb.AppendFormat("{0}\n", this.CPU.ToString());
            if (this.VGA != null)
                sb.AppendFormat("{0}\n", this.VGA.ToString());
            if (this.RAM != null)
                sb.AppendFormat("{0}\n", this.RAM.ToString());
            if (this.HDD != null)
                sb.AppendFormat("{0}", this.HDD.ToString());

            return sb.ToString();
        }
    }
}
