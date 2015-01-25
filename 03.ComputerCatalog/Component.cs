using System;

namespace _03.ComputerCatalog
{
    public class Component
    {
        private float price;
        private string 
            name, 
            details;

        #region Constructors
        public Component(string name, string details, float price)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentNullException(
                    "name",
                    "Component name cannot be null or empty string!");
            }

            this.details = details;

            if (price >= 0)
            {
                this.price = price;
            }
            else {
                throw new ArgumentException(
                    "Component price cannot be negative number!",
                    "price");
            }
        }

        public Component(string name, float price)
            :this(name, null, price)
        { }
        #endregion

        public override string ToString()
        {
            return string.Format("part name: {0}\ndetails: {1}\nprice: {2}lv", 
                this.name, this.details, this.price);
        }
    }
}
