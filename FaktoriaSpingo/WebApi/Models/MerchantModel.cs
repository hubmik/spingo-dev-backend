namespace WebApi.Models
{
    public class MerchantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NIP { get; set; }
        public string Password { get; set; }
        public int MerchantId { get; set; }
        public int AgreementId { get; set; }
    }
}
