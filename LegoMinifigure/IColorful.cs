using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigure.Composition.Heads;

namespace LegoMinifigure
{
    // everything on interface is implicitly and explicitly public. Can't add access modifiers to an interface
    interface IColorful
    {
        LegoColor Color { get; }
    }
}
