using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp_OOPs
{
    internal class Savings : Accounts
    {
        public void print()
        {
            Console.WriteLine(" this is a saving Account : ");
        }

        public override double Withdraw(int amount)
        {

            if(amount > 20000)
            {
                throw new Exception("you can withdraw max 20000");
            
            }
            return base.Withdraw(amount);
        }

        public override double Deposit(int amount)
        {

            if (amount < 1000)
            {
                throw new Exception(" you can't deposit less than 1000");
            }
            return base.Deposit(amount);
        }
        public void savingsDetails()
        {
            Console.WriteLine("your acc name is: " + AccountName + " " + " your account number is : " +
    AccountNumber + "  balance is " + AccountBalance + "  acc is active : "
    + AccountIsActive + " last name :  " + AccountLastName + "\n" + "________________________________________________________________________________________________\n");
        }
    }
}
