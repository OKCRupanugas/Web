using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RupanugaCoreServices.FactoryContracts
{
   public interface IGuestInfoServiceTypeFactory : IFactory<GuestInfoServiceType>
    {
        GuestInfoServiceType GetSingleGuestInfoServiceType(int GuestInfoServiceTypeID);
        List<GuestInfoServiceType> GetGuestInfoServiceTypes();
    }
}
