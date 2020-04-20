using BL.Housing;
using BL.Interfaces;
using BL.Sitizens;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services
{
    public class RateCalculator : ICalculator
    {
        public double Calc(House house, Sitizen sitizen)
        {
            return house.getIndex() * sitizen.getRate();
        }
    }
}
