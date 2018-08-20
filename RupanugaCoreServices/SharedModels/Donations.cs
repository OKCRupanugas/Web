using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Donations
    {
        public int DonationId { get; set; }
        public decimal? Amount { get; set; }
        public string TransRefNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? GuestInfoId { get; set; }
        public bool IsAnonymus { get; set; }
        public short DonationTypeId { get; set; }
        public int? AddressId { get; set; }
        public string Comments { get; set; }

        public Address Address { get; set; }
        public DonationType DonationType { get; set; }
        public GuestInfo GuestInfo { get; set; }
    }
}
