using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_collections
{
    internal class Employee
    {
        public int empNo { get; set; }
        public double empSalary{ get; set; }
        public string empDesignation { get; set; }
        public bool employeeIsPermanent { get; set; }
        public string empName { get; set; }

        public static List<Employee> eList = new List<Employee>()
        {
            new Employee(){empNo = 101, empDesignation ="sales", employeeIsPermanent= true, empName ="Shobhit1", empSalary= 40000},
            new Employee(){empNo = 102, empDesignation ="sales", employeeIsPermanent= true, empName ="Shobhit2", empSalary= 50000},
            new Employee(){empNo = 103, empDesignation ="HR", employeeIsPermanent= true, empName ="Shobhit3", empSalary= 56000},
            new Employee(){empNo = 104, empDesignation ="sales", employeeIsPermanent= false, empName ="Shobhit4", empSalary= 50000},
            new Employee(){empNo = 105, empDesignation ="HR", employeeIsPermanent= false, empName ="Shobhit5", empSalary= 30000},
            new Employee(){empNo = 106, empDesignation ="SDE", employeeIsPermanent= true, empName ="Shobhit6", empSalary= 70000},
            new Employee(){empNo = 107, empDesignation ="SDE", employeeIsPermanent= true, empName ="Shobhit7", empSalary= 20000},
            new Employee(){empNo = 108, empDesignation ="sales", employeeIsPermanent= false, empName ="Shobhit8", empSalary= 10000},
            new Employee(){empNo = 109, empDesignation ="Accounts", employeeIsPermanent= true, empName ="Shobhit9", empSalary= 45000},
            new Employee(){empNo = 110, empDesignation ="sales", employeeIsPermanent= true, empName ="Shobhit10", empSalary= 55000},
            new Employee(){empNo = 111, empDesignation ="Accounts", employeeIsPermanent= false, empName ="Shobhit11", empSalary= 45000},
            new Employee(){empNo = 112, empDesignation ="sales", employeeIsPermanent= true, empName ="Shobhit121", empSalary= 80000},

        }; 


    }
}
