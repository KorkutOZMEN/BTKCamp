using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1;

            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
             

            DataTable dataTable; // = new DataTable(); yapılabilir ancak-
                                 // referansı değişeceği için bu işlem yapılmadan da kullanılabilir
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }



    }
}
