using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shobhit_week2_console
{
    internal class Customer
    {
        public int cId { get; set; }
        public string cName { get; set; }
        public int cAddress { get; set; }
        public int cWalletBalance { get; set; }
        
        public static List<Customer> CustomersList = new List<Customer>();

        public List<Products> GetProducData(int from, int to)
        {

            string url = $"https://localhost:7157/api/Customers";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if (postResult.IsSuccessStatusCode)
            {
                CustomersList = postResult.Content.ReadAsAsync<List<Customer>>().Result.ToList();

                return CustomersList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }
    }
}
