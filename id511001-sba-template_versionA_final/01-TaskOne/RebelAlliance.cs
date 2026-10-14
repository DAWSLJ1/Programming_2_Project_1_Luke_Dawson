using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class RebelAlliance
    {
        private string firstName;
        private string lastName;
        private int yearsInRebellion;
        string yearNegativeError = "Years in Rebellion cannot be negative";
        public RebelAlliance(string firstName, string lastName, int yearsInRebellion)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearsInRebellion = yearsInRebellion;
        }

        // Write task 1, step 1 here
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //Write task 1, step 2 here

        public int YearsInRebellion
        {
            get => yearsInRebellion;
            set
            {
                if (YearsInRebellion < 0)
                {
                    MessageBox.Show(yearNegativeError);
                }
                // Write task 1, step 3 here

                yearsInRebellion = value;
            }
        }

    }
}
