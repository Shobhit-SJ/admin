////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");



//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        using (HttpClient client = new HttpClient())
//        {
//            client.BaseAddress = new Uri("http://localhost:5000/api/");

//            while (true)
//            {
//                Console.WriteLine("Select an option:");
//                Console.WriteLine("1. View all products");
//                Console.WriteLine("2. Search product by range (e.g., between 500 and 900)");
//                Console.WriteLine("3. View order by customer Id");
//                Console.WriteLine("4. View all the orders in progress");
//                Console.WriteLine("5. Exit");

//                var choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        await ViewAllProducts(client);
//                        break;
//                    case "2":
//                        await SearchProductByRange(client);
//                        break;
//                    case "3":
//                        await ViewOrderByCustomerId(client);
//                        break;
//                    case "4":
//                        await ViewOrdersInProgress(client);
//                        break;
//                    case "5":
//                        return;
//                    default:
//                        Console.WriteLine("Invalid choice. Please try again.");
//                        break;
//                }
//            }
//        }
//    }

//    static async Task ViewAllProducts(HttpClient client)
//    {
//        var response = await client.GetAsync("products");
//        var products = await response.Content.ReadAsStringAsync();
//        Console.WriteLine(products);
//    }

//    static async Task SearchProductByRange(HttpClient client)
//    {
//        Console.Write("Enter minimum price: ");
//        var minPrice = Console.ReadLine();
//        Console.Write("Enter maximum price: ");
//        var maxPrice = Console.ReadLine();

//        var response = await client.GetAsync($"products/price-range?minPrice={minPrice}&maxPrice={maxPrice}");
//        var products = await response.Content.ReadAsStringAsync();
//        Console.WriteLine(products);
//    }

//    static async Task ViewOrderByCustomerId(HttpClient client)
//    {
//        Console.Write("Enter customer Id: ");
//        var customerId = Console.ReadLine();

//        var response = await client.GetAsync($"orders/by-customer/{customerId}");
//        var orders = await response.Content.ReadAsStringAsync();
//        Console.WriteLine(orders);
//    }

//    static async Task ViewOrdersInProgress(HttpClient client)
//    {
//        var response = await client.GetAsync("orders/in-progress");
//        var orders = await response.Content.ReadAsStringAsync();
//        Console.WriteLine(orders);
//    }
//}

using Shobhit_week2_console;
Console.WriteLine("Hello, World!");




bool continueApp = true;

