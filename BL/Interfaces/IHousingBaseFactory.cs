using System;
using System.Collections.Generic;
using System.Text;
using BL.Housing;

namespace BL.Interfaces
{
    public interface IHousingBaseFactory
    {
        House Create();
    }
}
