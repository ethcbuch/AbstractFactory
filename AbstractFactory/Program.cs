//Ethan Buchanan
//2-3-23
//CSCI352
//Main implementation runs through each company and tells what phones they have

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (var company in Enum.GetValues(typeof(PhoneTypeChecker.Manufacturers)))
            {
                PhoneTypeChecker check = new PhoneTypeChecker((PhoneTypeChecker.Manufacturers)company);
                check.CheckProducts();
            }

            Console.ReadKey();
        }
    }
    }
