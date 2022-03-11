using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Model
{
    class car:Vehicle
    {
        public car()
        {

        }
        public car(string model)
        {
            this.model = model;
        }
        public car(string model, string color) : this(model)
        {
            this.color = color;
        }
        public car(string model, string color, int cycle) : this(model, color)
        {
            this.cycle = cycle;
        }
        public car(string model, string color, int cycle, int driveway) : this(model, color, cycle)
        {
            this.driveway = driveway;
        }
        public car(string model, string color, int cycle, int driveway, int passengercount) : this(model, color, cycle, driveway)
        {
            this.passengercount = passengercount;
        }

        public car(string model, string color, int cycle, int driveway, int passengercount, int drivetime) : this(model, color, cycle, driveway, passengercount)
        {
            this.drivetime = drivetime;

        }
    }
}
