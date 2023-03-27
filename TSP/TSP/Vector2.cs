﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Vector2
    {
        float x;
        float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(double x, double y)
        {
            this.x = (float)x;
            this.y = (float)y;
        }
        

        public float X
        {
            get { return x; }
            set { x = value; }
        }



        public float Y {
            get { return y; }
            set { y = value; }
        }

        public static float Distance(Vector2 a, Vector2 b)
        {
            return (float)Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
        }
    }
}
