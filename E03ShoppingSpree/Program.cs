using System;
using System.Collections.Generic;
using System.Linq;

namespace E03ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Peter=11; George=4
            //Bread=10; Milk=2;
            //Peter Bread
            //George Milk
            //George Milk
            //Peter Milk
            //END
            Dictionary<string, Person> peopleKvp = new Dictionary<string, Person>();
            Dictionary<string, Product> productKvp = new Dictionary<string, Product>();

            string[] people = Console.ReadLine()
                .Split(new char[] {'=',';' }, StringSplitOptions.RemoveEmptyEntries);

            string[] products = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            

            try
            {
                for (int i = 0; i < people.Length; i += 2)
                {
                    string name = people[i];
                    decimal money = decimal.Parse(people[i + 1]);

                    Person person = new Person(name, money);

                    peopleKvp.Add(name, person);
                }

                for (int i = 0; i < products.Length; i += 2)
                {
                    string name = products[i];
                    decimal cost = decimal.Parse(products[i + 1]);

                    Product product = new Product(name, cost);

                    productKvp.Add(name, product);
                }

                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] commandInf = command.Split();
                    string personName = commandInf[0];
                    string productName = commandInf[1];

                    Person person = peopleKvp[personName];
                    Product product = productKvp[productName];

                    bool isAdded = person.AddProduct(product);
                    if (!isAdded)
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    command = Console.ReadLine();
                }

                foreach (var (name, person) in peopleKvp)
                {
                    string productsInfo = person.Products.Count > 0
                        ? string.Join(", ", person.Products.Select(x=> x.Name))
                        : "Nothing bought";

                    Console.WriteLine($"{name} - {productsInfo}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
