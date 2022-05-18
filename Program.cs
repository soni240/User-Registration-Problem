// See https://aka.ms/new-console-template for more information
using System;
namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {



            Pattern patterns = new Pattern();
            //Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
            if (patterns.validateString("1aaa"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}


