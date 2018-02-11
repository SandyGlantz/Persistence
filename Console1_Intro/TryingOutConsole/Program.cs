using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingOutConsole
{
    // using:  https://www.youtube.com/playlist?list=PLhq7kqloVlM95ROEbGpJEdpadDmtrC343

    class Program
    {
        static void Main(string[] args)
        {
            // Main is similar to Page_Load in asp.net ...
            string helloWorld = "Hello to the Console World of C#";
            int luckyNumber = 32;



            // WriteLine:
// ================== >>>>   !!!!!!!!! Control F5 -- NOT!!! just F5
// ================== >>>>  F5 flashes the screen and ends the program

            // adding a (blank) line between outputs
            Console.WriteLine(" "); 

            Console.WriteLine(helloWorld);



            // Write:  Everything is on the same line
            // Console.Write(helloWorld);



            // adding a (blank) line between outputs
            Console.WriteLine(" ");

            // Combining lines with added formatting:
            Console.WriteLine("This is a placeholder for my lucky number: {0} - exciting. Not ;-)", luckyNumber);



            // adding a (blank) line between outputs
            Console.WriteLine(" "); 

            // The second position in a placeholder assigns spaces 
            // {0,5} assigns the spaces on the right (BEFORE) the placeholder value
            // {0,-5} assigns the spaces on the left (AFTER) the placeholder value
            // !!!!!!!!!!    ==  The info must fit within the total characters ==  !!!!!!!!!!
            Console.WriteLine("Lucky number with 5 spaces:_{0,5}_Cool!!",luckyNumber);
            // Double cool is that a placeholder can be literally declared
            Console.WriteLine("Random string here: {0}; and some int value here: {1}", "$123", 5);



            // adding a (blank) line between outputs
            Console.WriteLine(" "); 



// ================== >>>>  Console input ====================

            // input is ALWAYS a string Type

            // adding a (blank) line between outputs
            Console.WriteLine(" ");


            Console.WriteLine("What is your name?: ");

            // if you start to type your name in - the console closes, unless told to get input:
            string nameEntered = Console.ReadLine();
            // Console closes after input because variable not assigned.  

            //example assignement:
            Console.WriteLine("Hello there {0}!", nameEntered);
            Console.WriteLine(" ");


            Console.WriteLine(" ");

            // To take console input of string into number doesn't work this way:
            Console.WriteLine("Enter your favorite number!");

            string favNumber = Console.ReadLine();
            Console.WriteLine(favNumber + 5);
            //returns:
            //Enter your favorite number!
            //14
            //145

            Console.WriteLine(" ");
            // to get an int out:
            Console.WriteLine("Enter your favorite number again ...");
            int favNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adding 5 equals: " +(favNumber2 + 5));
            Console.WriteLine(" ");

            // Doubles can be parsed too!
            Console.WriteLine(" ");
            // to get an int out:
            Console.WriteLine("Enter your favorite dollar amount ...");
            double favAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Adding $5.50 = : $" + (favAmount + 5.50));
            Console.WriteLine(" ");



            // using the remainder
            Console.WriteLine(" ");
            // to get an int out:
            Console.WriteLine("Enter total time in minutes only");
            int totalMinutes = int.Parse(Console.ReadLine());
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60; // % called modulus = remainder
            Console.WriteLine("This equals {0} hour(s) and {1} minute(s)" , hours, minutes );
            Console.WriteLine(" ");













        }
    }
}
