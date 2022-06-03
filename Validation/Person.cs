using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


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
        public string LastName 
        { 
           get
            {
                return this.lastName;
            } 
            private set
            {
                if (value.Lenght < 3)
                {
                    throw new ArgumentExeption("Last name cannot contain fewer than 3 symbols!");
                }
                return this.lastName = value;
            } 
        }
        public int Age
        { 
           get
            {
                return this.age;
            } 
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentExeption("Age cannot be zero or a negative integer!");
                }
                return this.age = value;
            } 
        }

        public decimal Salary 
        { 
           get
            {
                return this.salary;
            } 
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentExeption("Salary cannot be less than 650 leva!");
                }
                return this.salary = value;
            } 
        }


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
