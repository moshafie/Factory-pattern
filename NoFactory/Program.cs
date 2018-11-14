using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarAnyFactory factory = new ICarAnyFactory();
            ICar car = factory.Create("Kia");
            car.Move();

            Console.ReadLine();


        }

    }
}
