using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("a. View all products");
                Console.WriteLine("b. Search product by range (e.g., between 500 and 900)");
                Console.WriteLine("c. View order by customer Id");
                Console.WriteLine("d. View all orders in progress");
                Console.WriteLine("Q. Quit");

                string option = Console.ReadLine();
                switch (option.ToLower())
                {
                    case "a":
                        await ViewAllProducts();
                        Console.WriteLine("--------------------------------------------------------------------");

                        break;
                    case "b":
                        Console.WriteLine("Enter minimum price:");
                        var minPrice = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter maximum price:");
                        var maxPrice = decimal.Parse(Console.ReadLine());
                        await SearchProductByRange(minPrice, maxPrice);
                        Console.WriteLine("--------------------------------------------------------------------");
                        break;
                    case "c":
                        Console.WriteLine("Enter customer ID:");
                        string customerId = Console.ReadLine();
                        await ViewOrderByCustomerId(customerId);
                        Console.WriteLine("--------------------------------------------------------------------");

                        break;
                    case "d":
                        await ViewAllOrdersInProgress();
                        Console.WriteLine("--------------------------------------------------------------------");

                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static async Task ViewAllProducts()
        {
            string url = "https://localhost:7157/api/Products";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string products = await response.Content.ReadAsStringAsync();
                Console.WriteLine("All Products:");
                Console.WriteLine(products);
            }
            else
            {
                Console.WriteLine("Error fetching products");
            }
        }

        static async Task SearchProductByRange(decimal minPrice, decimal maxPrice)
        {
            string url = $"https://localhost:7157/api/Products/price-range?minPrice={minPrice}&maxPrice={maxPrice}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string products = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Products between {minPrice} and {maxPrice}:");
                Console.WriteLine(products);
            }
            else
            {
                Console.WriteLine("Error fetching products_by_range");
            }
        }

        static async Task ViewOrderByCustomerId(string customerId)
        {
            string url = $"https://localhost:7157/api/Orders/by-customer/" + customerId;  
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string order = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Order for Customer ID {customerId}:");
                Console.WriteLine(order);
            }
            else
            {
                Console.WriteLine("Error fetching order by customer_ID");
            }
        }

        static async Task ViewAllOrdersInProgress()
        {
            string url = "https://localhost:7157/api/Orders/in-progress";  
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string orders = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Orders In Progress:");
                Console.WriteLine(orders);
            }
            else
            {
                Console.WriteLine("Error fetching orders in the progress");
            }
        }
    }
}