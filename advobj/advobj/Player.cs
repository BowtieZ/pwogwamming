﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advobj
{
    public class Player
    {

        private int health;
        private int defense;
        private int attack;
        private int playerLevel;
        private int healthPotions;

        public int getXp()
        {
            return xp;
        }

        private int xp;

        Random rand;

        //constructor that will initialize the instance variables (properties)
        //the "this" key word refers to the object's variable instead of the function's input
        //in the case that they have the same name.
        public Player()
        {
            rand = new Random();
            this.playerLevel = 1;
            health = 50;
            defense = 10;
            attack = 10;
            healthPotions = 0;
        }

        //getters (allow the programmers to see the values of the instance variables
        public int getHealth()
        {
            return health;
        }

        private int getDefense()
        {
            return defense;
        }

        public int getAttack()
        {
            return attack;
        }

        public int getPlayerLevel()
        {
            return playerLevel;
        }

        //used to get input from the user will allow them to see stats use heal or attack
        public void menu(Enemy enemy)
        {
            //Scanner console = new Scanner(System.in);
            while (true)
            {
                Console.WriteLine("What would you like to do? heal or attack or stats");

                String answer = Console.ReadLine();
                if (answer.ToLower().Equals("heal"))
                {
                    heal();
                }
                else if (answer.ToLower().Equals("attack"))
                {
                    return;  //exits out and attacks
                }
                else if (answer.ToLower().Equals("stats"))
                {
                    Console.WriteLine("your stats:");
                    Console.WriteLine("level:   " + getPlayerLevel());
                    Console.WriteLine("health:  " + getHealth());
                    Console.WriteLine("attack:  " + getAttack());
                    Console.WriteLine("defense: " + getDefense());
                    Console.WriteLine("potions: " + healthPotions);
                    Console.WriteLine("enemy stats:");
                    Console.WriteLine("health:  " + enemy.getHealth());
                    Console.WriteLine("attack:  " + enemy.getAttack());
                    Console.WriteLine("defense: " + enemy.getDefense());
                }
            }
        }

        //this is the function that allows the player to take damage
        //returns true if player is alive
        public bool takeDamage(Enemy enemy)
        {
            int damage = (rand.Next(enemy.getAttack()) + enemy.getAttack()) - defense;
            if (damage < 1)
            {
                damage = 1;
            }
            health = health - damage;
            Console.WriteLine("the enemy attacked you and you took: " + damage + " damage!");
            if (isAlive())
            {
                return true;
            }
            Console.WriteLine("you died.");
            return false;
        }

        //returns true if the player health>0
        private bool isAlive()
        {
            return (health > 0);
        }

        //call to use a health potion
        private void heal()
        {
            if (healthPotions > 0)
            {
                healthPotions--;
                health = health + 50;
                Console.WriteLine("you drank one potion and restored 50 health, you now have " + health + " health");
            }
            else
            {
                Console.WriteLine("you have no health potions");
            }
        }

        //call when player kills an enemy (should not need to be called in main
        public void gainXP()
        {
            xp++;
            //if they leveled up
            if (xp > (int)(5 * Math.Pow(1.3, playerLevel)))
            {
                playerLevel++;
                Console.WriteLine("you are now level: " + playerLevel);    
                healthPotions = healthPotions + 5;
                attack = attack + rand.Next(7) + 1;
                defense = defense + rand.Next(7) + 1;
            }
        }
    }
}
