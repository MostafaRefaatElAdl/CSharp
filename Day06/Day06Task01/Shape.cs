using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    public abstract class Shape
    {
        public abstract int GetArea();

    }

    public class Square : Shape
    {
        private int side;

        public Square(int _side)
        { side = _side; }
        public override int GetArea()
        {
            return side * side;
        }
    }
}
