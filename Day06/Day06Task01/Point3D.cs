using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    public class Point3D: IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x, int _y, int _z) 
        {
            X = _x; Y = _y; Z = _z; 
        }
        public Point3D() : this(0, 0, 0)
        {
        }

        public static explicit operator string (Point3D p) 
        { return $"({p.X},{p.Y},{p.Z})"; }

        public override bool Equals(object? obj)
        {
            Point3D pt3 = obj as Point3D;
            if (pt3 == null)
                return false;
            else
                return base.Equals((Point3D)obj) && Z == pt3.Z;
        }

        public int CompareTo(object? obj)
        {
            Point3D p = obj as Point3D;
            if (p == null)
                return 1;
            return X.CompareTo(p.X);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ Z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }



    }
}
