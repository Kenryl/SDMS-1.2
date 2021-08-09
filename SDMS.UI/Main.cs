using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMS.BL;




namespace SDMS.UI
{
    class Login
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to SDMS!");

            Console.Write("Username: ");
            string UsrName = Console.ReadLine();
            Console.Write("Password: ");
            string PsWord = Console.ReadLine();



            if (UsrName == "admin" & PsWord == "admin")
            {

                Console.WriteLine("||||You are logged in!||||");
                Console.Clear();


                for (var userInput = UserInputValue();
                              userInput != actions.IndexOf('X');
                              userInput = UserInputValue())
                {

                    if (userInput.Equals(actions.IndexOf('A')))
                    {
                      
                        AdminRe.Admin();


                    }
                    else if (userInput.Equals(actions.IndexOf('B')))
                    {
                        Clearance.Admin();
                    }
                    else if (userInput.Equals(actions.IndexOf('C')))
                    {
                        TOR.Admin();
                    }


                }
                Console.WriteLine("Exiting.");
            }
            else
            {
                Console.WriteLine("ERROR!!!!!");
            }
        }





        public static List<string> logs = new List<string>();
        public static List<string> actionsDescription = new List<string>()
                        { "'A' Admission Requirements","'B' Clearance","'C' Transcript of Record","'X' EXIT"};
        public static List<char> actions = new List<char>() { 'A', 'B', 'C', 'X' };

        public static object Class2 { get; private set; }

        static void ShowUserOptions()
        {

            foreach (var decription in actionsDescription)
            {
                Console.WriteLine(decription);
            }
        }

        static int UserInputValue()
        {
            ShowUserOptions();

            Console.Write("Enter Here: ");
            var action = (Convert.ToChar(Console.ReadLine().ToUpper()));
            var actionIndex = actions.IndexOf(action);
            Console.Clear();

            if (actionIndex != -1)
            {

                return actionIndex;
            }
            else
            {
                var message = "INVALID INPUT! Please try again.......";
                Console.WriteLine(message);
                Console.Clear();

                return UserInputValue();
            }
        }
    }
