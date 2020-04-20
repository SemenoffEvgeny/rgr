using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Sitizens
{
    public class OlderAge : Sitizen
    {
        public override double getRate()
        {
            return base.getRate() * 1.5;
        }
    }
}
