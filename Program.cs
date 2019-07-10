using System;

namespace Planner2
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to create classes and and use constructors!!!

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Construct(225.25, 335.75, 33);
            FiveOneTwoEigth.Purchase("Ted Cruz");

            Building FiveHundred = new Building("500 Interstate Boulevard S");
            FiveHundred.Construct(334.54, 775.89, 4);
            FiveHundred.Purchase("Steve Brownlee");

            Building CrappyHouse = new Building("1033 Petway Avenue");
            CrappyHouse.Construct(500.45, 500.45, 2);
            FiveHundred.Purchase("Pat Buttersmith");

            Building ThatOnePlace = new Building("4333344 OverThere Street");
            ThatOnePlace.Construct(34.2, 22, 450);
            ThatOnePlace.Purchase("Jisie David");

            City EliotTown = new City();

            EliotTown.IncorporateBuilding(FiveOneTwoEigth);
            EliotTown.IncorporateBuilding(FiveHundred);
            EliotTown.IncorporateBuilding(CrappyHouse);
            EliotTown.IncorporateBuilding(ThatOnePlace);

            foreach (Building building in EliotTown.AllBuildings)
            {
                building.DisplayBuildInfo();
            }

        }
    }
}
