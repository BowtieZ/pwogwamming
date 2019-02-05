using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begclass
{
    class Animooooooooooooooooooooooooooooooo
    {
        String species;
        String name;
        String color;
        int age;

        public Animooooooooooooooooooooooooooooooo(String Color, String Name, String Species)
        {
            species = Species;
            name = Name;
            color = Color;
            age = 0;
        }

        public void MakeSound()
        {
            Console.WriteLine("Grrrrrr...");
        }

        public void SetAge( int newAge)
        {
            age = newAge;
        }

        public void PrintDescription()
        {
            Console.WriteLine(name + " is a " + age + "year old, " + color + " " + species);
        }
    }
}
