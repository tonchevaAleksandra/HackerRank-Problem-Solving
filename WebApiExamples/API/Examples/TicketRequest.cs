using System.ComponentModel.DataAnnotations;

namespace API.Examples
{
    public class TicketRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event name can not be null or empty.")]
        [MaxLength(60, ErrorMessage = "Event name can not be more than 60 symbols.")]
        public string EventName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Owner name can not be null or empty.")]
        [MaxLength(30, ErrorMessage = "Owner name can not be more than 30 symbols.")]
        public string Owner { get; set; } = string.Empty;
    }
}
