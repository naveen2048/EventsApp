using System;
using System.Collections.Generic;
using System.Text;
using  EventInfo.Data;

namespace EventInfo.Data.Repository
{
    public interface IEventInfoRepository
    {
        void CreateEvent(EventInfo info);
        int UpdateEvent(EventInfo info);
        EventInfo GetEventInfo(int eventId);
        int DeleteEvent(int eventId);
        EventTicket GetEventTickets(int eventId);
        List<EventInfo> GetAllEventsByCountry(int countryId);
        List<EventInfo> GetAllEventsByType(int eventTypeId);
    }
}
