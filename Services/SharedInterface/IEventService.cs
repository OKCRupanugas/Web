﻿namespace RupanugaCoreServices.SharedInterface
{
    public interface IEventService:IBaseService
    {
        Events GetEventByID(int eventID);
    }
}
