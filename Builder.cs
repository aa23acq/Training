using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class HouseBuilder : IHouseBuilder
    {
        private readonly House _house = new House();
        public void BuildDoors(int count)
        {
            _house.Doors = count;
        }

        public void BuildRoof()
        {
           _house.Roof = true;
        }

        public void BuildWalls(int count)
        {
           _house.Walls = count;
        }

        public void BuildWindows(int count)
        {
            _house.Windows = count;
        }

        public House Build()
        {
            return _house;
        }
    }
    public class House
    {
        public int Walls { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public bool Roof { get; set; }

        public override string ToString()
        {
            return $"Walls: {Walls}, Doors: {Doors}, Windows: {Windows}, Roof: {Roof}";
        }
    }

    interface IHouseBuilder
    {
        void BuildWalls(int count);
        void BuildDoors(int count);
        void BuildWindows(int count);
        void BuildRoof();
        House Build();
    }
}
