using Swashbuckle.AspNetCore.Filters;

namespace API.Examples
{
    public class TicketRequestExample:IExamplesProvider<TicketRequest>
    {
        public TicketRequest GetExamples()
        {
            return new TicketRequest()
            {
                EventName = "Endava's best employees",
                Owner = "Endava LTD"
            };
        }
    }
}
