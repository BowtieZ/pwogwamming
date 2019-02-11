using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class OrangeTabby
    {
        //properties
        String species;
        String name;

        //constructor
        public OrangeTabby(String Name)
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
            LayOnLap();
            Console.WriteLine("*takes a nap*");
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
