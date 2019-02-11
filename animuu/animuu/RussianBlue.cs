using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class RussianBlue
    {
        //properties
        String species;
        String name;

        //constructor
        public RussianBlue(String Name)
        {
            species = "Cat";
            name = Name;
        }

        //methods
        public void MakeSound()
        {
            Console.WriteLine("Hisssssssssssss");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrrrrrrrr");
            SeeLazer();

        }

        public void SeeLazer()
        {
            Console.WriteLine("*kitty pounces!*");
        }
    }
}
