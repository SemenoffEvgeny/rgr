using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing
{
    public class Risky: House
    {
        public override double getIndex()
        {
            return base.getIndex() * 1.6;
        }
    }
}
