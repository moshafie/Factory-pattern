using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Car
{
    class KIA : ICar
    {
       public string Name
        {
            get { return "KIA"; }
        }

        public void Move()
        {
            Console.WriteLine("KIA Car Moved"); ;
        }
    }
}
