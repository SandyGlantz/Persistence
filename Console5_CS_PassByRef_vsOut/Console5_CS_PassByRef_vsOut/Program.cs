using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5_CS_PassByRef_vsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bonus - Getting values out of void ... giggle ...



            // Version 1:
            // int studentGrade = 75;
            // GiveExtraCredit(studentGrade);


            // Version 2:
            // value MUST be established for REF to work
            // can NOT be " int studentGrade; " ... must be initialized
            // also can NOT be given the intial value in the method
            // int studentGrade = 75;   
            // GiveExtraCredit(ref studentGrade);


            // Version 3:
            // intial value MUST be declared in the method
            // having the 100 here means nothing ...   
            // int studentGrade = 100; = still returns 78 regradless of value assigned here.
            // Still needs to be declared here for everything to work:
            // int studentGrade;
            // GiveExtraCredit(out studentGrade);


            // Console.WriteLine(" The total after the method used in main: " + studentGrade);
            // returns: Version1: 75 (variable passed by value, not by ref -different memory locations)
            // returns: Version2: 78 (variable passed used REF keyword)
            // returns: Version3: 78 (variable passed via OUT keyword)


            // Example of multiple OUT variables:

            int add;    // this variable name can be anything
            int multi;  //   - same or different  from method (ref two lines below)
            AddAndMultiply(4, 16, out add, out multi);

            // public static void AddAndMultiply(int a, int b, out int added, out int multi)
            // { added = a + b;     multi = a * b; }


            Console.WriteLine(add);
            Console.WriteLine(multi);


            



    }  // end Main()




        //  ============  Version 1: new value not passed, standard method: ===========

        // Lecture 43: Ref Keyword ; Jesse Dietrichson

        /*
        public static void GiveExtraCredit(int studentGrade)
        {   studentGrade += 3;  }
        */




        //  ============  Version 2: using the REF keyword - the new value is passed ===========

        // Lecture 43: Out Keyword ; Jesse Dietrichson

            // REF says don't pass the value - pass the memory location so it can be changed
            // Drawback to using ref: variable must be intialized with value (see lines 22-25) 
            // 

        /*
        public static void GiveExtraCredit(ref int studentGrade)
        { studentGrade += 3; }
        */




        //  ============  Version 3: using the OUT keyword - the new value is passed ===========

        // Lecture 44: Out Keyword ; Jesse Dietrichson

            // This requires the intial value to be assigned in the method
            // 

        /*
        public static void GiveExtraCredit(out int studentGrade)
        {
            studentGrade = 75; // initial value MUST be declared inside the method
            studentGrade += 3;
        }
        */




        // example of multiple out values:
            // use VOID instead of INT ... INT is a single return value.

        public static void AddAndMultiply(int a, int b, out int added, out int multi)
        {
            added = a + b;
            multi = a * b;
        }





    }   // end Program class
}       // end namespace
