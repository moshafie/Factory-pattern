using Factory.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    class BmwFactory : ICarFactory
    {
        public ICar Create()
        {
            return new BMW(); 
        }
    }
}
