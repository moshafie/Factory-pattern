using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFactory
{
    class BMW:ICar
    {

     
        public string Name {  
            
         get     {   return "BMW"; }

        }

        public void Move()
        {
            Console.WriteLine("BMW Car Moved");
        }
    }
}
