namespace Utility
{
    //operator overload
    //public static
    //unary operator + - ++ -- !
    //binary operator + -  * / %  &  > < == != >= <=
    //ont overloadable && || = += . [] ?? ?. ?:
   public struct Complex
    {
        
        public int Real { get; set; } //automatic property
        public int Img { get; set; }
        public Complex(Complex c)
        {
            Real = c.Real;
            Img = c.Img;
        }
        public static Complex operator+(Complex left,Complex right)
        {
            return new Complex(left.Real + right.Real, left.Img + right.Img);

        }
        public static Complex operator+(Complex left,int right)
        {
            return new Complex(left.Real + right, left.Img);
        }
        public static Complex operator +(int left, Complex right)
        {
            return right + left;
        }
        public static Complex operator++(Complex o)
        {
            
            return new Complex(o.Real+1, o.Img);
        }
        //public static bool operator==(Complex left,Complex right)
        //{
        //    return left.Real==right.Real && left.Img==right.Img;
        //}
        //public static bool operator !=(Complex left, Complex right)
        //{
        //    return !(left == right);
        //}
        public static explicit operator int (Complex c)
        {
            return c.Real;
        }

        public Complex():this(0,0)
        {
            Console.WriteLine("parameterless constructor");
            //Real = 0;
            //Img = 0;
        }

        public Complex(int _real):this(_real,0)
        {
            //Real= _real;
            //Img = 0;
            Console.WriteLine("one param ctot");
        }
        public Complex(int _real,int _img)
        {
            Console.WriteLine("Two Param Ct");
            Real = _real;
            Img = _img;
        }

        public override string ToString()
        {
            return $"{Real}+{Img}J";
        }
    }
}