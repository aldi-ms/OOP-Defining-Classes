using System;
using System.Collections.Generic;

namespace _03.ComputerCatalog
{
    public class Computer
    {
        private float price;
        private string name;
        private List<Component> components;

        #region Constructors
        /// <summary>
        /// Full computer constructor.
        /// </summary>
        /// <param name="name">Name of the computer.</param>
        /// <param name="components">List of computer components.</param>
        /// <param name="price">Price of the computer.</param>
        public Computer(
            string name, 
            List<Component> components,
            float price)
        {
            this.Name = name;
            this.Components = components;
            this.Price = price;
        }

        /// <summary>
        /// Default minimal constructor.
        /// </summary>
        /// <param name="name">Name of the computer.</param>
        /// <param name="price">Price of the computer.</param>
        public Computer(string name, float price)
            :this(name, new List<Component>(), price)
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

        public List<Component> Components
        {
            get { return this.components; }

            set
            {
                if (value != null)
                {
                    this.components = value;
                }
                else
                {
                    throw new ArgumentNullException("components", "Components cannot be null!");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendFormat("computer name: {0}\n", this.name);
            sb.AppendFormat("computer price: {0}lv\n", this.price);

            foreach (Component component in Components)
            {
                sb.AppendFormat("{0}\n", component.ToString());
            }

            return sb.ToString();
        }
    }
}
