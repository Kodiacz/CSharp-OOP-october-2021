using System;
using System.Collections.Generic;
using System.Text;
using _2._5BirthdayCelebrations;

namespace _2._5BirthdayCelebrations
{
    public class Robot : IModelable, IIdentifiable
    {
        public Robot(string model, string iD)
        {
            Model = model;
            ID = iD;
        }

        public string Model { get; set; }
        public string ID { get; set; }
    }
}
