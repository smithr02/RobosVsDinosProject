﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Dinosaurs
    {
        public string name; //declared variables
        public int health;
        public int energy;
        public int attackPower;
        public bool dead = false; //variable where false until proven true when health reaches zero or below.

        public Dinosaurs(string name, int health, int energy, int attackPower) //constructor where I'm passing in parameters.
        {
            this.name = name;       //assigning space for set variables in constructor as there own object. 
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void Attack(Robots RobotToAttack) //Dino attack method, where we take a selected robot and subtract its health from a selected dino's attack power.
        {
            RobotToAttack.health -= attackPower;
            Console.WriteLine($"{name} is attacking {RobotToAttack.name} for {attackPower} damage");

            if (RobotToAttack.health <= 0)
            {
                RobotToAttack.dead = true;
                Console.WriteLine("This robot is destroyed!!");
            }
        }

    }
}
