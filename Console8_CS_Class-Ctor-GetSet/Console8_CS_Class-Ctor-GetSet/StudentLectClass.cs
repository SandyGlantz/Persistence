using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console8_CS_Class_Ctor_GetSet
{



    // LectureOnClass (52) Notes
    // 
    



    class StudentLectClass
    {
        // declaring the instance variables (also called fields) of the "blueprint"/Class

        public string Name;
        public int Age;
        public double FinalGrade;

        public void SayHello()
        {
            Console.WriteLine(" Hello from the other side ... it's {0}. ", Name);
        }



    }
}
