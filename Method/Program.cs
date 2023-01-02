using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();

            // değişken olarak ne atarsan var onu döndürür
            //var result = Add2(20,30);
            //Console.WriteLine(result);

            // değişken olarak ne atarsan var onu döndürür
            //var result2 = Add3(20);
            //var result22 = Add3(20,35);

            //Console.WriteLine(result);
            //Console.WriteLine(result22);

            //------

            //int number1 ;
            //int number2 = 100;
            //var result55 = Add4(out number1, number2);
            //Console.WriteLine(result55);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Ekle(1,2,3,4,5,6));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added !");
        }

        // Parametreli metod
        static int Add2 (int number1, int number2)
        {
            var result5 = number1+ number2;
            return result5;
        }

        // Default parametreli metodlar
        // default parametre her zaman en sonda verilir.
        // değer verilmeyen parametre default değeriini kullnalır

        static int Add3(int number1, int number2=25)
        {
            var result2 = number1 + number2;
            return result2;
        }

        //Ref key word, number1'i muhakkak set etmek gerekir
        //Out key word, number1'i set etme gereksinimi yoktur.
        //metod içerisinde muhakkak set etmek gerekir

        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // Metod overload - aşırı yükleme
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
         

        // Params
        static int Ekle(params int[] numbers)
        {
            return numbers.Sum();
        }

        

    }
}
