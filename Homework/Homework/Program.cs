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
            stu1.GetInfo();
            stu1.FullName();
            Teacher t1 = new Teacher("Məhəmməd", "Mustafayev", 20, 1200);
            t1.GetInfoTeacher();
            t1.FullName();
            t1.GetInfo();
        }
    }
}
