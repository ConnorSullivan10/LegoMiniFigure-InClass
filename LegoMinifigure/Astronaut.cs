using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{

    class Astronaut
    {
        // public property
        public Location Location { get; set; }

        // expression bodied property (always readonly)
        public bool SuitedUp => Name == "Space Person";

        //Read-Only property
        public string Name { get; }

        // Public property with a private setter
        public string Job { get; private set; }

        public int Oxygen { private get; set; }

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        //public void Promote()
        //{
        //    Job = "Commander of Janitors";
        //}

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }

    }
}