while (continueApp)
{

    #region Menu
    Console.Clear();
    Console.WriteLine(" Employee Management System");
    Console.WriteLine("1.Product List");
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
        case 1:
            Console.WriteLine("product list is below ");
            Products allP = new Products();
            
            var allProduct = allP.GetAllProducData();
            foreach (var item in allProduct)
            {
                Console.WriteLine(item.pId);
                Console.WriteLine(item.pName);
                Console.WriteLine(item.pPrice);
                Console.WriteLine(item.pDescription);
                Console.WriteLine(item.pIsInStock);
                Console.WriteLine(item.pAvailableQty);
                Console.WriteLine("--------------------------------------------------------------------\n");

            }
            break;

        #endregion
        #region CASE 1 : LIST EMPLOYEE
        case 2:
            Console.WriteLine("product list is below ");
            Products p = new Products();
            int f = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            var allProductrange = p.GetProducData(f, t);
            foreach (var item in allProductrange)
            {
                Console.WriteLine(item.pId);
                Console.WriteLine(item.pName);
                Console.WriteLine(item.pPrice);
                Console.WriteLine(item.pDescription);
                Console.WriteLine(item.pIsInStock);
                Console.WriteLine(item.pAvailableQty);
                Console.WriteLine("--------------------------------------------------------------------\n");

            }
            break;

        #endregion
        #region CASE 3 : Order by cus id
        case 3:
            Console.WriteLine("Order by customerId list is below ");
            Orders o = new Orders();
            int id  = Convert.ToInt32(Console.ReadLine());
            
            var ordersbyCusId = o.GetOrderBYCusId(id);
            foreach (var item in ordersbyCusId)
            {
                Console.WriteLine(item.oId);
                Console.WriteLine(item.cId);
                Console.WriteLine(item.pId);
                Console.WriteLine(item.oStatus);
                
                Console.WriteLine("--------------------------------------------------------------------\n");

            }
            break;

        #endregion

        //#region CASE 2 : SEARCH BY EMPLOYEE NUMBER

        //Console.WriteLine("product list is below ");
        //Products p = new Products();
        //int f = Convert.ToInt32(Console.ReadLine());
        //int t = Convert.ToInt32(Console.ReadLine());
        //var allProduct = p.GetProductData(f, t);
        //foreach (var item in allProduct)
        //{
        //    Console.WriteLine(item.pId);
        //    Console.WriteLine(item.pName);
        //    Console.WriteLine(item.pPrice);
        //    Console.WriteLine(item.pDescription);
        //    Console.WriteLine(item.pIsInStock);
        //    Console.WriteLine(item.pAvailableQty);
        //    Console.WriteLine("--------------------------------------------------------------------\n");

        //}
        //break;

        //#endregion

        //#region CASE 3 : SEARCH BY EMPLOYEE DESIGNATION
        //case 3:
        //    Console.WriteLine("Employee designation");
        //    string eDesignation = Console.ReadLine();
        //    var empByDesignation = (from e in Employee.eList
        //                            where e.empDesignation == eDesignation
        //                            select e).ToList();

        //    foreach (var items in empByDesignation)
        //    {

        //        Console.WriteLine("--------------------------------------------------------------------\n");
        //        Console.WriteLine("Employee Number : " + items.empNo);
        //        Console.WriteLine("Employee Number : " + items.empName);
        //        Console.WriteLine("Employee Number : " + items.empSalary);
        //        Console.WriteLine("Employee Number : " + items.empDesignation);
        //        Console.WriteLine("Employee Number : " + items.employeeIsPermanent);
        //    }

        //    break;

        //#endregion

        //#region CASE 4 : EMPLOYEE DETAILS
        //case 4:
        //    Console.WriteLine("Employee Destails");

        //    var totalEmp = Employee.eList.Count;
        //    var totalSalaryPaid = (from sal in Employee.eList
        //                           select sal.empSalary).Sum();
        //    var minSal = (from sal in Employee.eList
        //                  select sal.empSalary).Min();
        //    var maxSal = (from sal in Employee.eList
        //                  select sal.empSalary).Max();
        //    var avgSal = (from sal in Employee.eList
        //                  select sal.empSalary).Average();

        //    var permanentEmp = (from e in Employee.eList
        //                        where e.employeeIsPermanent == true
        //                        select e).Count();
        //    var contarctOverEmp = (from e in Employee.eList
        //                           where e.employeeIsPermanent == false
        //                           select e).Count();

        //    Console.WriteLine("--------------------------------------------------------------------\n");
        //    Console.WriteLine(" Total Employee : " + totalEmp);
        //    Console.WriteLine(" Tootal Salary Paid : " + totalSalaryPaid);
        //    Console.WriteLine("Minimum Salary : " + minSal);
        //    Console.WriteLine("Maximum Salary : " + maxSal);
        //    Console.WriteLine("Average Salary : " + avgSal);
        //    Console.WriteLine("Permanent Employee : " + permanentEmp);
        //    Console.WriteLine("Contract is over Employee : " + contarctOverEmp);



        //    break;

        //#endregion

        //#region CASE 5 : ADD EMPLOPYEE
        //case 5:
        //    Console.WriteLine("add new Employee");

        //    Employee newEmp = new Employee();
        //    Console.WriteLine("Enter Employee Number");
        //    newEmp.empNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Employee Name");
        //    newEmp.empName = Console.ReadLine();
        //    Console.WriteLine("Enter Employee Designation");
        //    newEmp.empDesignation = Console.ReadLine();
        //    Console.WriteLine("Enter Employee Salary");
        //    newEmp.empSalary = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Is Employee is Permmanent");
        //    newEmp.employeeIsPermanent = Convert.ToBoolean(Console.ReadLine());

        //    Employee.eList.Add(newEmp);
        //    Console.WriteLine("Employee Added to List Successfully");
        //    break;

        //#endregion

        //#region CASE 6 : UPDATE EMPLOYEE

        //case 6:
        //    Console.WriteLine("Update an Employee");

        //    int empToUpdate = Convert.ToInt32(Console.ReadLine());

        //    var empUpdate = (from e in Employee.eList
        //                     where e.empNo == empToUpdate
        //                     select e).Single();
        //    Console.WriteLine("Enter the Nmae");
        //    empUpdate.empName = Console.ReadLine();
        //    Console.WriteLine("Employee Updated SUcessfully");
        //    // we update only name but same way can update every property

        //    break;
        //#endregion

        //#region CASE 7 : DELETE EMPLOYEE

        //case 7:
        //    Console.WriteLine("Enter Number to Delete an EMployee");
        //    int empToDelete = Convert.ToInt32(Console.ReadLine());
        //    var empDelete = (from e in Employee.eList
        //                     where e.empNo == empToDelete
        //                     select e).Single();
        //    Employee.eList.Remove(empDelete);
        //    Console.WriteLine("Employee dELETED SUCCESSFULLY");


        //    break;

        //#endregion

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
