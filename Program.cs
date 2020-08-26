using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                stories = 10,
                width = 5,
                depth = 5,
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Ronald McDonald");
            FiveOneTwoEigth.DisplayBuilding();

            Building SevenSixOneFifth = new Building("761 5th Place")
            {
                stories = 7,
                width = 9,
                depth = 3,
            };
            SevenSixOneFifth.Construct();
            SevenSixOneFifth.Purchase("Gary Busey");
            SevenSixOneFifth.DisplayBuilding();
        }

    }
}