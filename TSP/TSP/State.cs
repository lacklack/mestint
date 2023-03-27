using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class State
    {
        List<City> cities = new List<City>();

        public List<City> Cities { get { return cities; } set { cities = value; } }
        float distance;

        public float Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public State(int ammount, int seed)
        {
            Random rnd = new Random(seed);
            for (int i = 0; i < ammount; i++)
            {
                cities.Add(new City(new Vector2(rnd.NextDouble() * 10, rnd.NextDouble() * 10), $"City {i}"));
            }
        }

        public bool IsTargetState()
        {
            if (cities.Count < 1)
            {
                return true;
            }
            return false;
        }
    }
}
