﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Operator
    {
        City to;
        City from;

        public Operator(City to, City from) {
            this.to = to;
            this.from = from;
        }

        public City To { get { return to; } set { to = value; } }
        public City From { get { return from; } set { from = value; } }

        public bool IsExistingState(State state)
        {
            if (from != to && state.Cities.Contains(to))
            {
                return true;
            }
            return false;
        }

        public State ApplyState(State state)
        {
            State newState = state;
            newState.Distance += GetDistance();
            newState.Cities.Remove(To);
            return newState;
        }

        public float GetDistance()
        {
            return Vector2.Distance(from.Position, to.Position);
        }
    }
}
