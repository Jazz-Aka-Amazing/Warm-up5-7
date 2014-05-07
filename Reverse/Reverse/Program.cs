using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {   
        string output = "";
        public static string Reverse( string input)
        {
            
            char[] seq = input.ToCharArray();
            Array.Reverse(seq);
            string final = new string(seq);
            input = final;
            return input;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string:");

            string input = Console.ReadLine();
            string output = Reverse(input);

            Console.WriteLine(output);
           


            
           
        }
    }
}
