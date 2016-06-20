using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                //only if true between the parens then the following will run
            {
                //string message = "You won a new car!";
                //Console.WriteLine(message);
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                //string message = "You won a new boat";
                // Console.WriteLine(message);
                message = "You won a new boat";
            }
            else if (userValue == "3")
            {
                //string message = "you won a new cat!";
                // Console.WriteLine(message);
                message = "you won a new cat!";
            }
            else
            {
                // string message = "Sorry we didn't understand. ";
                // Console.WriteLine(message);
                message = "Sorry we didn't understand. ";
                message += "You Lose!!!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //if is a decision statement

            //**************************
            Console.WriteLine("Jay's 2nd Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue2 = Console.ReadLine();

            string message2 = (userValue2 == "1") ? "boat" : "cat";
            Console.Write("You won a ");
            Console.Write(message2);
            Console.Write(".");
            Console.ReadLine();

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue2, message2);

            //use of {0} within a string takes the variables at the end of the line and inserts them



        }
    }
}
