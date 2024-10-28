// See https://aka.ms/new-console-template for more information
using bankingApp_OOPs;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!" + "\n");

Savings savObj = new Savings();

savObj.AccountNumber = 1234567;
savObj.AccountName = "kotak";
savObj.AccountLastName = "jaiswal";
savObj.AccountBalance = 400000;
savObj.AccountIsActive = true;
savObj.Withdraw(2000);

//savObj.savingsDetails();

Current curObj = new Current();
curObj.AccountNumber = 98765;
curObj.AccountName = "jeet";
curObj.AccountLastName = "lalwani";
curObj.AccountBalance = 500000;
curObj.AccountIsActive = true;
curObj.Withdraw(20000);

curObj.currentDetails();


PF pfObj = new PF();
pfObj.AccountNumber = 6644567;
pfObj.AccountName = "anand";
pfObj.AccountLastName = "raj";
pfObj.AccountBalance = 800000;
pfObj.AccountIsActive = true;
pfObj.Deposit(2000);

pfObj.pfDetails();


try
{
    savObj.Withdraw(34000);
    Console.WriteLine("withdraww successful");
    Console.WriteLine(savObj.AccountBalance);
    
}
catch (Exception exepc)
{
    Console.WriteLine(exepc.Message);
}







//***********************************---------- API -------------**********************************
          // Networking API
          //


                         // FILE OPERATIONS
                 // System.IO

            // classes as below 
// 1. filestream --- this will hold the file and rights on the file

   // FileStream myFile = new FileStream("myfile.txt, FileMode.Create,FileAccess.Write);

// 2. StreamWriter -- this will allow you to write into a file - this is Pen
       // StreamWriter pen = new StreamWriter(myFileObj);
       // pen.WriteLine("Hello");
       // pen.WriterLine("World");
       // pen.WriterLine("Thanks for writing");

// 3. StreamReader read = new StreamReader(myFileObj);
        //read.ReadToEnd();


