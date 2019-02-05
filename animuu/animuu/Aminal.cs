using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class Aminal
    {
        String species;
        String name;

        public Aminal (String Name, String Species)
        {
            name = Name;
            species = Species;
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrrr.....");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
