using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RupanugaCoreServices.SharedService
{
   public class GuestInfoService : BaseService, IGuestInfoService
    {
        IGuestInfoFactory guestInfoFactory;
        public GuestInfoService(IGuestInfoFactory _guestInfoFactory)
        {
            guestInfoFactory = _guestInfoFactory;
        }
        public GuestInfo GetGuestInfoByID(int guestInfoID) => guestInfoFactory.GetSingleGuestInfo(guestInfoID);

        public List<GuestInfo> GetAll() => guestInfoFactory.GetAll().ToList();

        public GuestInfo Register(GuestInfo guest)
        {
            guestInfoFactory.Add(guest);
            guestInfoFactory.Save();
            var gst = GetGuestByFirstLastName(guest.FirstName, guest.LastName);
            return gst;
        }

        public GuestInfo GetGuestByFirstLastName(string fName, string lName) => guestInfoFactory.GetGuestByFirstLastName(fName, lName);
       
    }
}
