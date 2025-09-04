using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cereal_Problem
{
    public class Cereal
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; }

        public double Cups { get; set; }

        private double Squirell;


        public Cereal()
        {
            Manufacturer = "";
            Name = string.Empty;
            Calories = 0.0;
            Cups = 0.0;
            Squirell = 0.0;
        }

        public Cereal(string line)
        {
            Manufacturer = line;
            Name = string.Empty;
            Calories = 0.0;
            Cups = 0.0; 
        }

     

    }
}
