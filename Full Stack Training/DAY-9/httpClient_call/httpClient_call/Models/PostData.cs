namespace httpClient_call.Models
{
    public class PostData
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostData> postList = new List<PostData>();

        public List<PostData> GetPostData() 
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            
            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if(postResult.IsSuccessStatusCode)
            {
                postList = postResult.Content.ReadAsAsync<List<PostData>>().Result;

               return postList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }
    }
}
