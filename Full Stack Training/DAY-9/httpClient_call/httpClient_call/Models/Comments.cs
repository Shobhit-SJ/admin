namespace httpClient_call.Models
{
    public class Comments
    {

        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        List<Comments> commentList = new List<Comments>();

        public List<Comments> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/comments";
            HttpClient client = new HttpClient();

            //this call will made by client from browser, and every browser has a default
            //data format, we will need to clear it and apply json as format

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var postResult = client.GetAsync(url).Result; //ASYNCE MEANS DOWNLOAD DATA PACKET BY PACKET eg: youtube AND SYNC MEANS FIRST DOWNLOAD ALL DATA THEN EXECUTE eg : video game


            if (postResult.IsSuccessStatusCode)
            {
                commentList = postResult.Content.ReadAsAsync<List<Comments>>().Result.ToList();

                return commentList;

            }
            else
            {
                throw new Exception("Cannot get data, please contact admin. ");
            }

        }

    }
}
