// See https://aka.ms/new-console-template for more information
using bankingApp;

Console.WriteLine("Hello, World!");


List<Accounts> accList = new List<Accounts>()
{

    new Accounts(){ accNo = 101, accName = "shobhit", accType = "savings", accIsActive = true , accBalance = 45678}


};

void showDetails(Accounts cust)
{
    Console.WriteLine("your name is " + cust.accName + "acc non is : " + cust.accNo +
        "status of your acc is active : " + cust.accIsActive + " " + "your amount is :  " + cust.accBalance);
}

foreach (var acc in accList)
{
    showDetails(acc);
   // or u can print like below;
    //Console.WriteLine(acc.accName + acc.accNo );
   
    acc.withDraw(5000);
    acc.deposit(4567);
}



