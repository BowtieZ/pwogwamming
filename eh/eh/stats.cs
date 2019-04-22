using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eh
{
    class stats
    {
        //properties
        double quarks;
        int atoms;
        int hydrogen;
        int helium;
        double carbon;
        int silicon;
        int iron;
        int oxygen;
        int sisterStar;
        int star;
        int planet;
        int dwarfPlanet;
        int redGiant;
        int supernova;
        int nebula;
        int moon;
        //constructor
        public stats()
        {
            quarks = 10;
            atoms = 0;
            hydrogen = 0;
            helium = 0;
            carbon = 0;
            iron = 0;
            oxygen = 0;
            silicon = 0;
            star = 0;
            planet = 0;
            redGiant = 0;
            supernova = 0;
            nebula = 0;
            moon = 0;
        }
        //methoods
        //for creating quarks
        public void Quarks()
        {
            Console.WriteLine("and suddenly......quarks!");
            quarks = quarks + 3;
        }
        //quark # getter
        public double getQuarks()
        {
            return quarks;
        }
        //for creating atoms
        public void Atoms()
        {
            if(quarks >= 3)
            {
                Console.WriteLine("woah hey look at the quarks, they're fusing!");
                quarks = quarks - 3;
                atoms = atoms + 1;
                Console.WriteLine("now you have atoms!");
            }
            else
            {
                Console.WriteLine("oh you dont have enough quarks! atoms are made of these, you know.");
            }
        }
        //atom # getter
        public int getAtoms()
        {
            return atoms;
        }
        //make hydrogen
        public void Hydrogen()
        {
            if (atoms >= 2)
            {
                Console.WriteLine("some of the atoms are doing a little dance!");
                atoms = atoms - 2;
                hydrogen = hydrogen + 1;
            }
            else
            {
                Console.WriteLine("hey, you need more atoms for that!");
            }
        }
        //hydrogen # getter
        public int getHydrogen()
        {
            return hydrogen;
       }
        //make helium
        public void Helium()
        {
            if (atoms >= 2)
            {
                Console.WriteLine("some of the atoms are doing a little dance!");
                atoms = atoms - 2;
                helium = helium + 1;
            }
            else
            {
                Console.WriteLine("hey, you need more atoms for that!");
            }
        }
        //helium # getter
        public int getHelium()
        {
            return helium;
        }
        //iron, 10 atoms = 1 
        public void Iron()
        {
            Console.WriteLine("the atoms are heading up! wow, that's really shiny.");
            atoms = atoms - 10;
            iron++;
        }
        //iron getter
        public int getIron()
        {
            return iron;
        }
        //silicon, 8 atoms
        public void Silicon()
        {
            Console.WriteLine("what an interesting substance!");
            atoms = atoms - 8;
            silicon++;
        }
        //make stars, for every star created there should be +.5 quarks ,+1 helium , +.05 carbon every second
        public void Star()
        {
            if(helium >= 10 && hydrogen >= 10)
            {
                Console.WriteLine("helium and hydrogen are dancing! jeez...it's so bright..");
                helium = helium - 10;
                hydrogen = hydrogen - 10;
                star = star + 1;

            }
            else
            {
                Console.WriteLine("this is a pretty big job, but you dont have enough resources! you need atleast 10 helium and 10 hydrogen");
            }
        }
        public int getStar()
        {
            return star;
        }
        //one planet shoud take 20 iron and 15 silicon, dwarf planets can be made if there is *EXACTLY* 2 iron and 3 silicon. each planet should produce +5 oxygen every 30 seconds. after one hour, +1 moon. 
        public void Planet()
        {
            if (iron >= 20 && silicon >= 15)
            {
                Console.WriteLine("woah, those elements are getting rock solid!");
                iron = iron - 20;
                silicon = silicon - 15;
                planet = planet++;
            }
            else if (iron == 2 && silicon == 3)
            {
                Console.WriteLine("this is gonna be our little secret....");
                iron = iron - 2;
                silicon = silicon - 3;
                dwarfPlanet = dwarfPlanet + 1;
            }
            else
            {
                Console.WriteLine("you need a good amount of elements to do that, you know. 15 silicon and 20 iron to be specific.");
            }

        }
        //planet getter
        public int getPlanet()
        {
            return planet;
        }
        //dwarf planet getter
        public int getDwarfPlanet()
        {
            return dwarfPlanet;
        }
        public void Resources()
        {
            Console.WriteLine(quarks + " quarks");
            Console.WriteLine(atoms + " atoms");
            Console.WriteLine(hydrogen + " hydrogen");
            Console.WriteLine(helium + " helium");
            Console.WriteLine(carbon + " carbon");
            Console.WriteLine(star + " stars");
            Console.WriteLine(silicon + " silicon");
            Console.WriteLine(iron + " iron");
            Console.WriteLine(oxygen + " oxygen");
            Console.WriteLine(planet + " planet");
        }
        //counter for moons produced by planets
        public void planetMoon()
        {
            while ( planet > 0)
            {
                System.Threading.Thread.Sleep(3600000);
                moon = moon + 1;
            }
        }
        //counter for oxygen produced by planets
        public void planetOxy()
        {
            while ( planet > 0)
            {
                System.Threading.Thread.Sleep(30000);
                oxygen = oxygen + 5;
            }
        }
        public void starResourceCounter()
        {
            while( star > 0)
            {
                helium++;
                atoms = atoms + 10;
                carbon = carbon + 0.05;
                quarks = quarks + 0.5;
                System.Threading.Thread.Sleep(1000);
              /*  Console.WriteLine("--------------------");
                Console.WriteLine("carbon " + carbon);
                Console.WriteLine("helium " + helium);
                Console.WriteLine("quarks " + quarks); */
            }
        }
        //follwing methoods are for testing purposes only, not to remain in Main
        public void Testing()
        {
            star = star + 50;
        }
    }
}
 //dont even fuck with this anymore, multithreading works and is much easier
        //suppose to be a delegate + event for adding materials according to how many stars are owned
        /*public int starAddedResources(int a)
        {
            for( star = 1; star > 0; helium++)
            {
                System.Threading.Thread.Sleep(1000);
                quarks = quarks + 0.5;
                timerDelg starTimer = starAddedResources;
            }
            return star;
        } */