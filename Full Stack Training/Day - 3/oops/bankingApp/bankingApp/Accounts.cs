using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp
{
    internal class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public int accBalance { get; set; }
        public bool accIsActive { get; set; }



        public void withDraw(int value)
        {
            accBalance = accBalance - value;
            Console.WriteLine("Your new Balance is " + accBalance);
        }


         public void deposit(int value)
        {
            accBalance -= value;
            Console.WriteLine("Your new balance is after deposit : " + accBalance);
        }

      

    }

















}
