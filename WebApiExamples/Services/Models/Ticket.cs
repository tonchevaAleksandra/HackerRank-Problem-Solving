namespace Endava.Internship2020.WebApiExamples.Services.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
    }
}