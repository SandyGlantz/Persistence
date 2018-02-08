using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8_CS_Class_Ctor_GetSet
{

    // LectureOnClass (52) Notes

        // A constructor is a special type of (built-in) method (action)
        // ctor job is to prepare instance of the class - sets up memory allocation based on fields
        //      It requires all fields be provided
        //      In the StudentLectureClass class, I could remove age, and still get name
        //      Adding in the ctor 



    class StudentCtorClass
    {   
        private string name; // private = camelCase
        private int age;
        private double finalGrade;
        private string comment;

        // Using the constructor in the Class means all fields will be required for use in another class
        // >>>>>  BIG NOTE !!!!!!! THIS IS ONE TIME VARIABLE NAMES MATTER ==== <<<<<<<
        // tried:
        // public StudentCtorClass(string NAME, int age, double finalGrade)
        // {   NAME = name; // THIS DOES NOT WORK
        // You are passing the private variable - not assigning a random variable name
        // this. is REQ'd for it to work



        // =====  These are the constructors: (special type of method that instantiates objects)
        // =====  Constructors HAVE NO RETURN TYPE

        // overload constructors are a thing ... maybe the final grade isn't available?
        public StudentCtorClass(string name, int age)
        {
            this.name = name;   // this.name = the name at the top of the page (class name)
                                // name = the parameter in this constructor 
            this.age = age;
        }


        // backwards use (fewer arguments means to set a default value to use)
        // this sets a default age value of zero rather than just having one argument
        public StudentCtorClass(string name) : this(name, 0)
        {
        }


        public StudentCtorClass(string name, int age, double finalGrade) :this(name, age)
        {
            this.finalGrade = finalGrade;
        }

        public StudentCtorClass(string name, int age, double finalGrade, string comment) : this(name,age,finalGrade)
        {
            this.comment = comment;
        }



        public void SayHello()
        {
            Console.WriteLine(" Hello from the other side ... it's {0}. ", name);
        }

    }
}
