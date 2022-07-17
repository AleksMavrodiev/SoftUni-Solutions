using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> persons = new List<Person>();
                List<Product> products = new List<Product>();
                string[] personsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < personsInfo.Length; i++)
                {
                    string[] personData = personsInfo[i].Split('=');
                    string name = personData[0];
                    double money = double.Parse(personData[1]);
                    persons.Add(new Person(name, money));
                }

                string[] productsData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productsData.Length; i++)
                {
                    string[] productInfo = productsData[i].Split('=');
                    string productName = productInfo[0];
                    double cost = double.Parse(productInfo[1]);
                    products.Add(new Product(productName, cost));
                }

                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split();
                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];
                    Person person = persons.FirstOrDefault(x => x.Name == personName);
                    Product product = products.FirstOrDefault(x => x.Name == productName);
                    Console.WriteLine(person.PurchaseProduct(product));
                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
