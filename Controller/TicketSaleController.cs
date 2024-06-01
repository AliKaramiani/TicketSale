using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class TickeSaleController : ControllerBase
{
    private readonly ITicket _ticket;
    public TickeSaleController(ITicket ticket)
    {
        _ticket = ticket;

    }
    [HttpPost]

    public string Add(Ticket ticket)
    {
        return _ticket.Add(ticket);
    }

[HttpGet]
public List<TicketUpdate>List()
{
    return _ticket.List();
}
}
