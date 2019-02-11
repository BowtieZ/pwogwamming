using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class Garfeild
    {
        //properties
        String species;
        String name;

        //constructor
        public Garfeild(String Name)
        {
            species = "Cat";
            Name = name;
        }

        //methods
        public void MakeSound()
        {
            Console.WriteLine("mmmmmm lasagna ~v~");
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
            BeHappy();
        }
    }
}
