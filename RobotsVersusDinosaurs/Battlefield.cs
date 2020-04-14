using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Battlefield
    {
        public Herd dinoFighters;
        public Fleet roboFighters;

        public Battlefield()
        {
            dinoFighters = new Herd();
            roboFighters = new Fleet();
        }

        public void RunGame()
        {
            while (!IsGameOver())
            {
                AttackSequence();
            }
        }

        public bool IsGameOver()
        {
            bool returnValue = false;

            if ((dinoFighters.myDinosaurs[0].health <= 0 && dinoFighters.myDinosaurs[1].health <= 0 && dinoFighters.myDinosaurs[2].health <=0 || (roboFighters.myRobots[0].health <=0 && roboFighters.myRobots[1].health <=0 && roboFighters.myRobots[2].health <=0)))
            {
                returnValue = true;
            }
            return returnValue;
        }

        public void AttackSequence()
        {
            for (int i = 0; i < 3; i++)
            {
                if (roboFighters.myRobots[i].dead == true)
                {
                    continue;
                }

                Console.WriteLine($"It's now {roboFighters.myRobots[i].name} turn to attack!");
                Console.WriteLine("Who do you chose to attack? Pick 1 for (LargeDino), Pick 2 for (MediumDino), Pick 3 for (SmallDino)");
                int userInput = int.Parse(Console.ReadLine());

                if (dinoFighters.myDinosaurs[userInput-1].dead == true)
                {
                    Console.WriteLine("That choice is invalid, please choose again!!");
                    i--;
                }
                else
                {
                    roboFighters.myRobots[i].Attack(dinoFighters.myDinosaurs[userInput - 1]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (dinoFighters.myDinosaurs[i].dead == true)
                {
                    continue;
                }

                Console.WriteLine($"It is {dinoFighters.myDinosaurs[i].name} turn to attack!" );
                Console.WriteLine("Who do you choose to attack? Pick 1 for (GiantMech) Pick 2 for (MediumMech) Pick 3 for (SmallMech)");
                int userInput = int.Parse(Console.ReadLine());

                if (roboFighters.myRobots[userInput -1].dead == true)
                {
                    Console.WriteLine("That choice is invalid, please choose again!");
                    i--;
                }
                else
                {
                    dinoFighters.myDinosaurs[i].Attack(roboFighters.myRobots[userInput - 1]);
                }

            }
        }
    }
}
