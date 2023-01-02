using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        /// <summary>
        /// constructor syntax
        /// </summary>
        /// <param name="args"></param>
        // Constructor bir sınıf new uygulandığı zaman çalışacak bloktur.
        // Bir sınıfın ihtiyaç duyduğu farklı parametreler var ise-
        // ve bu parametreler kullanıma göre değişkenlik gösteriyor ise-
        // constructor kullanılır
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(10);
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.List();

            Product product= new Product { Id= 1, Name = "Leptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();


            // static nesne new uygulanmadan tanımlanır ve atanan değer tüm projede-
            // herkes için aynıdır. Static nesneler ortak nesnelerdir.
            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        // private field  _ ile başlatılır. method halinde normal isimlendirilir.
        // CustomerManager customerManager = new CustomerManager(10);
        // count değerine int bir sayı verildi
        // count = _count ile private olan değişkene atandı


        //private int _count = ;
        private int _count= 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        //hiçbir değer verilmez ise 15 döndürür verilir ise o değeri döndürür

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed  {0} items!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added !");
        }

    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }


        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database to logged");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger= logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine(" Added! ");
        }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message !", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added !!!");
            Message();
        }
    }

    // static nesneler new'lenemez
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        //validation : doğulama eknikleri için kullanılabilir.
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        // cclass ierisinde sadece istenilen özellikler static olabilir

        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }

    }

}
