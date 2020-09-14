using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemo
{
    class Person
    {

        // instance variables
        private string firstName;
        private string eyeColor;
        private int daysAlive;

        // properties
        public string LastName { get; set; }
        public float YearsAlive
        {
            get
            {
                return (float)(daysAlive / 365.0);
            }
            set
            {
                daysAlive = (int)(value * 365);
            }
        }

        // constructor
        public Person(string firstName, int daysAlive)
        {
            this.firstName = firstName;
            this.daysAlive = daysAlive;
        }

        // constructor chaining
        public Person(string firstName, int daysAlive, string eyeColor)
            :this(firstName, daysAlive)
        {
            this.eyeColor = eyeColor;
        }

        public override string ToString()
        {
            return "First Name: " + firstName + ", Eyes: " + eyeColor + ", Days Alive: " + daysAlive;
        }

    }
}
