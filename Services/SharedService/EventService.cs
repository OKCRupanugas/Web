﻿using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedInterface;

namespace RupanugaCoreServices.SharedService
{
    public class EventService : BaseService, IEventService
    {
        IEventFactory eventFactory;
        public EventService(IEventFactory _eventFactory)
        {
            eventFactory = _eventFactory;
        }

        public Events GetEventByID(int eventID) => eventFactory.GetSingleEvent(eventID);

    }
}
