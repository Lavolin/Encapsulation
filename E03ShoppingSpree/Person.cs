using System;
using System.Collections.Generic;
using System.Text;

namespace E03ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;

            this.products = new List<Product>();
        }

        public IReadOnlyCollection<Product> Products 
            => this.products;

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

        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    throw new AccessViolationException("Money cannot be negative");

                }
                money = value;
            }
        }

        public bool AddProduct(Product product)
        {
            if (Money - product.Cost < 0)
            {
                return false;
            }

            products.Add(product);
            Money -= product.Cost;
            return true;
        }
    }
}
