﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    internal class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
 
        public Point2D()
        {

        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int AreaCalc(int X,int Y)
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"Souřadnice bodu jsou: [{X} {Y}] plocha je: {AreaCalc(X,Y)}";
        }
    }
}
