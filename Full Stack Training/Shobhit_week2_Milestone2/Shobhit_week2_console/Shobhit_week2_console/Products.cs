using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shobhit_week2_console
{
    internal class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public int pPrice { get; set; }
        public int pAvailableQty { get; set; }
        public string pDescription { get; set; }
        public bool pIsInStock { get; set; }
        public static List<Products> productList = new List<Products>();

        public List<Products> GetProducData( int from, int to)
        {

            string url = $"https://localhost:7157/api/Products/price-range?minPrice={from}&maxPrice={to}";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if (postResult.IsSuccessStatusCode)
            {
                productList = postResult.Content.ReadAsAsync<List<Products>>().Result.ToList();

                return productList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }
        public List<Products> GetAllProducData()
        {

            string url = $"https://localhost:7157/api/Products";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if (postResult.IsSuccessStatusCode)
            {
                productList = postResult.Content.ReadAsAsync<List<Products>>().Result.ToList();

                return productList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }
    }
}
