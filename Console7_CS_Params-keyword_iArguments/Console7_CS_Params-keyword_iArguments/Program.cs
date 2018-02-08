using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console7_CS_Params_keyword_iArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20, 25);
            int[] anyVariableName = { 12, 14, 16, 19 };
            Sum(anyVariableName);
            // results:
                // The sum is 5
                // The sum is 30
                // The sum is 75
                // The sum is 61


            Words("hello");
            Words(" world");
            Words("!  ", "will", " this", "work?");
            // results:
                // Here are the words: hello
                // Here are the words: world
                // Here are the words: !will thiswork ?

        }


        // params keyword means parameter array
        // using params means it can take any number of arguments
        // all the parameters are put into an array
        // 
        public static void Sum(params int[] randomVariableName4methodOnly)
        {
            int sum = 0;
            for (int i = 0;     i < randomVariableName4methodOnly.Length;     i++)
            {
                sum += randomVariableName4methodOnly[i];
            }
            Console.WriteLine(" The sum is {0}", sum);
        }




        public static void Words(params string[] variableWordsMethod)
        {
            string sumWords = "";
            for (int i = 0; i < variableWordsMethod.Length; i++)
            {
                sumWords += variableWordsMethod[i];
            }
            Console.WriteLine(" Here are the words: {0}", sumWords);
        }


    }
}
