//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
////File IO is designed for primitive data types

////    but for custom datatype, we need to store object, and in a format (XML, JSON, binary...)

////    Serilaization - Save the obejct from memory(RAM) to a storage (Disk/ Network)
////    Deserialization - Bring the object back from disk to RAM.

////        XML and JSON formats are used

////        using System.Runtime.Serialization;


//using System.Diagnostics.CodeAnalysis;

////serialization - when you want to persist the state of an object to a storage or network use seerializaton

//// process of bringing that object back into memory is called deserialization


//using serialization_Demo;
//using System.Xml.Serialization;
//using System.Text.Json;

//Employee employee = new Employee()
//{
//    empNo = 1,
//    empName = "shobhit",
//    empDesignation = "HR",
//    empIsPermanent = true,
//    empSalary = 6000
//};
//FileStream myFile = new FileStream(employee.empNo + ".xml", FileMode.Create, FileAccess.Write);

//#region XML Serialization
//XmlSerializer anyvar = new XmlSerializer(typeof(Employee));
//anyvar.Serialize(myFile, employee);// where and what you want to serialize
//myFile.Close();
//Console.WriteLine("Employee object serialized");
//#endregion

//#region JSONserializer

//JsonSerializer.Serialize(myFile, employee);
//myFile.Close();
//Console.WriteLine("Data saved in JSON file");

//#endregion

using serialization_Demo;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

//List<Employee> emplist = new List<Employee>() // emplist is list of object 
//{
//    new Employee(){ empNo = 1, empName = "shobhit1", empDesignation = "HR1", empIsPermanent = true, empSalary = 76000 },
//    new Employee(){ empNo = 2, empName = "shobhit2", empDesignation = "HR2", empIsPermanent = true, empSalary = 68000 },
//    new Employee(){ empNo = 3, empName = "shobhit3", empDesignation = "HR3", empIsPermanent = true, empSalary = 60900 },
//    new Employee(){ empNo = 4, empName = "shobhit4", empDesignation = "HR4", empIsPermanent = true, empSalary = 60060 },
//    new Employee(){ empNo = 5, empName = "shobhit5", empDesignation = "HR5", empIsPermanent = true, empSalary = 61000 },
//    new Employee(){ empNo = 6, empName = "shobhit6", empDesignation = "HR6", empIsPermanent = true, empSalary = 62000 },
//    new Employee(){ empNo = 7, empName = "shobhit7", empDesignation = "HR7", empIsPermanent = true, empSalary = 63000 },
//    new Employee(){ empNo = 8, empName = "shobhit8", empDesignation = "HR8", empIsPermanent = true, empSalary = 64000 },
//    new Employee(){ empNo = 9, empName = "shobhit9", empDesignation = "HR9", empIsPermanent = true, empSalary = 65000 },
//    new Employee(){ empNo = 10, empName = "shobhit10", empDesignation = "HR10", empIsPermanent = true, empSalary = 66000 }

//};
//FileStream myFile = new FileStream("empployeeList.xml", FileMode.Create, FileAccess.Write);

#region XML Serialization
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
//xmlSerializer.Serialize(myFile, emplist);
//myFile.Close();
//Console.WriteLine("XML Serilazation is successful");

#endregion


#region JSON Serailization
//JsonSerializer.Serialize(myFile, emplist);
//myFile.Close();
//Console.WriteLine("Data saved in JSON file");
#endregion



FileStream myFile = new FileStream("empployeeList.xml", FileMode.Open, FileAccess.Read);

XmlSerializer mySerilizer = new XmlSerializer(typeof(List<Employee>));

List<Employee> em = (List<Employee>)mySerilizer.Deserialize(myFile);
foreach (var emp in em)
{
    Console.WriteLine("emp  no: " + emp.empNo);
    Console.WriteLine("emp name: " + emp.empName);
    Console.WriteLine("emp salary : " + emp.empSalary);
    Console.WriteLine("emp is permanent : " + emp.empIsPermanent);
    Console.WriteLine(" emp designation : " + emp.empDesignation);

}
//Console.WriteLine("emp  no: " + em.empNo);
//Console.WriteLine("emp name: " + em.empName);
//Console.WriteLine("emp salary : " + em.empSalary);
//Console.WriteLine("emp is permanent : " + em.empIsPermanent);
//Console.WriteLine(" emp designation : " + em.empDesignation);