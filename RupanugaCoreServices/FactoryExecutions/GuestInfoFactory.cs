using RupanugaCoreServices.FactoryContracts;
using RupanugaCoreServices.SharedModels;
using System.Linq;

namespace RupanugaCoreServices.FactoryExecutions
{
    public class GuestInfoFactory : Factory<RupanugaOKCDBContext, GuestInfo>, IGuestInfoFactory
    {       
        public GuestInfo GetSingleGuestInfo(int GuestInfoID) => GetAll().FirstOrDefault(guestInfo => guestInfo.GuestInfoId == GuestInfoID);

        public GuestInfo GetGuestByFirstLastName(string fName, string lName)=> GetAll().FirstOrDefault(guest => guest.FirstName == fName && guest.LastName == lName);

    }
}
