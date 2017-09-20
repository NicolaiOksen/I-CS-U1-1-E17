using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExamples
{
    public class Person
    {

        private string name;
        private DateTime dateOfBirth, dateOfDeath;

        public Person(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.dateOfDeath = DateTime.MaxValue;
        }

        public Person(string name) : this (name, DateTime.Now.AddYears(-18).Date) {}

        public string Name
        {
            get { return name; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
        }

        public override string ToString()
        {
            return "Person: " + name + " " + dateOfBirth;
        }

    }
}
