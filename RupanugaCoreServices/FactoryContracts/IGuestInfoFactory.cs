using RupanugaCoreServices.SharedModels;

namespace RupanugaCoreServices.FactoryContracts
{
    public interface IGuestInfoFactory : IFactory<GuestInfo>
    {
        GuestInfo GetSingleGuestInfo(int GuestInfoID);
        GuestInfo GetGuestByFirstLastName(string fName, string lName);
    }
}
