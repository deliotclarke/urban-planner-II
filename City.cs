using System;
using System.Collections.Generic;

namespace Planner2
{
    public class City
    {
        public string CityName { get; set; }

        public string Mayor { get; set; }

        public DateTime DateEstablished { get; set; }

        public List<Building> AllBuildings = new List<Building>();

        public void IncorporateBuilding(Building building)
        {
            AllBuildings.Add(building);
        }
    }
}