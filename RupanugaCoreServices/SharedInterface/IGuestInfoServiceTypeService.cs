using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RupanugaCoreServices.SharedInterface
{
    public interface IGuestInfoServiceTypeService
    {
        GuestInfoServiceType GetGuestInfoServiceTypeByID(int guestInfoServiceTypeID);
        List<GuestInfoServiceType> GetAll();
    }
}
