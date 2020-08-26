using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City metropolis = new City();
            metropolis.name = "Metropolis";
            metropolis.mayor = "Batman";
            metropolis.dateEstablished = "1943";

            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                stories = 10,
                width = 5,
                depth = 5,
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Ronald McDonald");

            Building SevenSixOneFifth = new Building("761 5th Place")
            {
                stories = 7,
                width = 9,
                depth = 3,
            };
            SevenSixOneFifth.Construct();
            SevenSixOneFifth.Purchase("Gary Busey");

            metropolis.AddBuilding(FiveOneTwoEigth);
            metropolis.AddBuilding(SevenSixOneFifth);

            foreach (Building building in metropolis.Buildings)
            {
                building.DisplayBuilding();
            }

        }

    }
}