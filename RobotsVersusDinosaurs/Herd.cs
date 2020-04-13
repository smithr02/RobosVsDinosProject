using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVersusDinosaurs
{
    class Herd
    {
        public Dinosaurs LargeDino;
        public Dinosaurs MediumDino;
        public Dinosaurs SmallDino;

        public List<Dinosaurs> Dinosaurs = new List<Dinosaurs>(); //created new list and stored it as Dinosaurs.

        public Herd()
        {
            LargeDino = new Dinosaurs("LargeDino", 500, 200, 100); //adding name and stats to the parameters in Dinosaurs constructor.
            MediumDino = new Dinosaurs("MediumDino", 300, 300, 50);
            SmallDino = new Dinosaurs("SmallDino", 200, 400, 25);

            Dinosaurs.Add(LargeDino); //adding the dinos to the list.
            Dinosaurs.Add(MediumDino);
            Dinosaurs.Add(SmallDino);
        }
    }
}
