// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("please entere your name");

//string guestName = Console.ReadLine();

//Console.WriteLine("Welcome to programming " + guestName);

//************* press ctrl + K + C for comments and ctrl + K + U for uncomment**************


//Console.WriteLine("Enter First Number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//int num2 = Convert.ToInt32(Console.ReadLine());

#region Calculations
//int addition = num1 + num2;
//int sub = num1 - num2;
//int division = num1 / num2;
//int multiplication = num1 * num2;

//Console.WriteLine("addition : " + addition);
//Console.WriteLine("subtraction : " + sub);
//Console.WriteLine("division : " + division);
//Console.WriteLine("multiplication : " + multiplication);
#endregion

// Data types in c#
// int, string, double, float, bool, custom datatype with class

#region  if else condition
//Console.WriteLine("Enter A number");
//int num = Convert.ToInt32(Console.ReadLine());

//if(num == 0)
//{
//    Console.WriteLine("This is not a acceptable number");

//}
//else if (num > 0 && num < 10)
//{
//    Console.WriteLine("Poor Number");
//}
//else if (num > 10 && num < 20)
//{
//    Console.WriteLine("Poor Number");
//}
//else if (num > 20 && num < 30)
//{
//    Console.WriteLine("Poor Number");
//}
//else if (num > 30 && num < 40)
//{
//    Console.WriteLine("Poor Number");
//}
//else if (num > 40)
//{
//    Console.WriteLine("Excellent Number");
//}

#endregion


#region for loop

//Console.WriteLine("Enter a table to print");
//int table = Convert.ToInt32(Console.ReadLine());    

//for(int i =1; i <= 10; i++)
//{
//    Console.WriteLine(table + " * " + i + " = " + (table * i));
//}
#endregion 


// collections are grp of similar data
//array -used wen uk how much data to store and know the data type 
//arraylist - bad with performance but can any number of data
//list - most used standards, store any number of data
//dictionary -  this is a key and value pair

// Array
#region array
//string[] friends = new string[5];
//friends[0] = "anand";
//friends[1] = "rahul";
//friends[2] = "virat";
//friends[3] = "shobhit";
//friends[4] = "mohan";

//for (int i = 0; i < friends.Length; i++)
//{
//    Console.WriteLine(friends[i]);
//}
#endregion

#region ArrayList

//using System.Collections; // you should move it to lines on top or in begining

//ArrayList myList = new ArrayList();
//myList.Add(10);
//myList.Add("anand");
//myList.Add(false);
//myList.Add(67.98);
//myList.Add(876543223456789);
//myList.Add(20);
//myList.Add("jeet");
//myList.Add(true);
//myList.Add(67.98);
//myList.Add(8765432);

//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}

#endregion

#region List


//List<string> guestList = new List<string>();
//guestList.Add("Guest 1");
//guestList.Add("Guest 2");
//guestList.Add("Guest 3");
//guestList.Add("Guest 4");
//guestList.Add("Guest 5");
//guestList.Add("Guest 6");
//guestList.Add("Guest 7");
//guestList.Add("Guest 8");
//guestList.Add("Guest 9");
//guestList.Add("Guest 10");
//guestList.Add("Guest 11");

//foreach (var guest in guestList)
//{
//    Console.WriteLine(guest);
//}

#endregion

#region Dictionary - key and a value pair, key is unique

//Dictionary<int, string> particapanttList = new Dictionary<int, string>();

//particapanttList.Add(101, "shobhit");
//particapanttList.Add(102, "pari");
//particapanttList.Add(103, "anand");
//particapanttList.Add(104, "jeet");
//particapanttList.Add(105, "anurag");
//particapanttList.Add(106, "suharsha");
//particapanttList.Add(107, "chandana");
//particapanttList.Add(108, "ayesha");

//foreach (var participants in particapanttList)
//{
//    Console.WriteLine(participants.Key + " : " + participants.Value);
//}



#endregion




// ************************  OOPs *************************

    // objects are created from a design - called blue print
     // create a file - class file

       // class - they are also called as a custom datatype