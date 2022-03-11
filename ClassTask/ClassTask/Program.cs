using System;
using ClassTask.Model;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bicycle b1 = new bicycle("Avon","sari" ,100,55,1,2);
            Console.WriteLine($"Velosipedin Adı:{b1.model} Rəngi:{b1.color} Getdiyi Yol:{b1.driveway} Vaxt:{b1.drivetime} Sərnişin Sayı:{b1.passengercount} Təkər Sayı:{b1.cycle} ");
            b1.GetSpeed();

            bus bus1 = new bus("Solaris", "bənövşəyi", 1000, 30, 60, 4);
            Console.WriteLine($"Avtobusun Adı:{bus1.model} Rəngi:{bus1.color} Getdiyi Yol:{bus1.driveway} Vaxt:{bus1.drivetime} Sərnişin Sayı:{bus1.passengercount} Təkər Sayı:{bus1.cycle}");
            bus1.GetSpeed();

            car car1 = new car("Nissan", "sari", 2000, 25, 5, 4);
            Console.WriteLine($"Maşının Adı:{car1.model} Rəngi:{car1.color} Getdiyi Yol:{car1.driveway} Vaxt:{car1.drivetime} Sərnişin Sayı:{car1.passengercount} Təkər Sayı:{car1.cycle}");
            car1.GetSpeed();


        }
    }
}
