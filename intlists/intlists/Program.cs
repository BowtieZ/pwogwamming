using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intlists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare

            List<int> intergerList = new List<int>();
            List<int> listOfInts = new List<int>();
            List<int> testScores = new List<int>();

            List<double> dbLIst = new List<double>();
            List<double> listOfDoubles = new List<double>();
            List<double> playerPoints = new List<double>();

            List<string> stringList = new List<string>();
            List<string> listOfStrings = new List<string>();
            List<string> studentName = new List<string>();

            List<int> intList = new List<int>();
            List<double> dblList = new List<double>();
            List<string> strList = new List<string>();

            //change intList
            intList.Add(12);
            intList.Add(5);
            intList.Add(7);
            intList.Add(3);

            int IntElement = intList[0];
            Console.WriteLine(IntElement);
            Console.WriteLine(IntElement = intList[1]);
            Console.WriteLine(IntElement = intList[2]);
            Console.WriteLine(IntElement = intList[3]);

            intList[0] = 13;
            intList[3] = 8;

            Console.WriteLine(IntElement = intList[0]);
            Console.WriteLine(IntElement = intList[1]);
            Console.WriteLine(IntElement = intList[2]);
            Console.WriteLine(IntElement = intList[3]);
        }
    }
}
