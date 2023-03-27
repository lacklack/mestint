using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Solver
    {
        List<Operator> operators = new List<Operator>();
        internal List<Operator> Operators { get { return operators; } set { operators = value; } }

        public void GenerateOperators(State state, City lastCity)
        {
            operators.Clear();
            for (int i = 0; i< state.Cities.Count; i++)
            {
                if (state.Cities[i] != lastCity)
                {
                    operators.Add(new Operator(lastCity, state.Cities[i]));
                }
            }
        }
    }
}
