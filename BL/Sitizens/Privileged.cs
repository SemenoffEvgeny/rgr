using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Sitizens
{
    class Privileged : Sitizen
    {
        public override double getRate()
        {
            return base.getRate() * 0.5;
        }
    }
}
