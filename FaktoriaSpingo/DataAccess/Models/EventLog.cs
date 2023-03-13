namespace DataAccess.Models
{
    public class EventLog
    {
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventCategory { get; set; }
        public string EventResult { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
