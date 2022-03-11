using System;
using Homework.Work;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Aslan", "Seferov", 20, 4);
            stu1.GetInfoStudent();
            Teacher t1 = new Teacher("Məhəmməd", "Mustafayev", 20, 1200);
            t1.GetInfoTeacher();
        }
    }
}
