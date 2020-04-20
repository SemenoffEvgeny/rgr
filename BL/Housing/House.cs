using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing
{
    public  abstract class House
    {
        public double index = 1;

        public virtual double getIndex()
        {
            return this.index;
        }
    }
}
