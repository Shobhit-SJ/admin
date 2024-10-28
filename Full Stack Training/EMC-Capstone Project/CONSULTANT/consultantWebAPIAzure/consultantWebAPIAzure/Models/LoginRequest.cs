namespace consultantWebAPIAzure.Models
{
    public class LoginRequest
    {
        public string userName {  get; set; }
        public string userPassword {  get; set; } 

        public string userRole { get; set; }
    }
}
