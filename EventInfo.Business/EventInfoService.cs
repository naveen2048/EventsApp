using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventInfo.Data;
using EventInfo.Data.Entities;
using  EventInfo.Business.Dtos;
namespace EventInfo.Business.Services
{
    public class EventInfoService : IEventInfoService
    {
        private EventsDBContext _dbContext;
        private IAutoMapper _mapper;
        public EventInfoService(EventsDBContext dbContext, IAutoMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void CreateEvent(EventDto info)
        {
            var eventEntity = _mapper.Map<EventDto, Event>(info);
            _dbContext.Event.Add(eventEntity);
            _dbContext.SaveChanges();
        }

        public void UpdateEvent(EventDto info)
        {
            var eventEntity = _mapper.Map<EventDto, Event>(info);
            _dbContext.Update(eventEntity);
            _dbContext.SaveChanges();
        }

        public EventDto GetEvent(int eventId)
        {
            var eventEntity = _dbContext.Event.FirstOrDefault(x=>x.Id==eventId);
            return _mapper.Map<Event, EventDto>(eventEntity);
        }

        public IEnumerable<EventDto> GetAllEvents()
        {
            var events = _dbContext.Event;
            return _mapper.Map<IEnumerable<Event>, IEnumerable<EventDto>>(events);
        }

        public void DeleteEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public EventTicket GetEventTickets(int eventId)
        {
            throw new NotImplementedException();
        }

        public List<EventDto> GetAllEventsByCountry(int countryId)
        {
            var events = _dbContext.Event.Where(x=>x.Country==countryId);
            return _mapper.Map<IEnumerable<Event>, List<EventDto>>(events);
        }

        public List<EventDto> GetAllEventsByType(int eventTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
