using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFactory
{
    class Nullcar : ICar
    {
       public string Name { get { return "NoCar";} }

        public void Move()
        {
           
        }
    }
}
