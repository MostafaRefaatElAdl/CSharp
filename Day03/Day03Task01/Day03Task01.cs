using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03Task01
{
    internal class Day03Task01
    {
        public static void Main()
        {
            //intializing & testing
            HiringDate d1 = new HiringDate(12, 5, 2015);
            HiringDate d2 = new HiringDate(2, 5, 2022);
            HiringDate d3 = new HiringDate(3, 5, 2017);
            SecurityPrivileges allPrivileges = SecurityPrivileges.Guest | SecurityPrivileges.Developer | SecurityPrivileges.DBA | SecurityPrivileges.Secretary;
            //Console.WriteLine(allPrivileges);
            //Gender from user 
            //Console.WriteLine("Please enter the employee Gender : (f/m)...");
            //string ui = Console.ReadLine();
            //Gender g1 = (Gender)Enum.Parse(typeof(Gender), ui);
            //--------------------------------------------------//

            //Employee DBA = new Employee(1, SecurityPrivileges.DBA, 2000, d1, Gender.m);
            Employee[] employeesArr = new Employee[3];
            employeesArr[0] = new Employee(1, SecurityPrivileges.DBA, 2000, d1, Gender.m);
            employeesArr[1] = new Employee(2, SecurityPrivileges.Guest, 1000, d2, Gender.f);
            employeesArr[2] = new Employee(3, allPrivileges, 1000, d3, Gender.f);

            EmployeeSearch empSearch = new EmployeeSearch();
            empSearch.Add(1, 1, employeesArr[0]);
            empSearch.Add(2, 2, employeesArr[1]);
            empSearch.Add(3, 3, employeesArr[2]);
            Console.WriteLine("========================================");
            Console.WriteLine("Search using indexer using ID");
            Console.WriteLine("========================================");
            Console.WriteLine( empSearch[1]);
            Console.WriteLine("========================================");
            Console.WriteLine("Search using indexer using Hiredate");
            Console.WriteLine("========================================");
            Console.WriteLine(empSearch[d3]);
            Console.WriteLine("========================================");
            Console.WriteLine("Before sorting");
            Console.WriteLine("========================================");
            foreach (Employee employee in employeesArr)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("========================================");
            //-------------------- Sorting -----------------//
            Employee temp;

            for (int i = 0; i < employeesArr.Length - 1; i++)
            {

                for (int j = i + 1; j < employeesArr.Length; j++)
                {

                    if (employeesArr[i].HireDate.Year < employeesArr[j].HireDate.Year)
                    {
                        temp = employeesArr[i];
                        employeesArr[i] = employeesArr[j];
                        employeesArr[j] = temp;
                    }
                }
            }
            Console.WriteLine("========================================");
            Console.WriteLine("After sorting");
            Console.WriteLine("========================================");
            foreach (Employee employee in employeesArr)
            {
                Console.WriteLine(employee);
            }
            //============================================////


        }
    }
}
