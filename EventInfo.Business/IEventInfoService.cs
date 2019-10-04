using System;
using System.Collections.Generic;
using System.Text;
using EventInfo.Business.Dtos;
using  EventInfo.Data;
using EventInfo.Data.Entities;

namespace EventInfo.Business.Services
{
    public interface IEventInfoService
    {
        void CreateEvent(EventDto info);
        void UpdateEvent(EventDto info);
        EventDto GetEvent(int eventId);
        void DeleteEvent(int eventId);
        EventTicket GetEventTickets(int eventId);
        List<EventDto> GetAllEventsByCountry(int countryId);
        List<EventDto> GetAllEventsByType(int eventTypeId);
        IEnumerable<EventDto> GetAllEvents();
    }
}
