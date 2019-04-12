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
        int oxygen;
        int star;
        int planet;
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
            oxygen = 0;
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
        //hydrogen # getter
        public int getHelium()
        {
            return helium;
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
        }
        public int getStar()
        {
            return star;
        }
        public void Resources()
        {
            Console.WriteLine(quarks + " quarks");
            Console.WriteLine(atoms + " atoms");
            Console.WriteLine(hydrogen + " hydrogen");
            Console.WriteLine(helium + " helium");
            Console.WriteLine(carbon + " carbon");
        }
        public void starResourceCounter()
        {
            while( star > 0)
            {
                helium++;
                carbon = carbon + 0.05;
                quarks = quarks + 0.5;
                System.Threading.Thread.Sleep(1000);
              /*  Console.WriteLine("--------------------");
                Console.WriteLine("carbon " + carbon);
                Console.WriteLine("helium " + helium);
                Console.WriteLine("quarks " + quarks); */
            }
        }
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
    }
}
