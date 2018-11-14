using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoFactory
{
    class ICarAnyFactory : ICarFactory
    {
        List<Type> types;
        public ICarAnyFactory()
        {

            types = Assembly.GetExecutingAssembly().GetTypes()
                 .Where(t => typeof(ICar).IsAssignableFrom(t)
               && t.IsClass).ToList();

        }
        public ICar Create(string CarType)
        {
            ICar car=new Nullcar();
            Type type = types.FirstOrDefault(c => c.Name.ToLower() == CarType.ToLower());
            if (type!=null)
            {
                car = (ICar)Activator.CreateInstance(type);
            }
           
    
            return car;
        }
    }

}
