using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName 
        {   get
            {
                return this.firstName;
            } 
            private set
            {
                if (value.Lenght < 3)
                {
                    throw new ArgumentExeption("First name cannot contain fewer than 3 symbols!");
                }
                return this.firstName = value;
            } 
        }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                percentage /= 2; 
            }

            Salary += Salary * percentage / 100;
        }
    }
}
