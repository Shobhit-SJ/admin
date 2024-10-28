// See https://aka.ms/new-console-template for more information

using banking_Application;


Console.WriteLine("Hello, World!");


bool startApp = true;

while (startApp)
{
    Console.Clear();
    Console.WriteLine("Accounts Management System");
    Console.WriteLine("1. Display all Accounts");
    Console.WriteLine("2. View Account Details");
    Console.WriteLine("3. Withdraw the Money");
    Console.WriteLine("4. Deposit the Money");
    Console.WriteLine("5. Transfer Money");
    Console.WriteLine("6. Summary");
    Console.WriteLine("7. Add");
    Console.WriteLine("8. Delete");
    Console.WriteLine("9. Update");
    Console.WriteLine("10. Exit");

    int whatEverYoursChoice = Convert.ToInt32(Console.ReadLine());


    switch (whatEverYoursChoice)
    {

        case 1:
            Console.WriteLine("Enter you UserName");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter you Password");
            string password = Console.ReadLine();
            if( (password == "shobhitjaiswal@123") && (userName == "ShobhitJaiswal"))
            {
                Console.WriteLine(" Here your All Accounts Access  ");
                var allAcc = (from a in Accounts.accList
                              select a).ToList();
                foreach (var item in allAcc)
                {
                    Console.WriteLine("________________________________________________________________________________________ \n");
                    Console.WriteLine("" + item.accNo);
                    Console.WriteLine("" + item.accName);
                    Console.WriteLine("" + item.accType);
                    Console.WriteLine("" + item.accIsActive);
                    Console.WriteLine("" + item.accCity);
                    Console.WriteLine("" + item.accBalance);
                    Console.WriteLine("________________________________________________________________________________________ \n");


                }
            }
            else
            {
                Console.WriteLine("Invalid Credential");
            }

            break;



        case 2:
            Console.WriteLine("Your Account Number? ");
            var accountNumber = Convert.ToInt32(Console.ReadLine());
            
            var accByNumber = (from a in Accounts.accList
                               where a.accNo == accountNumber
                               select a).Single();
            Console.WriteLine("--------------------------------------------------------------------\n");
            Console.WriteLine("Account Number : " + accByNumber.accNo);
            Console.WriteLine("Account Number : " + accByNumber.accName);
            Console.WriteLine("Account Number : " + accByNumber.accBalance);
            Console.WriteLine("Account Number : " + accByNumber.accCity);
            Console.WriteLine("Account Number : " + accByNumber.accIsActive);
            Console.WriteLine("Account Number : " + accByNumber.accType);

            break;




        case 3:
            Console.WriteLine("Enter the Account Number from which you want to Withdraw Money : ");
            var withdrawAccNo = Convert.ToInt32(Console.ReadLine());

            var withdraw = (from a in Accounts.accList
                            where a.accNo == withdrawAccNo
                            select a).Single();
            if((withdrawAccNo > 3000) && ( withdrawAccNo < withdraw.accBalance))
            {
                withdraw.accBalance -= withdrawAccNo;
                Console.WriteLine("\n withdrawal amount : " + withdrawAccNo + " Available Balance : " + withdraw.accBalance  + "\n" 
                    );

            }
            else
            {
                Console.WriteLine("INVALID AMOUNT");
            }
           
            break;




        case 4:
            Console.WriteLine("Enter the Account Number in which you want to Deposit Money : ");
            var depositAccNo = Convert.ToInt32(Console.ReadLine());

            var deposit = (from a in Accounts.accList
                            where a.accNo == depositAccNo
                            select a).Single();
            if ((depositAccNo > 1000) )
            {
                deposit.accBalance += depositAccNo;
                Console.WriteLine("\n withdrawal amount : " + depositAccNo + " Available Balance : " + deposit.accBalance + "\n"
                    );

            }
            else
            {
                Console.WriteLine("INVALID AMOUNT");
            }

            break;



        case 5:
            Console.WriteLine("Enter the Account Number from which you want to Transfer Money : ");
            var fromAccNo = Convert.ToInt32(Console.ReadLine());

            var fromAccount = (from a in Accounts.accList
                            where a.accNo == fromAccNo
                            select a).Single();

            Console.WriteLine("Enter the Account Number to which you want to Transfer Money : ");
            var ToAccNo = Convert.ToInt32(Console.ReadLine());

            var ToAccount = (from a in Accounts.accList
                        where a.accNo == ToAccNo
                        select a).Single();

            break;
        case 6:
            Console.WriteLine("Accounts Summary");

            break;
        case 7:
            Console.WriteLine("Enter Account Number to Add new Account");

            break;
        case 8:
            Console.WriteLine("Delete Existing Account Number");

            break;
        case 9:
            Console.WriteLine("Update Exisiting Account Number");

            break;
        case 10:
            Console.WriteLine("Thank You");
            break;


        default:
            Console.WriteLine("Successful");
            break;


    }
    Console.ReadLine();

}

