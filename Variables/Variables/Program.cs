using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //want to do work inside of here
            //variable is a bucket inside of memeory where you can retrieve memory from.
            //need to declare the variable and create those buckets
            int xvariable;
            int yvariable;
            //green squigly line tells us that the varible is not being used
            //int is a whole number
            xvariable = 7;
            yvariable = xvariable + 3;

            Console.WriteLine(yvariable);
            Console.ReadLine();

            //right hand side = left hand side
            //this assigns the left hand side into the right hand side

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            //write just writes out the statement and will NOT go to the next line like writeline will. This will wait at the end of the line for input.

            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

            Console.ReadLine();

            // + is the concatenation symbol
            // ***Make your code human readable, don't use x and y
            //control + . and you can refactor naming of things





        }
    }
}
