using Microsoft.EntityFrameworkCore;
using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RupanugaCoreServices.FactoryExecutions
{
    public class GuestInfoServiceTypeFactory : Factory<RupanugaOKCDBContext, GuestInfoServiceType>, IGuestInfoServiceTypeFactory
    {
        public GuestInfoServiceType GetSingleGuestInfoServiceType(int guestInfoServiceTypeID) => GetAll().FirstOrDefault(guestInfoServiceType => guestInfoServiceType.GuestInfoServiceTypeId == guestInfoServiceTypeID);

        public List<GuestInfoServiceType> GetGuestInfoServiceTypes()
        {
            using (var factory = new RupanugaOKCDBContext())
            {
                var result = factory.GuestInfoServiceType
                                .Include(gustInfoType => gustInfoType.GuestInfo)
                                .Include(gustInfoType => gustInfoType.ServiceType).ToList();

                return result;
            }
        }
        
    }
}
