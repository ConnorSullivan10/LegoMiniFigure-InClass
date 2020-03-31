using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigure.Composition.Heads;

namespace LegoMinifigure
{
    //Difference between abstract and interface (interview question)
    //abstract class can only be inherited one time, it can define base level behavior, and choose to leave behavior off
    //interfaces define what the publicly accesible methods on a class can be, and a single class can implement as many interfaces they want, and you can't define behavior (ie. contract analogy)
    interface IMoveable
    {
        void Move(int howFar);
    }

    interface ILegoPiece : IMoveable, IColorful
    {

    }
}
