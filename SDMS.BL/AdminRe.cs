using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace SDMS
{


    public class AdminRe //AdminReg
    {
        public static void Admin()

        {
            string studname1 = ("Murro, Bryll Kenryl T.");
            string studname2 = ("Alejandre, Adrian S.");
            Console.WriteLine("\n");

            Console.WriteLine("Enter Student Name: ");
            string studname = Console.ReadLine();
            Console.Clear();

            if (studname == (studname1))
            {
                Console.WriteLine("Documents completed!");
                Console.WriteLine("\n");

            }
            else if (studname == (studname2))
            {
                Console.WriteLine("Documents incomplete!");

            }
            else
                Console.WriteLine("Invalid!");
        }
    }
}