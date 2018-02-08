using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CS_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================================================================


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Arrays, with a FOR loop ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int[] grades = { 66, 88, 95, 90, 100 };

            // add three points extra credit to all scores
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }


            // =======================================================================


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Arrays, output backwards ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int[] grades2 = { 66, 88, 95, 90, 100 };

            // add three points extra credit to all scores
            // and display them backwards ... -1 on length is the key ... in the int value
            // and the condition becomes i GREATER than/equal to 0
            for (int i = grades2.Length - 1; i >= 0; i--)
            {
                grades2[i] += 3;
                Console.WriteLine(grades2[i]);
            }



            // =======================================================================




            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Arrays, with a FOR EACH loop ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int[] grades1 = { 66, 88, 95, 90, 100 };


            // for each only good for displaying values
            foreach (int score in grades1)
            {
                Console.WriteLine(score);
            }




 // =======================================================================



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Arrays, SEARCH a FOR EACH loop ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string[] students = { "Senge", "Karen", "Margot", "Hyung", "Bret" };

            Console.WriteLine(" Enter Student name to search for: ");
            string studentName = Console.ReadLine();


            // using the bool keeps every condition from printing false except for one possible true.
            bool contains = false;

            for (int i = 0;     i < students.Length;    i++)
            {
                if (studentName == students[i])
                {
                    contains = true;
                    break;
                }
                // this stops the program when condition is true.                  
            }

            if (contains == true)
            {
                Console.WriteLine(" Yep...  Student is on the list");
            }

            else { Console.WriteLine("Nope"); }





// =======================================================================



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Parallel Array ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // parallel array is matching length
            int[] grades4 = { 66, 88, 95, 90, 100 };

            string[] students4 = { "Senge", "Karen", "Margot", "Hyung", "Bret" };

            Console.WriteLine(" Enter Student name to search for: ");
            string studentName4 = Console.ReadLine();


            bool contains4 = false;
            int studentGrade4 = 0;  

            for (int i = 0;     i < students.Length;        i++)
            {
                if (studentName4 == students4[i])
                {
                    contains4 = true;
                    studentGrade4 = grades4[i];
                    break;      // this stops the program when condition is true.  
                }                
            }

            if (contains4 == true)
            {
                Console.WriteLine(" Yep...  Student is on the list");
                Console.WriteLine(" And their grade is {0}", studentGrade4); 
            }
            else Console.WriteLine("Nope");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");





// =======================================================================



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Teacher program ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // set the variables
            
            Console.WriteLine(" Please enter the number of students in your class: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[numberOfStudents];
            double[] studentGrades = new double[numberOfStudents];


            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine(" Enter student number {0}'s name please: ", i + 1);
                string name = Console.ReadLine();
                studentNames[i] = name;

                Console.WriteLine(" And please enter {0}'s score: ", name); // swapped out i+1 for name
                double grade = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                studentGrades[i] = grade;

                averageGrade += grade;

                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }

            averageGrade /= numberOfStudents;
            Console.WriteLine(" The average grade of the class is {0}.", averageGrade);
            Console.WriteLine(" The highest score was {0}'s, with a {1}.", highestGradeName, highestGrade);






// =======================================================================



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Hangman program ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            Console.WriteLine(" Just like 8th grade ... Welcome to Hangman!!!");
            Console.WriteLine(" ");



            string[] wordsArray = { "cat", "dog", "sky", "hug", "fun", "zip", "you", "joy" };

            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, 8);
            string selectedWord = wordsArray[randomIndex];


            string hiddenWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }

            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word:  {0}", hiddenWord);
                Console.WriteLine("Guess a letter >> ");
                char letter = char.Parse(Console.ReadLine());

                bool containsLetter = false;

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        // if word is jump ... and letter =j ... result s/be j***
                        // ===> could this be replace?
                        // NOPE. it replaces ALL asterisks with the letter ...

                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());

                        // hiddenWord = hiddenWord.Replace("*", letter.ToString());
                        containsLetter = true;
                    }
                }

                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Good one ... {0} was found in the word", letter);
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Sorry charlie ... {0} is not a ltter in the word", letter);
                    Console.WriteLine("");
                }
                Console.ResetColor();
            }

            Console.WriteLine("Yay!! You figured out the word was {0}.", selectedWord);
            Console.WriteLine("");

















        }   // end Main
    }       // end class Program
}           // end namespace
