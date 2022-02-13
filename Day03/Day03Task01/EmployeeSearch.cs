

namespace Day03Task01
{
    class EmployeeSearch
    {
        int[] nationalID;
        Employee[] employee;
        int size;

        public EmployeeSearch()
        {
            size = 5;
            nationalID = new int[size];
            employee = new Employee[size];
        }
        public EmployeeSearch(int _size)
        {
            size = _size;
            nationalID = new int[size];
            employee = new Employee[size];
        }
        public void Add(int index, int _nationalID, Employee _employee)
        {
            if (index >= 0 && index < size)
            {
                nationalID[index] = _nationalID;
                employee[index] = _employee;
            }
        }

        //to edit : 
        public Employee this[int index, int _nationalID, Employee _employee]
        {
            set
            {
                if (index >= 0 && index < size)
                {
                    nationalID[index] = _nationalID;
                    employee[index] = _employee;
                }
            }
        }

        // to get using ID
        public Employee this[int _nationalID]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (nationalID[i] == _nationalID)
                    {
                        return employee[i];
                    }
                }
                throw new Exception("Not Found!!!!");
            }
        }

        public Employee this[HiringDate date]
        {
            get
            {
                
                for (int i = 0; i < size; i++)
                {
                    if (employee[i].HireDate.Equals(date))
                    {
                        return employee[i];
                    }
                }
                throw new Exception("Not Found!!!!");
            }
        }


    }
}

















//public int[] NationalID 
//{ get { return nationalID; } set { nationalID = value; } } 

//public Employee[] Employees
//{ get { return employees; } set { employees = value; } }