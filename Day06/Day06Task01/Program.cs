using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06Task01
{
    internal class Program
    {
        static void Main()
        {
            Point3D p1 = new Point3D(10, 20, 30);
            Console.WriteLine("Printing with the requried Coordinates");
            Console.WriteLine("======================================");
            Console.WriteLine(p1);
            Console.WriteLine("======================================");
            //====================casting to string=======================//
            string str1 = (string)p1;
            Console.WriteLine("Printing string after casting");
            Console.WriteLine("======================================");
            Console.WriteLine(str1);
            Console.WriteLine("======================================");
            //====================Read from user then parse=======================//
            //Console.WriteLine("Enter 1st point");
            //string x = Console.ReadLine();
            //int.TryParse(x, out int px);
            //Console.WriteLine("Enter 2nd point");
            //string y = Console.ReadLine();
            //int py = Int32.Parse(y);
            //Console.WriteLine("Enter 3rd point");
            //string z = Console.ReadLine();
            //int pz = Convert.ToInt32(z);
            //Point3D uinput = new Point3D(px, py, pz);
            //Console.WriteLine("Printing Useriputs after Parsing");
            //Console.WriteLine("======================================");
            //Console.WriteLine(uinput);
            //Console.WriteLine("======================================");
            //====================Try == on class objects If (P1 ==P2) =======================//
            Point3D p3 = new Point3D(10, 10, 10);
            Point3D p4 = new Point3D(10, 10, 10);
            Console.WriteLine("Try == operator on class objects");
            Console.WriteLine("======================================");
            if (p3 == p4)
            {
                Console.WriteLine("It's true equals");
            }
            else
            {
                Console.WriteLine("It doesn't equal");
            }
            Console.WriteLine("======================================");
            //It doesn't work right cuz it equals the refs not the states
            //==================== Add, Subtract, Multi, Divide without creating an instance ========//
            Console.WriteLine("Trying Add, Subtract, Multi, Divide without creating an instance");
            Console.WriteLine("======================================");
            Console.WriteLine($"50 + 100 = { Math.Add(50, 100)}");
            Console.WriteLine($"200 - 70 = { Math.Subtract(200, 70)}");
            Console.WriteLine($"7 X 12 = {Math.Multiply(7, 12)}");
            Console.WriteLine($"40 / 4 = {Math.Divide(40, 4)}");
            Console.WriteLine("======================================");
            //==================== one object from NIC class ========//
            Console.WriteLine("one object from NIC class");
            Console.WriteLine("======================================");
            NIC obj = NIC.CreateNIC("192.168.1.1", "Zlink", "198:147:457:124", Type.Ethernet);
            Console.WriteLine(obj);
            NIC objTest = NIC.CreateNIC("Blalal", "TP", "BLalala", Type.tokenRing);
            Console.WriteLine(objTest);
            Console.WriteLine("======================================");
            //==================== Define Class Duration ========//
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);
            Duration D4 = new Duration(666);
            Console.WriteLine(D4);

            Duration D8 = new Duration(0, 0, 0);
            Console.WriteLine(D8);

            //=====================================================//

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = D1++;
            D3 = --D2;
            D1 = -D2;
            if (D1 > D2) ;
            if (D1 <= D2) ;
            if (D8) { }
            else
            {
                Console.WriteLine("Hi i have no data");
            }
            if (D1)
                Console.WriteLine("Hi i have data");
            //=====================Day07 Tasks==========================//
            //=== Define array of points && Sort this array based on X & Y coordinates ===//
            Point3D[] arrPo = new Point3D[3];
            arrPo[0] = new Point3D(30, 20, 40);
            arrPo[1] = new Point3D(10, 10, 50);
            arrPo[2] = new Point3D(50, 30, 20);
            Console.WriteLine("==============================");
            Console.WriteLine("Array before sorting..");
            Console.WriteLine("==============================");
            foreach (var item in arrPo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============================");


            Array.Sort(arrPo);
            Console.WriteLine("Array after sorting..");
            Console.WriteLine("==============================");
            foreach (var item in arrPo)
            {
                Console.WriteLine(item);
            }

            /*=====Implement IClonable interface to be able to clone the object 
             To implement more than one interface: class Point3D : IComparable, ICloneable ===*/


        }


    }
}
