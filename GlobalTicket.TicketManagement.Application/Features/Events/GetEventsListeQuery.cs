using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListeQuery : IRequest<List<EventListVm>>
    {
    }
}
