using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //product
    public abstract class ISavingsAccount
    {
        public decimal  Balance { get; set; }

    }
    //concrete Product
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }
    //concrete Product
    public class NationlSavingsAcct : ISavingsAccount
    {
        public NationlSavingsAcct()
        {
            Balance = 2000;
        }
    }
    //creator
    interface ICreitUnionFactory
    {

        ISavingsAccount GetSavingsAccount(string acctNo);
    }
    //concrete Creators
    public class SavingAcctFactory : ICreitUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI".ToLower())) 
            {
                return new CitiSavingsAcct();
            }    
            else
           if (acctNo.Contains("National".ToLower())) 
            {
                return new NationlSavingsAcct();
            }
        else 
        throw new ArgumentException("Invalid Accound Number");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

         var factory=  new SavingAcctFactory () as ICreitUnionFactory;
          var citibalanc=  factory.GetSavingsAccount("citi-321");
            var nationalacct = factory.GetSavingsAccount("national-987");
            Console.WriteLine($"My citi balance is${citibalanc.Balance} \n"+
                $"and national balance is ${nationalacct.Balance}");
        }
    }
}
