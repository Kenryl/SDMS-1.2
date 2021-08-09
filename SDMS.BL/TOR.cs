using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;


namespace SDMS
{


    public class TOR //Transcript of Record, para sa mga graduated students and sa mga lilipat ng ibang school
    {

        public static void Admin()
        {

            string studname1 = ("Murro, Bryll Kenryl T.");
            string studname2 = ("Alejandre, Adrian S.");
            Console.WriteLine("\n");

            Console.WriteLine("Enter Student Name: ");
            string studname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please wait for the Transcript of Record............");
            Thread.Sleep(1000);

            if (studname == (studname1))
            {
                Console.WriteLine("Done! You may now claim it at the office.");
                Console.WriteLine("\n");

            }
            else if (studname == (studname2))
            {
                Console.WriteLine("Incomplete! Please go to admin office");

            }
            else
                Console.WriteLine("Invalid!");





        }
    }
}