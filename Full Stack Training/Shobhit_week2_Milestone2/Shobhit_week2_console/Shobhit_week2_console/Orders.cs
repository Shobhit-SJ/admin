using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shobhit_week2_console
{
    internal class Orders
    {
        public int oId { get; set; }
        public int cId { get; set; }
        public int pId { get; set; }
        public string oStatus { get; set; }

        public static List<Orders> OrdersList = new List<Orders>();

        public List<Orders> GetOrderBYCusId(int id)
        {

            string url = $"https://localhost:7157/api/Orders/by-customer?cid={customerId}";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if (postResult.IsSuccessStatusCode)
            {
                OrdersList = postResult.Content.ReadAsAsync<List<Orders>>().Result.ToList();

                return OrdersList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }
    }
}
