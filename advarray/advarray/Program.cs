using System;
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
            //messing around with how to search lists
            Console.WriteLine("enter user");
            string Username = Console.ReadLine();
            string[] array1 = { "cat", "dog", "carrot", "bird" };
            string value1 = Array.Find(array1, element => element.StartsWith(Username, StringComparison.Ordinal));
            if (value1 == null)
            {
                Console.WriteLine("username availible");
                Console.WriteLine(Username);
            }
            else
            {
                Console.WriteLine("username unavailible");
            }
            
            Console.ReadKey();
        }
    }
}
