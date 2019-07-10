using System;

namespace Planner2
{
    public class Building
    {
        private string _name = "Eliot Clarke";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double TotalVolume { get; set; }

        public void Volume()
        {
            TotalVolume = Width * Depth * (3 * Stories);
        }

        public Building(string addressInput)
        {
            _address = addressInput;
        }

        public void Construct(double NewWidth, double NewDepth, int NewStories)
        {
            _dateConstructed = DateTime.Now;
            Width = NewWidth;
            Depth = NewDepth;
            Stories = NewStories;
            Volume();
        }

        public void Purchase(string BuyerName)
        {
            _owner = BuyerName;
        }

        public void DisplayBuildInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_name}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{TotalVolume} cubic meters of space");
        }
    }
}