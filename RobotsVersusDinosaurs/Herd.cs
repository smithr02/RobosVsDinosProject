using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Herd
    {
        
        public List<Dinosaurs> myDinosaurs; //created new list and stored it as Dinosaurs.

        public Herd()
        {
            myDinosaurs = new List<Dinosaurs>();
            myDinosaurs.Add(new Dinosaurs("LargeDino", 500, 200, 100));
            myDinosaurs.Add(new Dinosaurs("MediumDino", 300, 300, 50));
            myDinosaurs.Add(new Dinosaurs("SmallDino",200, 400, 25));
        }
    }
}
