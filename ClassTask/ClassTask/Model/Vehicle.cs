using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Model
{
    class Vehicle
    {
        public int cycle;
        public int driveway;
        public string color;
        public int passengercount;
        public int drivetime;
        public string model;
        

        public Vehicle()
        {

        }
        public Vehicle(string model)
        {
            this.model = model;

        }
        public Vehicle(string model, string color) : this(model)
        {
            this.color = color;
        }
        public void GetSpeed()
        {
            Console.WriteLine("GetSpeed:" +driveway/drivetime);
        }

    }
}
