using System;

namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");
            var astronatu2 = new Astronaut("Space Lady", "Janitor");
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today)
            // line 15 can also be stated with curly brackets, which would be called an object initializer
            {
                Friendly = true
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1924,12,1))
            // line 15 can also be stated with curly brackets, which would be called an object initializer
            {
                Friendly = false
            };

            fatso.Spook();
            fatso.Haunt("Whipstaff Manor");
            fatso.Spook();
        }
    }
}
