using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp_OOPs
{
    internal class Accounts
    {
        #region Properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }
        public bool AccountIsActive { get; set; }
        public string AccountLastName { get; set; }
        #endregion


        #region methods
        public virtual double Withdraw(int amount)
        {
            AccountBalance -= amount;
            return AccountBalance;
        }

        public virtual double Deposit(int amount)
        {
            AccountBalance += amount;
            return AccountBalance;

        }
        #endregion

    }
}
