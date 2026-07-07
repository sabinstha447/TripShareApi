namespace TripShare.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string EmailAddress { get; set; }

        public string UserIdentification { get; set; } = string.Empty;

        // Makes a collection of Trip for the User
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}
