﻿using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListeQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }
        public async Task<List<EventListVm>> Handle(GetEventsListeQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
