using RupanugaCoreServices.SharedModels;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedInterface
{
    public interface IGuestInfoService:IBaseService
    {
        GuestInfo GetGuestInfoByID(int guestInfoID);
        List<GuestInfo> GetAll();

        GuestInfo Register(GuestInfo guest);

        GuestInfo GetGuestByFirstLastName(string fName, string lName);
    }
}
