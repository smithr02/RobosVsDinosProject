using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Robots
    {
        public string name;  //declared variables 
        public int health;
        public int powerLevel;
        public int attackPower;
        public bool dead = false;  //variable where being dead is set to false, until true when health reaches zero or below.

        public Robots(string name, int health, int powerLevel, int attackPower)  //this is the constructor, where I'm setting the variables for the robots.
        {
            this.name = name;              //passing variables into the constructor, then telling the system to store these values.
            this.health = health;           
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;

        }

        public void Attack(Dinosaurs DinoToAttack) //attack method, calling in dinosaurs class
        {
            DinoToAttack.health -=attackPower;
            Console.WriteLine($"{name} is attacking {DinoToAttack.name} for {attackPower} damage");
            if (DinoToAttack.health <= 0)
            {
                DinoToAttack.dead = true;
                Console.WriteLine("This dino is dead!!");
            }
        }
    }
}
