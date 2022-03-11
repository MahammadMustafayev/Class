using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Model
{
    class bicycle:Vehicle
    {
        public bicycle()
        {

        }
        public bicycle(string model)
        {
            this.model = model;
        }
        public bicycle(string model, string color) : this(model)
        {
            this.color = color;
        }
        public bicycle(string model, string color,int cycle):this(model,color)
        {
            this.cycle = cycle;
        }
        public bicycle(string model, string color, int cycle, int driveway) : this(model, color,cycle)
        {
            this.driveway = driveway;
        }
        public bicycle(string model, string color, int cycle, int driveway, int passengercount) : this(model, color, cycle, driveway)
        {
            this.passengercount = passengercount;
        }

        public bicycle(string model, string color, int cycle, int driveway, int passengercount, int drivetime) : this(model, color, cycle, driveway, passengercount)
        {
            this.drivetime = drivetime;

        }

        


    }
}
