using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public class MotorVehicle : Transport
    {
        // Write task 2, step 4 here
        public MotorVehicle(string make, string model, double litres) : base(make, model, litres) { }

        // Write task 2, step 5 here

        public override string Notice()
        {
            return "Check for blind spots!";
        }
    }
}
