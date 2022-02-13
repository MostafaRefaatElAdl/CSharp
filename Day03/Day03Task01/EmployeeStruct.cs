using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03Task01
{
    struct Employee
    {
        private int id;
        private SecurityPrivileges securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        private Gender gender;
        //=============================================//
        //Constructor
        public Employee(int _id, SecurityPrivileges _securityLevel, decimal _salary, HiringDate _hireDate, Gender _gender)
        {
            id = _id;
            securityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }
        //=============================================//

        //properties
        public int Id
        { get { return id; } set { id = value; } }
        public SecurityPrivileges SecurityLevel 
        { get { return securityLevel; } set { securityLevel = value; } }
        public decimal Salary 
        { get { return salary; } set { salary = value; } }

        public HiringDate HireDate 
        { get { return hireDate; } set { hireDate = value; } }

        public Gender Gender 
        { get { return gender; } set { gender = value; } }

        void employeeSort(Employee [] emp) {
            foreach (Employee employee in emp) {
            
            }
        }

        //override ToString()
        public override string ToString()
        {
            //default ToString
            return $"Employee id : {id},\n" +
                $"Salary : {salary},\n" +
                $"securityLevel : {securityLevel},\n" +
                $"gender : {gender},\n" +
                $"hiring date : {hireDate}\n";
        }

    }
}
