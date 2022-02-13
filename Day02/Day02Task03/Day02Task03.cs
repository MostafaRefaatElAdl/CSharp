using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Task03
{
    internal class Day02Task03
    {
        public static void firstWay()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int count = 0;
            for (int i = 1; i <= 99_999_999; i++)
            {
                int numberToExamine = i;

                while (numberToExamine > 0)
                {
                    int lastDigit = numberToExamine % 10;
                    if (lastDigit == 1) count++;
                    numberToExamine /= 10;
                }
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(count);

        }
        public static void secondWay()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int count = 0;
            for (int i = 1; i < 99_999_999; i++)
                count += i.ToString().Count(c => c == '1');
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(count);
        }
        public static void Main() 
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int counter = 0;
            int n = 8;
            counter = (int)(n * Math.Pow(10, n - 1));
            //100,000,000 * 8 / 10;
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            Console.WriteLine(counter);
        }



    }
}
