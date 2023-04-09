namespace DemoBlazorServerApp.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public string? OrderType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
