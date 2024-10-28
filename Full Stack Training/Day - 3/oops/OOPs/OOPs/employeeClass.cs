

// ************************  OOPs *************************

// objects are created from a design - called blue print
// create a file - class file

// class - they are also called as a custom datatype


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs   // THIS IS FILE NAME
{
    internal class Employee   // THIS IS CLASS
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermanent { get; set; }


        public double GetCtc()
        {
            return empSalary * 12;
        }

        public string GetDetails()
        {
            return "empNo is " + empNo + " " + empName + " is a " + empDesignation;
        }

    }
}
