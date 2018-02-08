using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6_CS_OptParems_NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture 47

            // Optional Parameters

            // this doesn't work on a standard method
            // Add(5);
            // [  public static void Add(int x, int y)   ]
            // because two arguments are required ...

            // but it works when a default value supplied:
            // [  public static void Add(int x, int y = 5)   ]
            Add_OptionalParameter(5);

            // over the value can be overriden:
            Add_OptionalParameter(5, 10);



            // Named Arguments
            // if you want the second 5 to be assigned to z:
            Add_NamedArgument(5, z : 5);
            // or out of order OK:
            Add_NamedArgument(5, z: 5, y: 15);



        }   // end Main()





        // Optional Parameters 
        public static void Add_OptionalParameter(int x, int y = 5)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
   



        // Named arguments 
        public static void Add_NamedArgument(int x, int y = 5, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }




    }   // end class Program
}       // end namespace
