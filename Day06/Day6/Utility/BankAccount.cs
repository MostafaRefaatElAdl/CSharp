using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class BankAccount
    {
        static int interstRate;
        static BankAccount()
        {
            interstRate = 100;
        }
        public static int InterstRate { 
            
            get { return interstRate; } 
            set { interstRate = value; }
        }
        //public static int getinterstrate()
        //{
            
        //    return interstrate;
        //}
        //public static void setinterstrate(int _rate)
        //{
        //    interstrate = _rate;
        //}
        public int Id { set; get; }
        string name;
        public string Name
        {
            set
            {
                if (value.Length > 3)
                    name = value;
            }
            get
            {
                return name;
            }
        }
        public decimal Balnce { set; get; }
        //
        //Object member
        public void Print()
        {
            Console.WriteLine($"{name}:{Id}:{Balnce}:{interstRate}");
        }

    }
}
