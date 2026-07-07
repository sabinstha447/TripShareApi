namespace TripShare.API.DTOs
{
    public class UserRegisterDto
    {
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;

        public string UserIdentification { get; set; } = string.Empty;
    }
}
