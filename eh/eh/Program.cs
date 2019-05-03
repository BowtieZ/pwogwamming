using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using System.Threading.Tasks;

namespace eh
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game = new Form();
            Game = yourGame();
            Application.Run(Game);
        }
          static Form yourGame()
        {

            bool open = true;
            stats NewGame = new stats();
            Console.WriteLine("Hi and welcome to the Andromeda Idle! here are your current earnings and belongings.");
            NewGame.Resources();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("everytime you open the game, you start over. type commands to get quarks and eventually create your universe.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("--------------------");
            Console.WriteLine("your currently availible commands are as follows:");
            Console.WriteLine("the 'show resources' command will show your currently availible resources.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("--------------------");
            Console.WriteLine("the 'get quarks' command will get you quarks! quarks are absolutely free and are the building blocks of the universe, collect many to make atoms!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("--------------------");
            Console.WriteLine("the 'make atoms' command will create atoms out of quarks! it takes 3 quarks to make an atom, and atoms are used to make elements!");
            Console.WriteLine("please enter a command.");
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
                        Console.WriteLine("you've earned new commands! It takes two atoms to make either Helium or Hydrogen using the 'create helium' or 'create hydrogen' commands.");
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
                    //cap stars at 800
                    case "create star":
                        while (NewGame.getStar() < 801)
                        {
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
                        }
                        Console.WriteLine("is light pollution a thing in space? no? you're trying to make it a thing, calm down.");
                        break;
                    //cap planets at like 800
                    case "create planet":
                        while (NewGame.getPlanet() < 801)
                        {
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
                                Console.WriteLine("you now have" + NewGame.getDwarfPlanet() + " dwarf planets! take good care of them, and remember, keep our secret.");
                            }
                        }
                        Console.WriteLine("you have too many! calm down.");
                        break;
                    case "create sister stars":
                        break;
                    case "create moon":
                        break;
                    //delete this or make it dead later, only meant for testing purposes
                    case "test 50 stars":
                        //the program seems to crash at about 1300-1500 stars? hm...try to cap it at like 1000 stars. 
                        NewGame.Testing(); //i did this wrong lmao//fixed it
                        int i = 0;
                        while (i < 51)
                        {
                            var tst = new ThreadStart(NewGame.planetOxy);
                            var backgroundThreadt = new Thread(tst);
                            backgroundThreadt.Start();
                            i++;
                        }
                        break;  //comment this back in when you need to test something
                }
                Console.WriteLine("what would you like to do now?");

            }
            return yourGame();
        }
     }
    }
    
