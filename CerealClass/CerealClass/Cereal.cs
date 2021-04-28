using System;
using System.Collections.Generic;
using System.Text;

namespace CerealClass
{
    class Cereal
    {
        /// <summary>
        /// Declaring public variables with getters and setters
        /// </summary>
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        /// <summary>
        /// Default Constructor setting each value to zero or empty
        /// </summary>
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }
    }
}
