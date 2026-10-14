using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public abstract class Transport
    {
        // Write task 2, step 1 here
        private string make;
        private string model;
        private double litres;

        

        public Transport(string make, string model, double litres)
        {
            this.Make = make;
            this.Model = model;
            this.Litres = litres;
        }

        // Write task 2, step 2 here
        protected string Make { get => make; set => make = value; }
        protected string Model { get => model; set => model = value; }
        protected double Litres { get => litres; set => litres = value; }

        // Write task 2, step 3 here
        public abstract string Notice();
    }
}
