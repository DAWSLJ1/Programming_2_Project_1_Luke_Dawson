using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Person
    {
        protected int iD;
        protected string firstName;
        protected string lastName;

        public int ID { get => iD; set => iD = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Person(int iD, string firstName, string lastName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual string DisplayDetail()
        {
            return $"{iD}, {FirstName}, {LastName}";
        }
    }
}
