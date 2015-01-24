using System;

namespace _02.LaptopShop
{
    public class Battery
    {
        private int
            cells,
            powerOutput;
        private float life;
        private string type;

        /// <summary>
        /// Create a new Battery object.
        /// </summary>
        /// <param name="type">Type of battery. Cannot be null or empty string.</param>
        /// <param name="cells">Number of cells inside the battery. Cannot be negative number.</param>
        /// <param name="powerOutput">Battery power output (in mAh). Cannot be negative number.</param>
        /// <param name="life">Battery life in hours. Cannot be negative number.</param>
        public Battery(string type, int cells, int powerOutput, float life)
        {
            this.Type = type;
            this.Cells = cells;
            this.PowerOutput = powerOutput;
            this.Life = life;
        }

        #region Properties
        /// <summary>
        /// The Battery type. Value cannot be null or empty string.
        /// </summary>
        public string Type
        {
            get { return this.type; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentNullException("Type", "Battery type cannot be null or empty string!");
                }
            }
        }

        /// <summary>
        /// Number of cells inside a Battery.
        /// Value should be non-negative number.
        /// </summary>
        public int Cells
        {
            get { return this.cells; }

            set
            {
                if (value >= 0)
                {
                    this.cells = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Number of cells in a Battery should be non-negative number!",
                        "Cells");
                }
            }
        }

        /// <summary>
        /// Battery Power output, in mAh. Should be non-negative number.
        /// </summary>
        public int PowerOutput
        {
            get { return this.powerOutput; }

            set
            {
                if (value >= 0)
                {
                    this.powerOutput = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Battery power output should be non-negative number (in mAh)!",
                        "PowerOutput");
                }
            }
        }

        /// <summary>
        /// Battery life, in hours. Should be non-negative number.
        /// </summary>
        public float Life
        {
            get { return this.life; }

            set
            {
                if (value >= 0)
                {
                    this.life = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Battery life should be non-negative number (in hours)!",
                        "Life");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2}mAh\nbattery life: {3}hours", this.Type, this.Cells, this.PowerOutput, this.Life);
        }
    }
}
