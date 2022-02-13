using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class UnitsConverter
    {
        const float pi = 3.14f;
        
        public static float GetCircleArea(float r)
        {
            return r * r * pi;
        }
        public static float FromFahToCel(float f)
        {
            float z = (f - 32) * 5 / 9;
            return z;
        }
        public static float FromCelToFah(float c)
        {
            float z = (c * 9 / 5) + 32;
            return z;
        }
    }
}
