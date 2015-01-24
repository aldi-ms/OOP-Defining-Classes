using System;

namespace _02.LaptopShop
{
    public class Laptop
    {
        private int ram;
        private string
            model,
            manufacturer,
            processor,
            graphics,
            hdd,
            screen;
        private float price;
        private Battery battery;

        #region Constructors
        /// <summary>
        /// Create a new Laptop object.
        /// </summary>
        /// <param name="model">Laptop model.  Cannot be null or empty string.</param>
        /// <param name="manufacturer">Laptop manufacturer.  Cannot be null or empty string.</param>
        /// <param name="processor">Laptop processor.  Cannot be null or empty string.</param>
        /// <param name="ram">Laptop RAM, in GB. Cannot be negative number.</param>
        /// <param name="graphicsCard">Laptop graphics card. Cannot be null or empty string.</param>
        /// <param name="hdd">Laptop HDD.  Cannot be null or empty string.</param>
        /// <param name="screen">Laptop screen. Cannot be null or empty string.</param>
        /// <param name="battery">Laptop Battery.</param>
        /// <param name="price">Laptop price in BGN leva. Cannot be negative number.</param>
        public Laptop(
            string model,
            string manufacturer,
            string processor,
            int ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery battery,
            float price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Price = price;
            this.Battery = battery;
        }

        /// <summary>
        /// Short laptop constructor. Use with ToShortString().
        /// </summary>
        /// <param name="model">Laptop model.  Cannot be null or empty string.</param>
        /// <param name="price">Laptop price in BGN leva. Cannot be negative number.</param>
        public Laptop(string model, float price)
        {
            this.Model = model;
            this.price = price;
        }

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            int ram,
            string graphicsCard,
            string hdd,
            string screen,
            float price,
            string batteryType,
            int batteryCells, 
            int batteryPowerOutput,
            float batteryLife)
            : this(model, manufacturer, processor, ram, graphicsCard, hdd, screen,  
            new Battery(batteryType, batteryCells, batteryPowerOutput, batteryLife), price)
        { }
        #endregion

        #region Properties
        public string Model
        {
            get { return this.model; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "Model", 
                        "Laptop model cannot be null or empty string!");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "Manufacturer", 
                        "Laptop manufacturer cannot be null or empty string!");
                }
            }
        }

        public string Processor
        {
            get { return this.processor; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.processor = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "Processor",
                        "Laptop processor cannot be null or empty string!");
                }
            }
        }
        
        public string GraphicsCard
        {
            get { return this.graphics; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.graphics = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "Graphics",
                        "Laptop Graphics Card cannot be null or empty string!");
                }
            }
        }

        public string HDD
        {
            get { return this.hdd; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.hdd = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "HDD", 
                        "Laptop HDD cannot be null or empty string!");
                }
            }
        }

        public string Screen
        {
            get { return this.screen; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.screen = value;
                }
                else
                {
                    throw new ArgumentNullException(
                        "Screen",
                        "Laptop screen cannot be null or empty string!");
                }
            }
        }

        public int RAM
        {
            get { return this.ram; }

            set
            {
                if (ram >= 0)
                {
                    this.ram = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Laptop RAM cannot be negative number!", 
                        "RAM");
                }
            }
        }

        public float Price
        {
            get { return this.price; }

            set
            {
                if (price >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Laptop Price cannot be negative number!",
                        "Price");
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        #endregion

        public string ToShortString()
        {
            return string.Format("model: {0}\nprice: {1}lv", this.Model, this.Price.ToString("0.00"));
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormat("model: {0}", this.Model);
            sb.AppendFormat("\nprice: {0}", this.Price);
            sb.AppendFormat("\nprocessor: {0}", this.Processor);
            sb.AppendFormat("\nRAM: {0}GB", this.RAM);
            sb.AppendFormat("\ngraphics card: {0}", this.GraphicsCard);
            sb.AppendFormat("\nHDD: {0}", this.HDD);
            sb.AppendFormat("\nscreen: {0}", this.Screen);
            sb.AppendFormat("\nbattery: {0}", this.Battery.ToString());
            sb.AppendFormat("\nprice: {0}lv", this.Price.ToString("0.00"));

            return sb.ToString(); ;
        }
    }
}
