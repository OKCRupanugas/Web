using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Address
    {
        public Address()
        {
            Donations = new HashSet<Donations>();
            GuestInfo = new HashSet<GuestInfo>();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipPlus4 { get; set; }

        public ICollection<Donations> Donations { get; set; }
        public ICollection<GuestInfo> GuestInfo { get; set; }
    }
}
