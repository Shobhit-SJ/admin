using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization_Demo
{
    // if you want object of Employee to go out of RAM and Store somewhere
    // we have to work with Attribute [Serializable]


    [Serializable]
    public class Employee
    {

        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public bool empIsPermanent { get; set; }
        public int empSalary { get; set; }
    }
}
