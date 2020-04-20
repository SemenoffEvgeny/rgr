using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Housing.Factories
{
    public class NotRentedFactory : IHousingBaseFactory
    {
        public House Create()
        {
            return new NotRented();
        }
    }
}
