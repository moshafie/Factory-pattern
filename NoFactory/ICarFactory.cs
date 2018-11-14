using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFactory
{
    interface ICarFactory
    {
        ICar Create(string CarType);
    }
}
