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
            NewGame.Resources();
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
                        //somehow figure out how to use delegates. edit: do not. 
                        //NewGame.starResourceCounter();
                        //edit: actually lets try multithreading it
                        var st = new ThreadStart(NewGame.starResourceCounter);
                        var starThread = new Thread(st);
                        starThread.Start();
                        //threading it actually works!!! stop making it print though, that's confusing. edit: it doesnt print AND it can duplicate now, this is fantastic
                        break;
                    case "create planet":
                        NewGame.Planet();
                        Console.WriteLine("--------------------");
                        if (NewGame.getDwarfPlanet() == 0)
                        {
                            Console.WriteLine("you now have " + NewGame.getPlanet() + " planets!");
                            Console.WriteLine("you'll get oxygen from the planets, though i wonder why rocks keep calling off...");
                            //running a thread for oxygen
                            var pot = new ThreadStart(NewGame.planetOxy);
                            var planetoxyThread = new Thread(pot);
                            planetoxyThread.Start();
                            //running a thread for moons
                            var pmt = new ThreadStart(NewGame.planetMoon);
                            var planetMoonThread = new Thread(pmt);
                            planetMoonThread.Start();
                        }
                        else if (NewGame.getDwarfPlanet() > 0)
                        {
                            Console.WriteLine("you now have" + NewGame.getDwarfPlanet() + " dwarf planets! take good care of them.");
                        }
                       
                        break;
                    case "create sister stars":
                        break;
                    case "create moon":
                        break;
                        //delete this or make it dead later, only meant for testing purposes
                    /*case "test 50 stars":
                        //the program seems to crash at about 1300-1500 stars? hm...try to cap it at like 1000 stars. 
                        NewGame.Testing(); //i did this wrong lmao//fixed it
                        int i = 0;
                        while ( i < 51)
                        {
                            var tst = new ThreadStart(NewGame.starResourceCounter);
                            var backgroundThreadt = new Thread(tst);
                            backgroundThreadt.Start();
                            i++;
                        }
                        break; */ //comment this back in when you need to test something
                }
                Console.WriteLine("what would you like to do now?");
                
            }
        }
    }
}
