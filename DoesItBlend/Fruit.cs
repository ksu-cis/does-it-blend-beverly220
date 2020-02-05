using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        public virtual string Blend()
        {
            return "Goop";
        }
        //abstract means no body & use override; uses individual method ONLY
        //virtual means body & use new or override in individual class; uses base class when necessary
    }
}
