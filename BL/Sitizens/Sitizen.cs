using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Sitizens
{
    public abstract class Sitizen
    {
        private double rate = 10;

        public virtual double getRate()
        {
            return this.rate;
        }
    }
}
