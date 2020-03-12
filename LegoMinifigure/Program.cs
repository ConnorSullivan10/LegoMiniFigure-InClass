using System;
using LegoMinifigure.Composition.Heads;
using LegoMinifigure.Composition.Legs;
using LegoMinifigure.Composition.Torsos;
namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var atorso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var dtorso = new DadBodTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, dtorso, legs);
            astronaut.DoYourJob(100);

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
