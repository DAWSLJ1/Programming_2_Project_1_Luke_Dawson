using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    public class StarShip
    {
        private string name;
        private double volume;
        private bool isOperating;

        public StarShip(string name, double volume, bool isOperating)
        {
            this.name = name;
            this.volume = volume;
            this.isOperating = isOperating;
        }

        public void TripleVolume()
        {
            volume = volume + 1;  // Bug 1
        }

        public void ActivateShip()
        {
            isOperating = false;  // Bug 2
        }

        public string GetInfo()
        {
            return $"Ship Name: {name}, Volume: {volume}";  // Bug 3
        }

        public void ResetVolume()
        {
            Volume = volume;  // Bug 4
        }

        public bool IsLarge()
        {
            return volume <= 150000;  // Bug 5
        }

        public string Name { get => name; set => name = value; }
        public double Volume
        {
            get => volume;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Volume cannot be negative");
                }
                volume = value;
            }
        }
        public bool IsOperating { get => isOperating; set => isOperating = value; }
    }
}