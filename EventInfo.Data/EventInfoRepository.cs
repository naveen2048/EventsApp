using System;
using System.Collections.Generic;
using System.Text;

namespace EventInfo.Data.Repository
{
    public class EventInfoRepository : IEventInfoRepository
    {
        public EventInfoRepository()
        {
            
        }
        public void CreateEvent(EventInfo info)
        {
            throw new NotImplementedException();
        }

        public int DeleteEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public List<EventInfo> GetAllEventsByCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public List<EventInfo> GetAllEventsByType(int eventTypeId)
        {
            throw new NotImplementedException();
        }

        public EventInfo GetEventInfo(int eventId)
        {
            throw new NotImplementedException();
        }

        public EventTicket GetEventTickets(int eventId)
        {
            throw new NotImplementedException();
        }

        public int UpdateEvent(EventInfo info)
        {
            throw new NotImplementedException();
        }
    }
}
