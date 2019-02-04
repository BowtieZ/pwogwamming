using System;
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
                Enemy badboi = new Enemy(p1.getPlayerLevel()); //generate enemy with level on par to player
                if (badboi.getHealth() > 0) //while enemy health is higher than zero
                {
                    p1.menu(badboi);
                    badboi.takeDamage(p1);
                }

                

            }
        }

    }

   
}
