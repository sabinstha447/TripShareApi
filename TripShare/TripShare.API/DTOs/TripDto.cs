namespace TripShare.API.DTOs
{
    public class TripDto
    {
        public int TripId { get; set; }
        public string StartLocation { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;

        public DateTime TravelDate { get; set; }
        public int SeatAvailable { get; set; }
        public string Status { get; set; } = string.Empty;
        public int UserId
        {
            get; set;
        }
    }
}
