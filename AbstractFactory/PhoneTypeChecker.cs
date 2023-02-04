//Ethan Buchanan
//2-3-23
//CSCI352
//PhoneTypeChecker implementation, creates objects for the differnt comapanies of phones
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PhoneTypeChecker
    {
        public enum Manufacturers
        {
            Samsung,
            HTC,
            Nokia
        }
        Manufacturers manu;
        IPhoneFactory factory;

        public PhoneTypeChecker(Manufacturers m)
        {
            if (m == Manufacturers.Samsung) 
            {
                SamsungFactory samFact = new SamsungFactory();
                manu = Manufacturers.Samsung;
                factory = samFact;
            }
            if (m == Manufacturers.HTC)
            {
                HTCFactory HTCFact = new HTCFactory();
                manu = Manufacturers.HTC;
                factory = HTCFact;
            }
            if (m == Manufacturers.Nokia)
            {
                NokiaFactory NokiaFact = new NokiaFactory();
                manu = Manufacturers.Nokia;
                factory = NokiaFact;
            }

        }
        public  void CheckProducts()
        {
            Console.WriteLine("The " + manu + " has two phones:" + " the " + factory.getSmart().getName() + " and " + factory.GetDumb().getName() + ".");
        }
    }
}
