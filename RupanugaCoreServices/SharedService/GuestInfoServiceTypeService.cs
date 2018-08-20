using Microsoft.EntityFrameworkCore;
using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;
using System.Collections.Generic;
using System.Linq;

namespace RupanugaCoreServices.SharedService
{
    public class GuestInfoServiceTypeService : IGuestInfoServiceTypeService
    {
        IGuestInfoServiceTypeFactory guestInfoServiceTypeFactory;
        public GuestInfoServiceTypeService(IGuestInfoServiceTypeFactory _guestInfoServiceTypeFactory)
        {
            guestInfoServiceTypeFactory = _guestInfoServiceTypeFactory;
        }

        public GuestInfoServiceType GetGuestInfoServiceTypeByID(int guestInfoServiceTypeID) => guestInfoServiceTypeFactory.GetSingleGuestInfoServiceType(guestInfoServiceTypeID);

        public List<GuestInfoServiceType> GetAll() => guestInfoServiceTypeFactory.GetAll()
                                .Include(gustInfoType => gustInfoType.GuestInfo)
                                .Include(gustInfoType => gustInfoType.ServiceType).ToList();


    }
}
