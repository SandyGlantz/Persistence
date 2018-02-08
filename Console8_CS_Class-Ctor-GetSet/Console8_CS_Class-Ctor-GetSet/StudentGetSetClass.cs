using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8_CS_Class_Ctor_GetSet

    // Get-Set allows for access to info in other classes - or change the data
    // Lecture 54
{
    class StudentGetSetClass
    {
        private string name; 
        private int age;
        private double finalGrade;
        private string comment;



        public string GetName()  // this is a GET function
        {
            if (age >= 18)
                return name;
            else return " Name unavailable.  This student is a minor.";
        }


        public void SetName(string newName)  // this is a SET function
        {
            if (newName != "")
            {
                name = newName;
            }
            
        }



        // =====  These are the constructors: (special type of method that instantiates objects)
        // =====  Constructors HAVE NO RETURN TYPE


        public StudentGetSetClass(string name, int age)
        {
            this.name = name;   // this.name = the name at the top of the page (class name)
                                // name = the parameter in this constructor 
            this.age = age;
        }


        // backwards use (fewer arguments means to set a default value to use)
        // this sets a default age value of zero rather than just having one argument
        public StudentGetSetClass(string name) : this(name, 0)
        {
        }


        public StudentGetSetClass(string name, int age, double finalGrade) :this(name, age)
        {
            this.finalGrade = finalGrade;
        }


        public StudentGetSetClass(string name, int age, double finalGrade, string comment) : this(name,age,finalGrade)
        {
            this.comment = comment;
        }



        public void SayHello()
        {
            Console.WriteLine(" Hello from the other side ... it's {0}. ", name);
        }

    }
}
