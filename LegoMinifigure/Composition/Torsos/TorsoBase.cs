using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigure.Composition.Heads;

namespace LegoMinifigure.Composition.Torsos
{
    //abstract modifies the class keyword so that you can't create another instance
    abstract class TorsoBase : IColorful
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        //below means anything that inherits from this class, must implement a similar looking method. Only works in an abstract class
        public abstract void Flex();
        // below means anything that inherits from this class, can change how the breathe method works
        public virtual void Breathe()
        {
            Console.WriteLine("Inhale, Exhale...");
        }

        public LegoColor Color => LegoColor.Yellow;
    }
}
