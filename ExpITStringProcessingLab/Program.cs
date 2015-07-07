using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITStringProcessingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();        
            //First, print out the words passed to the program in reverse order, word by word
            for (int i = args.Length - 1; i >= 0; i--)  //for loop to decrement through the array
            {
                Console.Write(args[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();        //Whitespace for readability
            Console.WriteLine();        //Whitespace for readability
            //Next, print out every word passed to the program in all UPPERCASE
            for (int i = 0; i < args.Length; i++ )  //for loop to increment through the array
            {
                Console.Write(args[i].ToUpper() + " ");
            }
            Console.WriteLine();

            Console.WriteLine();        //Whitespace for readability
            Console.WriteLine();        //Whitespace for readability
            //Lastly, concatenate the strings from the command line separated by commas as one string and print it

            //initialize a target string as an empty string
            string allTheArgs = "";

            for (int i = 0; i < args.Length; i++)  //for loop to increment through the array
            {
                allTheArgs = allTheArgs + args[i];
                if (i < args.Length - 1)
                {
                    allTheArgs = allTheArgs + ",";
                }
          
            }
            Console.WriteLine(allTheArgs);
            Console.WriteLine();
            Console.WriteLine(); 

            //hold the console window open until the user is ready to exit.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
