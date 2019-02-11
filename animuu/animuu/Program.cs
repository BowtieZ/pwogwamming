using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Aminal Anmol = new Aminal(Name: "bab", Species: "giraffee");
            Anmol.MakeSound();
            Anmol.PrintName();
            Console.ReadKey();

            Cat Babey = new Cat(Name: "Goblin");
            Babey.PrintName();
            Babey.BeHappy();
            Console.ReadKey();

            dog No = new dog(Name: "loud", DockedTail: true);
            No.PrintName();
            No.PlayFetch();
            Console.ReadKey();

            Garfeild Fatboiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii = new Garfeild(Name: "FatMan");
            Fatboiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii.PrintName();
            Fatboiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii.LayOnLap();
            Fatboiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii.SeeLazer();
            Console.ReadKey();

            OrangeTabby tab = new OrangeTabby(Name: "BOY");
            tab.PrintName();
            tab.SeeLazer();
            Console.ReadKey();

            RussianBlue BOOOOOOOOOOOO = new RussianBlue(Name: "blyat");
            BOOOOOOOOOOOO.PrintName();
            BOOOOOOOOOOOO.MakeSound();
            Console.ReadKey();

        }
    }
}
