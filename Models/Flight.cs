namespace FlightTracker.Models
{
    public class Flight
    {
        public string Carrier { get; set; }
        public string FlightNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Scheduled { get; set; }
        public string Expected { get; set; }
        public string Status { get; set; }
    }
}