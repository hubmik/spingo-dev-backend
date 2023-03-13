namespace DataAccess.Models
{
    public class UserDevices
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeviceString { get; set; }
        public string Hash { get; set; }
        public string Verified { get; set; }
        public int VerificationCode { get; set; }
    }
}
