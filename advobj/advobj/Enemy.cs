using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advobj
{
    public class Enemy
    {
        private int health;
        private int defense;
        private int attack;
        private int enemeyLevel;
        Random rand;

        //constructor that will initialize the instance variables (properties).
        //the "this" key word refers to the object's variable instead of the function's input.
        //in the case that they have the same name.
        public Enemy(int enemeyLevel)
        {
            rand = new Random();
            this.enemeyLevel = enemeyLevel;
            health = 20 * this.enemeyLevel;
            defense = (rand.Next(10) + 1) * this.enemeyLevel;
            attack = (rand.Next(10) + 1) * this.enemeyLevel;
        }

        //getters (allow the programmers to see the values of the instance variables
        public int getHealth()
        {
            return health;
        }

        public int getDefense()
        {
            return defense;
        }

        public int getAttack()
        {
            return attack;
        }

        public int getEnemeyLevel()
        {
            return enemeyLevel;
        }

        //this is the function that allows the enemy to take damage, returns true if enemy is Alive
        //gives player XP if enemy died.
        public bool takeDamage(Player player)
        {
            int damage = (rand.Next(player.getAttack()) + player.getAttack()) - defense;
            if (damage < 1)
            {
                damage = 1;
            }
            health = health - damage;
            Console.WriteLine("you attacked the enemy and they took: " + damage + " damage!");
            if (!isAlive())
            {
                Console.WriteLine("you killed the enemy!");
                player.gainXP();
                return false;
            }
            return true;
        }

        //returns true if the enemy health>0
        private bool isAlive()
        {
            return (health > 0);
        }
    }
}
