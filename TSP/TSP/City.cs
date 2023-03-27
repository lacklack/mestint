using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class City
    {
        Vector2 position;
        string name;

        public City(Vector2 position, string name)
        {
            this.position = position;
            this.name = name;
        }

        public string Name { get { return name; } set { name = value; } }
        internal Vector2 Position { get { return position; } set {  position = value; } }

    }
}
