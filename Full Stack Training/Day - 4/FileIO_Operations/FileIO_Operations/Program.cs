// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
//***********************************---------- API -------------**********************************
// Networking API
//


// FILE OPERATIONS
// System.IO

// classes as below 
// 1. filestream --- this will hold the file and rights on the file

// FileStream myFile = new FileStream("myfile.txt, FileMode.CreateNew,FileAccess.Write);

//in above --> FileMode.Create - always create new file , deleted previous file if with same name available.
// ----------> FileMode.CreateNew - create new file if same file name doesnot exist.
// 2. StreamWriter -- this will allow you to write into a file - this is Pen
// StreamWriter pen = new StreamWriter(myFileObj);
// pen.WriteLine("Hello");
// pen.WriterLine("World");
// pen.WriterLine("Thanks for writing");

// 3. StreamReader read = new StreamReader(myFileObj);
//read.ReadToEnd();


#region Write File

//FileStream myFile = new FileStream("myDetails.txt", FileMode.CreateNew, FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);

//try
//{
//    pen.WriteLine("helooow shobhit");
//    pen.WriteLine("i am shobhit");
//    pen.WriteLine("i live in bangalore");
//    pen.WriteLine("I am a SDE");
//    pen.WriteLine("i love to play guitar");
//    pen.WriteLine("deleted last file???");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    pen.Close(); // *Important: first close pen then close file.
//    myFile.Close();
//    Console.WriteLine("Details Written to File");
//}
#endregion


#region Dynamic Writing to file
//Console.WriteLine("please enter your name");
//string user = Console.ReadLine();

//FileStream myFile = new FileStream(user + ".txt", FileMode.Create, FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);

//try
//{
//    string text = "";
//    Console.WriteLine("say something about yourself , Type End once done. ");
//    while(text != "End")
//    {
//        text = Console.ReadLine();
//        pen.WriteLine(text);
//    }
//}
//catch(Exception es)
//{
//    Console.WriteLine(es.Message);
//}
//finally
//{ 
//    pen.Close();
//    myFile.Close();
//    Console.WriteLine("thank you");
//}
#endregion


#region Dynamic Read from File
Console.WriteLine("enter the name of the file you want to read");
string filename = Console.ReadLine();
FileStream myFile = new FileStream(filename + ".txt", FileMode.Open, FileAccess.Read);
StreamReader reader = new StreamReader(myFile);

Console.WriteLine(reader.ReadToEnd());

#endregion


//File IO is designed for primitive data types

//    but for custom datatype, we need to store object, and in a format (XML, JSON, binary...)

//    Serilaization - Save the obejct from memory(RAM) to a storage (Disk/ Network)
//    Deserialization - Bring the object back from disk to RAM.
       
//        XML and JSON formats are used
        
//        using System.Runtime.Serialization;


