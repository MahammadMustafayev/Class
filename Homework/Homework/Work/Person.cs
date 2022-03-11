using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Work
{
    class Person
    {
        public string name;
        public string surname;
        public int age;

        public void FullName()
        {
            Console.WriteLine($"Ad:{name} Soyad:{surname}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Ad:{name} Soyad:{surname} Yash:{age}");
        }

        
    }
}
