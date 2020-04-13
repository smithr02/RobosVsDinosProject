using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Fleet
    {
        public List<Robots> myRobots;

        public Fleet()
        {
            myRobots = new List<Robots>();
            myRobots.Add(new Robots("GiantMech", 500, 200, 100));
            myRobots.Add(new Robots("MediumMech", 300, 300, 50));
            myRobots.Add(new Robots("SmallMech", 200, 400, 25));
        }
    }
}
