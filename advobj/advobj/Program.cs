﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advobj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*write your code here
            most of this assignment is trying to read the existing code to understand how it works,
            ask a classmate or instructor if you are unsure how the code works.


            generate a new player
            create main game loop that continues until the player has no health
            generate a new enemy( the level of the enemy should be the player's level)
            create battle loop that should continue while both the player and enemy are alive
            gets player's input on what to do (use one of the methods to do this)
            has the enemy take damage
            has the player take damage
            once the player is dead print out the player's level and how much xp they had.*/

            Player p1 = new Player();
            /*Enemy badboi = new Enemy(1);*/
            /*int health = p1.getHealth();*/
            while (p1.getHealth() > 0) //im not sure if this should be a while loop or not,
            {
                Enemy badboi = new Enemy(7); //generate enemy with level on par to player
                while (badboi.getHealth() > 0 && p1.getHealth() > 0) //while enemy health is higher than zero
                {
                    p1.menu(badboi);

                     badboi.takeDamage(p1); //this line isnt executed edit: fixed, "if" fucked it up
                    if (badboi.getHealth() > 0)
                    {
                        p1.takeDamage(badboi);
                    }
                    //somehow make an "if" for not attacking the player if the enemy is dead lmao.
                    //Console.ReadKey();
                    



                 }
            }
            Console.WriteLine("a wonderous adventure you had! you were level " + p1.getPlayerLevel());
            Console.Write(" and you also had " + p1.getXp() + " experience points!");
            Console.ReadKey();
        }

    }
}
