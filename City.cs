using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
        public string name { get; set; }
        public string mayor { get; set; }
        public string dateEstablished { get; set; }
        public List<Building> Buildings { get; set; }

        public City()
        {
            Buildings = new List<Building>();
        }

        public void AddBuilding(Building aBuilding)
        {
            Buildings.Add(aBuilding);
        }
    }

}