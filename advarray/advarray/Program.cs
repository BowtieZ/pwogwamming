﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //messing around with how to search lists
            Console.WriteLine("enter user");
            bool Avalibility;
            string Username = Console.ReadLine();
            //small array for testing, this is what the program needs to search through
            string[] array1 = { "cat", "dog", "carrot", "bird" };
            /*not exactly sure what this line does....but it searches the previously established array for the parameter given (in this case, whatever is in the string value Username):
            string value1 = Array.Find(array1, element => element.StartsWith(Username, StringComparison.Ordinal));

            0000000000000000000//this may take more lines to write, but i understand how it works. 00000000000000000000000000000
            for (int i =0; i < array1.Length; i++)
            {
                if (array1[i].Equals(Username)) {
                Avalibility = true;
                    Console.WriteLine("username unavailible");
                    break;
                }
                else
                {
                    Console.WriteLine("username availible");
                }
            }
            0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            //if the value of the array search comes back empty, the username is avalible, but if it matches, it's unavalible
            /*if (value1 == null)
            {
                Console.WriteLine("username availible");
                Console.WriteLine(Username);
            }
            else
            {
                Console.WriteLine("username unavailible");
            }
            
            Console.ReadKey();
            */
            string[] Username = new string[50];
            string[] Password = new string[50];

            Console.WriteLine("Would you like to create an account or login?");
            string Response = Console.ReadLine();
            if( Response == "create account" || Response == "create" || Response == "Create Account" || Response == "Create account" )
            {

            }
        }
    }
}
