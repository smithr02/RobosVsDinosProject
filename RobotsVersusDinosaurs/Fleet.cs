using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Fleet
    {
        public Robots HugeMech; 
        public Robots MediumMech;
        public Robots SmallMech;

        public List<Robots> Robots = new List<Robots>(); //creating a new list and storing it. 

        public Fleet()
        {
            HugeMech = new Robots("HugeMech", 500, 200, 100);  //setting the variables that are in robot class with specific name and values.
            MediumMech = new Robots("MediumMech", 300, 300, 50);
            SmallMech = new Robots("SmallMech", 200, 400, 25);

            Robots.Add(HugeMech);    //adding each individual robot object to the list, i.e. adding HugeMech etc.
            Robots.Add(MediumMech);
            Robots.Add(SmallMech);
        }
    }
}
