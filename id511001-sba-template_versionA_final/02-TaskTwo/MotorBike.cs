using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public class MotorBike : Transport
    {
        // Write task 2, step 6 here
        public MotorBike(string make, string model, double litres) : base(make, model, litres) { }

        // Write task 2, step 7 here

        public override string Notice()
        {
            return "Remember your helmet!";
        }
    }
}
