using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_Application
{
    internal class Accounts
    {

        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public int accBalance { get; set; }
        public bool accIsActive { get; set; }
        public string accCity { get; set; }


        public static List<Accounts> accList = new List<Accounts>()
        {
            new Accounts() { accNo = 101, accCity = "Bangalore", accIsActive = false, accName ="shobhit1", accType="savings", accBalance = 80000},
            new Accounts() { accNo = 102, accCity = "Mumbai", accIsActive = true, accName ="shobhit12", accType="PF", accBalance = 70000},
            new Accounts() { accNo = 103, accCity = "Prayagraj", accIsActive = true, accName ="shobhit13", accType="savings", accBalance = 55000},
            new Accounts() { accNo = 104, accCity = "Bangalore", accIsActive = true, accName ="shobhit14", accType="current", accBalance = 43000},
            new Accounts() { accNo = 105, accCity = "Prayagraj", accIsActive = false, accName ="shobhit15", accType="savings", accBalance = 87000},
            new Accounts() { accNo = 106, accCity = "Bangalore", accIsActive = true, accName ="shobhit156", accType="current", accBalance = 43000},
            new Accounts() { accNo = 107, accCity = "Delhi", accIsActive = false, accName ="shobhit17", accType="PF", accBalance = 76000},
            new Accounts() { accNo = 108, accCity = "Bangalore", accIsActive = false, accName ="shobhit18", accType="savings", accBalance = 34000},
            new Accounts() { accNo = 109, accCity = "Delhi", accIsActive = true, accName ="shobhit19", accType="PF", accBalance = 56000},
            new Accounts() { accNo = 110, accCity = "Mumbai", accIsActive = false, accName ="shobhit120", accType="current", accBalance = 78000}

        };
    }
    
}
