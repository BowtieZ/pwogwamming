using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class Cat
    {
        //properties
        String species;
        String name;

        //constructor
        public Cat(String Name)
        {
            species = "Cat";
            name = Name;
        }

        //methods
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void BeHappy()
        {
            Console.WriteLine("purrrrrrrrrr");
            SeeLazer();
            MakeSound();
        }

        public void LayOnLap()
        {
            Console.WriteLine("*cuddles on owners lap :3*");
        }

        public void SeeLazer()
        {
            Console.WriteLine("*kitty pounces!*");
        }
    }
}
