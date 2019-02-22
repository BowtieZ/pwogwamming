using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //decleration
            int[] intArray1 = new int[50];
            int[] arrayOfNumbers = new int[3];
            int[] numbersArray = new int[5];

            double[] dblArray = new double[4];
            double[] arrayOfDoubles = new double[15];
            double[] playerPoints = new double[39];

            string[] stringArray1 = new string[20];
            string[] arrayOfStrings = new string[25];
            string[] wordArray = new string[6];

            //setting values
            numbersArray[0] = 12;
            numbersArray[1] = 13;
            numbersArray[2] = 14;
            numbersArray[3] = 15;
            numbersArray[4] = 16;

            arrayOfNumbers[0] = 47;
            arrayOfNumbers[1] = 46;
            arrayOfNumbers[2] = 39;

            dblArray[0] = 12.43;
            dblArray[1] = 5.12;
            dblArray[2] = 43.21;
            dblArray[3] = 1.34;

            wordArray[0] = "what";
            wordArray[1] = "is";
            wordArray[2] = "forrest";
            wordArray[3] = "gumps";
            wordArray[4] = "password";
            wordArray[5] = "1forrest1";

            //reading values

            Console.WriteLine(numbersArray[0]);
            Console.ReadKey();
        }
    }
}
