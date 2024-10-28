using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp_OOPs
{
    internal class PF: Accounts
    {
        public override double Withdraw(int amount)
        {

            if (amount > 50000)
            {
                throw new ArgumentException("You can withdraw max 50000");
            }
            return base.Withdraw(amount);
        }
        public override double Deposit(int amount)
        {

            if (amount > 3000)
            {
                throw new Exception(" you can't deposit more than 3000");
            }
            return base.Deposit(amount);
        }
        public void print()
        {
            Console.WriteLine(" this is a PF Account : ");
        }
        public void pfDetails()
        {
            Console.WriteLine("your acc name is: " + AccountName + " " + " your account number is : " +
        AccountNumber + "  balance is " + AccountBalance + "  acc is active : "
        + AccountIsActive + " last name :  " + AccountLastName + "\n" + "________________________________________________________________________________________________" + "\n") ;
        }
    }
}
