﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC8_One_Special_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexSample regexSample = new RegexSample();
            regexSample.Validating();
        }
    }
}
