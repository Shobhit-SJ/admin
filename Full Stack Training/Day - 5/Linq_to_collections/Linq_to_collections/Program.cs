// See https://aka.ms/new-console-template for more information



//database-- - ado.net / entity framework
//collections        --- data structures
//mailbox            --- oledb
//excel/csv            
//xml                --- Xpath and Xquery
//json


//______________________________________________________________________________________________________________
//                   instead let us have a neutral language - LINQ - introduce with .net 4.0
//                                                            .net 4.Salso introduced lamda
//                                                           ( short hand linq)

//__________________________________________________________________________________________________________________

//                  LINQ  looks a lot like SQL

//          empList is data source;
//to get data from empList;

//var result = from e in empList(selct * from tablename)
//             select e;

//var deptItEmployee = from e in emList
//                     where e.empDesignation == "IT
//                     select e;




using Linq_to_collections;

Console.WriteLine("Hello, World!");




bool continueApp = true;

while (continueApp)
{

    #region Menu
    Console.Clear();
    Console.WriteLine(" Employee Management System");
    Console.WriteLine("1.Employee List");
    Console.WriteLine("2. Search by Employee NUmber");
    Console.WriteLine("3. search by employee Designation");
    Console.WriteLine("4. employee Summary");
    Console.WriteLine("5. Add Employee");
    Console.WriteLine("6. Update Employee");
    Console.WriteLine("7. Delete Employee");
    Console.WriteLine("8. Exit");

    int choice = Convert.ToInt32(Console.ReadLine());

    #endregion

    switch (choice)
    {
        #region CASE 1 : LIST EMPLOYEE
        case 1 :
            Console.WriteLine("Employee list is below ");
            var allEmp = (from e in Employee.eList
                          select e).ToList();
            foreach (var item in allEmp)
            {
                Console.WriteLine(item.empNo);
                Console.WriteLine(item.empName);
                Console.WriteLine(item.empSalary);
                Console.WriteLine(item.empDesignation);
                Console.WriteLine(item.employeeIsPermanent);
                Console.WriteLine("--------------------------------------------------------------------\n");

            }
            break;

        #endregion

        #region CASE 2 : SEARCH BY EMPLOYEE NUMBER
        case 2:
            Console.WriteLine(" Enter Employee NUmber");

            int eno= Convert.ToInt32(Console.ReadLine());
             var empByNo = (from e in Employee.eList
                          where e.empNo ==eno 
                          select e).Single();
            Console.WriteLine("--------------------------------------------------------------------\n");
            Console.WriteLine( "Employee Number : "     + empByNo.empNo);
            Console.WriteLine( "Employee Number : "     + empByNo.empName);
            Console.WriteLine( "Employee Number : "     + empByNo.empSalary);
            Console.WriteLine( "Employee Number : "     + empByNo.empDesignation);
            Console.WriteLine( "Employee Number : "     + empByNo.employeeIsPermanent);


            break;
        #endregion

        #region CASE 3 : SEARCH BY EMPLOYEE DESIGNATION
        case 3:
            Console.WriteLine("Employee designation");
            string eDesignation = Console.ReadLine();
            var empByDesignation = (from e in Employee.eList
                                    where e.empDesignation == eDesignation
                                    select e).ToList();

            foreach (var items in empByDesignation)
            {

                Console.WriteLine("--------------------------------------------------------------------\n");
                Console.WriteLine("Employee Number : " + items.empNo);
                Console.WriteLine("Employee Number : " + items.empName);
                Console.WriteLine("Employee Number : " + items.empSalary);
                Console.WriteLine("Employee Number : " + items.empDesignation);
                Console.WriteLine("Employee Number : " + items.employeeIsPermanent);
            }

            break;

        #endregion

        #region CASE 4 : EMPLOYEE DETAILS
        case 4:
            Console.WriteLine("Employee Destails");

            var totalEmp = Employee.eList.Count;
            var totalSalaryPaid = (from sal  in Employee.eList
                                   select sal.empSalary).Sum();
            var minSal = (from sal in Employee.eList
                          select sal.empSalary).Min();
            var maxSal =(from sal in Employee.eList
                         select sal.empSalary).Max();   
            var avgSal =(from sal in Employee.eList
                         select sal.empSalary).Average();

            var permanentEmp = (from e in Employee.eList
                               where e.employeeIsPermanent == true
                                select e).Count();
            var contarctOverEmp = (from e in Employee.eList
                                   where e.employeeIsPermanent == false
                                   select e).Count();

            Console.WriteLine("--------------------------------------------------------------------\n");
            Console.WriteLine(" Total Employee : " + totalEmp);
            Console.WriteLine(" Tootal Salary Paid : " + totalSalaryPaid);
            Console.WriteLine("Minimum Salary : " + minSal);
            Console.WriteLine("Maximum Salary : " + maxSal);
            Console.WriteLine("Average Salary : " + avgSal);
            Console.WriteLine("Permanent Employee : " + permanentEmp);
            Console.WriteLine("Contract is over Employee : " + contarctOverEmp);



            break;

        #endregion

        #region CASE 5 : ADD EMPLOPYEE
        case 5:
            Console.WriteLine("add new Employee");

            Employee newEmp = new Employee();
            Console.WriteLine("Enter Employee Number");
            newEmp.empNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            newEmp.empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            newEmp.empDesignation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            newEmp.empSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is Employee is Permmanent");
            newEmp.employeeIsPermanent = Convert.ToBoolean(Console.ReadLine());

            Employee.eList.Add(newEmp);
            Console.WriteLine("Employee Added to List Successfully");
            break;

        #endregion

        #region CASE 6 : UPDATE EMPLOYEE

        case 6:
            Console.WriteLine("Update an Employee");

            int empToUpdate = Convert.ToInt32(Console.ReadLine());

            var empUpdate = (from e in Employee.eList
                             where e.empNo == empToUpdate
                             select e).Single();
            Console.WriteLine("Enter the Nmae");
            empUpdate.empName = Console.ReadLine();
            Console.WriteLine("Employee Updated SUcessfully");
            // we update only name but same way can update every property

            break;
        #endregion

        #region CASE 7 : DELETE EMPLOYEE

        case 7:
            Console.WriteLine("Enter Number to Delete an EMployee");
            int empToDelete = Convert.ToInt32(Console.ReadLine());
            var empDelete = (from e in Employee.eList
                             where e.empNo == empToDelete
                             select e).Single();
            Employee.eList.Remove(empDelete);
            Console.WriteLine("Employee dELETED SUCCESSFULLY");


            break;

        #endregion

        #region CASE 8 :  THANK YOU

        case 8:
            Console.WriteLine("Thank you");
            continueApp = false;
            break;

        #endregion

        #region DEFAULT : SUCCESSFUL
        default:
            Console.WriteLine("successful");
            break;


         #endregion

    }
    Console.ReadLine();
}

