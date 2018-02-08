using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8_CS_Class_Ctor_GetSet
{
    class Program
    {

        // LectureOnClass (52) Notes 

            // when creating a new verison of class - the ctor is ALWAYS the same name as the class
            //  
            //          examples: (long version split into two lines to fit right on screen)
            // StudentLectClass s1 = new StudentLectClass(); == this means:
            //
            // ClassNameIsDataType newInstanceOfClassVariable_LocalVariableName = 
            //          newPlaceInMemory(=instaniation) Ctor/ConstructorBuiltinMethod()
            // 



        static void Main(string[] args)
        {




//   =========================   Lecture on Properties (55)   ==============================

            // Properties are c# specific ways to do get-set

            Console.WriteLine(" ");
            Console.WriteLine(" This starts Lesson 55 (Properties) outputs: ");



            StudentPropClass s1d = new StudentPropClass("Senge");
            // wrench in front of Name means property (after the s1d(dot))
            s1d.Name = "Alexander";
            Console.WriteLine(" From the new FULL prop formatting {0}", s1d.Name);


            StudentPropClass s2d = new StudentPropClass("Karen", " A joy to have in class");
            s2d.Comments = " Karen is a pleasure to have in class.";
            Console.WriteLine(s2d.Comments);













//   =========================   Lecture on Get-Set (54)   ==============================

            // Get-Set allows for access to info in other classes - or change the data

            Console.WriteLine(" ");
            Console.WriteLine(" This starts Lesson 54 (Get-Set) outputs: ");

            StudentGetSetClass s1c = new StudentGetSetClass("Senge", 8, 100);
            // this gets the name from a function in the Student class
            Console.WriteLine(" Student name from GetName() is {0}", s1c.GetName()); 



            StudentGetSetClass s2c = new StudentGetSetClass("Karen", 25, 99.99);
            s2c.SetName("Grace");
            Console.WriteLine(" This student has a new name: {0}.", s2c.GetName());



            // s4c = "Dingleballs"; ==> this doesn't work - can't be changed once set (because private)

            // Console.WriteLine(" " + s1b.name); THIS DOESN'T work because name is private








//   =========================   Lecture on Constructors (ctor) (53)   ==========================

            // ctor is set in the StudentCtorClass class in this lesson

            Console.WriteLine(" ");
            Console.WriteLine(" This starts Lesson 53 (Constructor) outputs: ");

            StudentCtorClass s1b = new StudentCtorClass("Senge", 56); // using overload ctor
                // Note: s1 won't work - the variable is already used in this class
            s1b.SayHello();

            StudentCtorClass s2b = new StudentCtorClass("Karen", 25, 92.92);
            // note: If I delete 25 - 
            // it would error because it would use 99.99 as her age - which needs to be an INT


            StudentCtorClass s3b = new StudentCtorClass("Bret", 49);

            StudentCtorClass s4b = new StudentCtorClass("TwinkleToes");
            s4b.SayHello();

            // s4c = "Dingleballs"; ==> this doesn't work - can't be changed once set (because private)

            // Console.WriteLine(" " + s1b.name); THIS DOESN'T work because name is private





//   =========================   Lecture on Class (52)   ==============================

            Console.WriteLine(" ");
            Console.WriteLine(" This starts Lesson 52 (Classes) outputs: ");

            StudentLectClass s1 = new StudentLectClass();
            s1.Name = "Senge";
            //s1.Age = 56;
            s1.FinalGrade = 98.55;
            s1.SayHello();  // advantage is that this code is hidden from the user of this method

            StudentLectClass s2 = new StudentLectClass();
            s2.Name = "Karen";
            s2.Age = 25;
            s2.FinalGrade = 99.99;

            StudentLectClass s3 = new StudentLectClass();
            s3.Name = "Grace";
            s3.Age = 30;
            s3.FinalGrade = 90.92;
            s3.SayHello();

             Console.WriteLine(" " + s2.Name);

            // declaration of:      int x; 
            // same as:     StudentLectClass s1;

        }

    }
}
