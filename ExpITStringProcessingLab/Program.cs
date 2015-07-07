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
            //First, create a string of the words passed to the program in reverse order, word by word

            //initialize the string
            string allTheArgsReversed = "";
            for (int i = args.Length - 1; i >= 0; i--)  //for loop to decrement through the array
            {
                allTheArgsReversed = allTheArgsReversed + (args[i] + " ");
            }
            Console.WriteLine(allTheArgsReversed);

            Console.WriteLine();        //Whitespace for readability
            Console.WriteLine();        //Whitespace for readability


            //Next, print out every word passed to the program in all UPPERCASE

            //initialize the string
            string allTheArgsUpper = "";
            for (int i = 0; i < args.Length; i++ )  //for loop to increment through the array
            {
                allTheArgsUpper = allTheArgsUpper + args[i].ToUpper() + " ";
            }
            Console.WriteLine(allTheArgsUpper);

            Console.WriteLine();        //Whitespace for readability
            Console.WriteLine();        //Whitespace for readability
            //Lastly, concatenate the strings from the command line separated by commas as one string and print it

            //initialize a target string as an empty string
            string allTheArgsWithCommas = "";

            for (int i = 0; i < args.Length; i++)  //for loop to increment through the array
            {
                allTheArgsWithCommas = allTheArgsWithCommas + args[i];
                if (i < args.Length - 1)    //only need a comma if this is not the last word
                {
                    allTheArgsWithCommas = allTheArgsWithCommas + ",";
                }
          
            }
            Console.WriteLine(allTheArgsWithCommas);
            Console.WriteLine();
            Console.WriteLine(); 

            //hold the console window open until the user is ready to exit.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
