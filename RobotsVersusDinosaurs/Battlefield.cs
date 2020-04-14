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
            while (!IsGameFinished())
            {
                AttackSequence();
            }
        }
    }
}
