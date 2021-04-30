using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesWithEvents
{
    public class GetCategoriesListWithEventsQuery:IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
   
}
