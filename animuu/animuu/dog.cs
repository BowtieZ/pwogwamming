using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class dog
    {
        //properties
        String species;
        String name;
        bool dockedTail;

        //constructor
        public dog(String Name, bool DockedTail)
        {
            species = "Dog";
            Name = name;
            DockedTail = dockedTail;
        }

        //methoods
        public void MakeSound()
        {
            Console.WriteLine("woof");
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }

        public void PlayFetch()
        {
            Console.WriteLine("*chases ball 5 times then quits :D*");
        }

        public bool getDockedTail()
        {
            return dockedTail;
        }
    }
}
