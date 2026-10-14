using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    public class Whale
    {
        private string name;
        private int avgWeight;                  //kg
        private double avgLength; //metres

        public Whale(string name, int avgWeight, double avgLength)
        {
            this.name = name;
            this.avgWeight = avgWeight;
            this.avgLength = avgLength;
        }

        public string Name { get => name; set => name = value; }
        public int AvgWeight
        {
            get => avgWeight;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Weight cannot be negative");
                }
                avgWeight = value;
            }
        }
        public double AvgLength { get => avgLength; set => avgLength = value; }
        public double Krill() => AvgWeight * 0.12;     //calculate krill eaten per day
    }
}
