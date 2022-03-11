using System;
using ClassTask.Model;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bicycle cycle1 = new bicycle("Nissan","Sari" ,100,1,5,4);
            Console.WriteLine($"{cycle1.model} {cycle1.color} {cycle1.driveway} {cycle1.drivetime} {cycle1.passengercount} {cycle1.cycle}");
        }
    }
}
