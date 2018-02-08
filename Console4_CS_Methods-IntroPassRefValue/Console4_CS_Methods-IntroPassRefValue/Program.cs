using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4_CS_Methods_IntroPassRefValue
{
    class Program
    {
        static void Main(string[] args)
        {

            // =======================================================================

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ======== Methods and more ... ======= ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // method parameters/arguments are information the method needs to run
            // like Console.Write(needed argument/parameters here);

            MethodNameAdd(14, 16);
            int getMethodReturnValue = MethodNameAddInt(12, 7);



            // ========  !!!  ========  passing by reference vs. passing by value ========


            // Pass by VALUE =================================================
            // Structs, basic data types, many methods, are passed by value
            // passes the value, but doesn't change the variable by itself

            int student1Grade = 75;
            Console.WriteLine(" Student's grade BEFORE extra credit line: {0}", student1Grade);
            // returns 75

            GiveExtraCredit(student1Grade);
            Console.WriteLine(" Student's grade AFTER extra credit line: {0}", student1Grade);
            // returns 75

            // this was my hack to get value by reference
            int student1GradeInt = GiveExtraCreditInt(student1Grade);
            Console.WriteLine(" Student's grade AFTER extra credit INT line: {0}", student1GradeInt);
            // returns 78

            Console.WriteLine("");
            Console.WriteLine("");



            // Pass by REFERENCE =================================================
            // Class passes by reference
            // arrays are actually classes
            // notice the NEW keyword in use ... means it's a class

            int[] grades = new int[1];
            grades[0] = 75;

            Console.WriteLine("Student array grade BEFORE extra credit method: {0}", grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Student array grade AFTER extra credit method: {0}", grades[0]);






        } // end Main Method


        // Pass by REFERENCE Methods (Classes) =================================================

        public static void GiveExtraCreditArray(int[] grades)
        {
            //IRL this would be a for loop - but just using 1 student
            grades[0] += 3;
        }


        // Pass by VALUE Methods:  =================================================

        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine(" Student's grade INSIDE extra credit method: {0}", studentsGrade);
            // returns 78
        }

        public static int GiveExtraCreditInt(int studentsGradeInt)
        {
            studentsGradeInt += 3;
            Console.WriteLine(" Student's grade INSIDE extra credit INT method: {0}", studentsGradeInt);
            return studentsGradeInt;
            // returns 78
        }



        // Basic Method stuff:  =================================================

        // method parameters/arguments are information the method needs to run
        // like Console.Write(needed argument/parameters here);

        // void has no return type ... so I can't use it in a formula ie
        //  This doesn't work: answer = MethodNameAdd(2,3);

        public static void MethodNameAdd(int num1, int num2)
        {
            int methodResult = num1 + num2;
            Console.WriteLine(methodResult);
            Console.WriteLine("");
        }


        public static int MethodNameAddInt(int num1, int num2)
        {
            int methodResultInt = num1 + num2;
            Console.WriteLine(methodResultInt);
            Console.WriteLine("");
            return methodResultInt;
        }










    }  // end class Program
}  // end namespace

