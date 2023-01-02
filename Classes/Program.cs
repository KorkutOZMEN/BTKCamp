using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class içerisindeki metodları kullanmak için örneği oluşturulmalı
            CustomerManager customerManager= new CustomerManager();
            ProductManager productanager = new ProductManager();
            
            customerManager.Add();
            customerManager.Update();
            productanager.Add();
            productanager.Update();


            Customer customer = new Customer();
            customer.City= "Ankara";
            customer.Gender = "Bay";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id= 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ", Gender = "Bayan"
            };

            Console.WriteLine(customer2.FirstName);
            

            Console.ReadLine();
        }
    }
}
