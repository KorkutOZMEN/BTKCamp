using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aray list tip güvenli değildir. Not type safe
            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]); // key value , anahtar ile ona ait değere ulaşılır

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Burak" });
            customers.Add(new Customer { Id = 2, FirstName = "Talha" });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Bekir"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id = 1,FirstName = "Fatma"},
                new Customer{ Id = 2,FirstName = "Türkan"}
            });

            var count = customers.Count();
            //customers.Clear(); 
            //Console.WriteLine(cities.Contains("Ankara"));
            var index = customers.IndexOf(customer2);// elemanın kaçıncı sırada olduğunu verir
            var index2 = customers.LastIndexOf(customer2);// elemanın sondan kaçıncı sırada olduğunu verir

            customers.Add(customer2);

            Console.WriteLine("Count : {0}", count);
            Console.WriteLine("Index : {0}", index);
            Console.WriteLine("Index : {0}", index2);
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }


        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }




}
