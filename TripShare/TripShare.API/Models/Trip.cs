using Microsoft.VisualBasic;

namespace TripShare.API.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string Destination { get; set; } = string.Empty;

        public DateTime TravelDate { get; set; }
        public int SeatAvailable { get; set; }
        public string Status { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User? User { get; set; }


    }
}
