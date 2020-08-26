using System;

namespace Planner
{
    // Define class here
    public class Building
    {
        //Private Fields
        private string _designer = "Brandon Wheatley";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        //Public Properties
        public int stories { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public double volume
        {
            get
            {
                return width * depth * (stories * 3);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void DisplayBuilding()
        {
            Console.WriteLine(_address);
            Console.WriteLine("-----------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{volume} cubic meters of space");
            Console.WriteLine();
        }
    }

}