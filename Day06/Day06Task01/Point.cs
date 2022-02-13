using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    public class Point:IComparable,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _x, int _y)
        {
            X = _x; Y = _y;
        }
        public Point()
        {
            X = Y = 0;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public int CompareTo(object? obj)
        {
            Point p = obj as Point;
            if (p == null)
                return 1;
            return X.CompareTo(p.X);
        }

        public object Clone()
        {
            return new Point(X, Y);
        }
    }
}
