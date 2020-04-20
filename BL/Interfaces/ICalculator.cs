using BL.Housing;
using BL.Sitizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interfaces
{
    public interface ICalculator
    {
        double Calc(House house, Sitizen sitizen);
    }
}
