using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Model
{
    class bus:Vehicle
    {
        public bus()
        {

        }
        public bus(string model)
        {
            this.model = model;
        }
        public bus(string model, string color) : this(model)
        {
            this.color = color;
        }
        public bus(string model, string color, int cycle) : this(model, color)
        {
            this.cycle = cycle;
        }
        public bus(string model, string color, int cycle, int driveway) : this(model, color, cycle)
        {
            this.driveway = driveway;
        }
        public bus(string model, string color, int cycle, int driveway, int passengercount) : this(model, color, cycle, driveway)
        {
            this.passengercount = passengercount;
        }

        public bus(string model, string color, int cycle, int driveway, int passengercount, int drivetime) : this(model, color, cycle, driveway, passengercount)
        {
            this.drivetime = drivetime;

        }
    }
}
