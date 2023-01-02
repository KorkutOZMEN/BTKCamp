using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Farklı bir projedeki sınıfa ulaşmak için o sınıf public olarak 
            Course2 course = new Course2();
        }
    }
}
