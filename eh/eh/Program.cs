using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool open = true;
            stats NewGame = new stats();
            Console.WriteLine("Hi and welcome to the Andromeda Idle! here are your current earnings and belongings." );
            Console.WriteLine("everytime you open the game, you start over. type commands to get quarks and eventually create your universe.");
            while (open == true)
            {
                string action = Console.ReadLine();
                switch (action)
                {
                    case "show resources":
                        NewGame.Resources();
                        break;
                    case "get quarks":
                        NewGame.Quarks();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("you now have " + NewGame.getQuarks() + " quarks!");
                        break;
                    case "make atoms":
                        NewGame.Atoms();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("you now have " + NewGame.getAtoms() + " atoms!");
                        break;
                    case "create hydrogen":
                        NewGame.Hydrogen();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("you now have" + NewGame.getHydrogen() + " hydrogen");
                        break;
                    case "create helium":
                        NewGame.Helium();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("you now have " + NewGame.getHelium() + " helium");
                        break;
                    case "create star":
                        NewGame.Star();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("you now have " + NewGame.getStar() + " stars!");
                        Console.WriteLine("Now that you have stars, the aquisition of materials should be atleast a little easier. good luck!");
                        //somehow figure out how to use delegates.
                        //NewGame.starResourceCounter();
                        //edit: actually lets try multithreading it
                        var ts = new ThreadStart(NewGame.starResourceCounter);
                        var backgroundThread = new Thread(ts);
                        backgroundThread.Start();
                        //threading it actually works!!! stop making it print though, that's confusing. 
                        break;
                    case "create planet":
                        break;
                    case "create sister stars":
                        break;
                    case "create moon":
                        break;
                }
                Console.WriteLine("what would you like to do now?");
                
            }
        }
    }
}
