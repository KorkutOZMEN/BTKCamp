using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        // private class seviyesinde sadece tanımlandığı blokta geçerli
        // protected inherit seviyesine çıkar
        // İnternal ait olduğu proje içerisinde geçerli
        // public 


        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        

        protected int id { get; set; }
        
        public void Save()
        {

        }
    }

    class Student:Customer
    {
        public void Save()
        {
            
        }
    }

    internal class Course
    {
        public string Name { get; set; }

        // İç içe klaslarda private sınıf kullanılabilir.
        private class NestedClass
        {

        }

    }

    public class Course2
    {
        public string Name { get; set; }

        // İç içe klaslarda private sınıf kullanılabilir.
        private class NestedClass
        {

        }

    }
}
