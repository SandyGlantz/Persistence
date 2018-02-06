using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CS_SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {

// Switch statements only check for a specific value.
            //    They will NOT work for < or > statements
            //    It has to equate to == values

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Switch statement: ");
            Console.WriteLine(" ");

            // Example:

            //Console.WriteLine("Enter your preferred pet: cat, dog, or human: ");
            //string favPet = Console.ReadLine();
            //Console.WriteLine("{0} is your favorite pet", favPet);
            //Console.WriteLine(" ");

            Console.WriteLine("Enter your preferred pet by number: 1=cat, 2=dog, or 3=human: ");
            int favPetNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} is your favorite pet", favPetNum);
            //Console.WriteLine(" ");


            Console.WriteLine(" ");

            // switch is the keyword ...
            // pet is what is being checked (in this case an int defined above)
            switch (favPetNum)
            {
                // case is the keyword for check
                // "1" is the value entered for cat (being checked from ReadLine)
                // break says to exit program after completing code
                // a little like "return" 
                // without a break - the program breaks.  Called "falling through"
                // Java allows "fall through" - Not C#


    // ********* cool note if deleted content such as: *********
                        //case 1:
                        //case 2:
                        //    {   Console.WriteLine("Switch logic says you picked dog.  Ick. 50 points.");
                        //        break;  }
                // if 1 OR 2 is entered - Case 2 output is activated
                // if 2 info deleted - 3 value would apply - it doesn't have to be empty at the start.

                case 1:
                    {
                        Console.WriteLine("Switch logic says you picked cat.  100 points!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Switch logic says you picked dog.  Ick. 50 points.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Switch logic says you picked human.  Interesting choice.");
                        break;
                    }
                default:  // equivalent to "else"
                    {
                        Console.WriteLine("Invalid choice.");
                        break;
                    }

            }





            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Quickie conditional: ");
            Console.WriteLine(" ");

// quickie conditional: (conditional is an if statment on the fly ...)
            int x = 14;     // IRL an input or var
            int sgBday = x;
            int y = 16;     // IRL an input or var
            int kgBday = y;
            string sgBmonth = "September";
            string kgBmonth = "June";

            // this says ... if the biggestNumber is sgBday, print sgBmonth, else print kgMonth
            // note: errors when putting string in output, i.e., ? "September" : "June";
            string biggestNumber = sgBday > kgBday ? sgBmonth : kgBmonth;

            Console.WriteLine(biggestNumber);
            Console.WriteLine("");
            Console.WriteLine("Reversed value, different setup:");
            //Reversed conditions and setup:
            Console.WriteLine(sgBday < kgBday ? "September" : "June");
            Console.WriteLine("");






            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Quickie while loop: ");
            Console.WriteLine(" ");

// ===============  quickie WHILE and FOR LOOPS: 
            int A = 0;   
            while (A < 5)
            {
                Console.WriteLine("while looping ...");
                A++;    // this adds 1 to A each time it does the above 
            }



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Indefinite loop - what while is best at ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int runningTotal = 0;
            Console.WriteLine("Enter a number a couple times ... then enter -1 to quit and see total.");
            int totalInputNumber = int.Parse(Console.ReadLine());

            while (totalInputNumber != -1)
            {
                runningTotal += totalInputNumber;
                Console.WriteLine("Enter a number a couple times ... then enter -1 to quit and see total.");
                totalInputNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            Console.WriteLine("The total of the numbers entered is: " + runningTotal);









            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("The foreign for loop - best at definite loops ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // i        = counter variable
            // i < 5    = condition
            // i++      = alter the counter
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Loop iterations ");
            }


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("The foreign for loop - with user controlled variable ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Enter a nuber for the number of repeating messages to see, please.");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("For Loop iterations with user input");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");




            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Adding all numbers between 1 and 50 ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int sum = 0;
            for (int i = 1; i < 51; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers 1 through 50 is " + sum);


        }
    }
}
