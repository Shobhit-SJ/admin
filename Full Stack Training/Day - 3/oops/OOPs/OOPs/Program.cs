
// ************************  OOPs *************************

// objects are created from a design - called blue print
// create a file - class file

// class - they are also called as a custom datatype



using OOPs;

Console.WriteLine("Hello, World!");

Employee empobj = new Employee();
empobj.empNo = 1;
empobj.empName = "Mr. Jaiswal";
empobj.empDesignation = "SDE";
empobj.empIsPermanent = true;
empobj.empSalary = 590000;

Console.WriteLine(empobj.GetDetails());

List<Employee> empList = new List<Employee>()
{
    new Employee() { empNo = 101, empName = "shobhit1", empDesignation = "SDE", empIsPermanent = true, empSalary = 70000 },
    new Employee() { empNo = 102, empName = "shobhit2", empDesignation = "sde1", empIsPermanent = true, empSalary = 34000 },
    new Employee() { empNo = 103, empName = "shobhit3", empDesignation = "SDE2", empIsPermanent = false, empSalary = 34000 },
    new Employee() { empNo = 104, empName = "shobhit4", empDesignation = "SDE3", empIsPermanent = false, empSalary = 65000 },
    new Employee() { empNo = 105, empName = "shobhit5", empDesignation = "SDE4", empIsPermanent = true, empSalary = 23000 },
    new Employee() { empNo = 106, empName = "shobhit6", empDesignation = "SDE2", empIsPermanent = false, empSalary = 98000 }

};

foreach ( var items in empList)
{
    Console.WriteLine("Employee number : " + items.empNo);
    Console.WriteLine("Employee Name : "+ items.empName);
    Console.WriteLine(" Employee designation : "+items.empDesignation);
    Console.WriteLine("Employee is Permanent : "+ items.empIsPermanent);
    Console.WriteLine("Employee Salary : "+ items.empSalary);
    Console.WriteLine("----------------------------------------------------------------------------");

}





 
