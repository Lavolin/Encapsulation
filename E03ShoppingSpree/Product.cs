using System;
using System.Collections.Generic;
using System.Text;

namespace E03ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AccessViolationException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new AccessViolationException("Money cannot be negative");

                }
                cost = value;
            }
        }

    }
}
