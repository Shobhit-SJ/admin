using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp_OOPs
{
    internal class Current : Accounts
    {
        public override double Withdraw(int amount)
        {

            if (amount > 100000)
            {
                throw new ArgumentException("You can withdraw max 100000");
            }
            return base.Withdraw(amount);
        }
        public override double Deposit(int amount)
        {

            if (amount > 2000)
            {
                throw new Exception(" you can't deposit less than 2000");
            }
            return base.Deposit(amount);
        }

        public void print()
        {
            Console.WriteLine(" this is a current Account : ");
        }
        public void currentDetails()
        {
            Console.WriteLine("your acc name is: " + AccountName + " " + " your account number is : " +
        AccountNumber + "  balance is " + AccountBalance + "  acc is active : "
        + AccountIsActive + " last name :  " + AccountLastName + "\n" + "________________________________________________________________________________________________" + "\n");
        }
    }
}
