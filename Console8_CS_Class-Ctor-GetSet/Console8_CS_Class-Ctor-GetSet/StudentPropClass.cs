using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8_CS_Class_Ctor_GetSet
{
    //  Lecture 55
    //  When creating properties, the public version is PascalCase, 
    //     and the private versions and internal version are camelCase.  
    //  The property and coresponding variable should be the same name.  
    //     i.e., : private age, public property Age



    class StudentPropClass
    {
        private string name;
        private int age;
        private double finalGrade;

                // enter prop and tab twice
        public string Comments { get; set; }  
                // this is an auto-implemented property
                // it automates having private data behind the scenes at compilation
                // same rules apply about what you can and can't change


        // to make the data UNCHANGABLE (but available) 
                //  (changed Comments to Comment for the example)
        public string Comment { get; private set; }




        public string Name  // get set is actually a function minus the ()
        {
            get
            {
                // copied code from GetName()
                if (age >= 18)
                    return name;
                else return " Name unavailable.  This student is a minor.";
            }
            set
            {
                // newName needs to be keyword value instead of variable
                if (value != "")
                {
                    name = value;
                }
            }
        }



        // A "basic implementation" of get-set is:

        public double FinalGrade  // notice the private corresponding variable is finalGrade
        {
            get
            {
                return finalGrade;
            }

            set
            {
                finalGrade = value;
            }

        }


        // Because this approach is used lot - there is an auto-implemented property
        // see "comments" field above





        // These two (Get-Set) are now combined above ...
        /*
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
        */



        // =====  These are the constructors: (special type of method that instantiates objects)
        // =====  Constructors HAVE NO RETURN TYPE

        public StudentPropClass(string name, int age)
        {
            this.name = name;   // this.name = the name at the top of the page (class name)
                                // name = the parameter in this constructor 
            this.age = age;
        }


        // backwards use (fewer arguments means to set a default value to use)
        // this sets a default age value of zero rather than just having one argument
        public StudentPropClass(string name) : this(name, 0)
        {
        }



        public StudentPropClass(string name, string comment) :this(name)
        {
            this.Comments = Comments;
        }






        public void SayHello()
        {
            Console.WriteLine(" Hello from the other side ... it's {0}. ", name);
        }

    }
}


