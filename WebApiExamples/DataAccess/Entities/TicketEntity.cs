namespace Endava.Internship2020.WebApiExamples.DataAccess.Entities
{
    public class TicketEntity
    {
        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
    }
}
