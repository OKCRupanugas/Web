using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class GuestInfo
    {
        public GuestInfo()
        {
            CommitteeMembers = new HashSet<CommitteeMembers>();
            Donations = new HashSet<Donations>();
            Expense = new HashSet<Expense>();
        }

        public int GuestInfoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? AddressId { get; set; }
        public DateTime? Dob { get; set; }
        public short? Age { get; set; }
        public bool Active { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; }
        public ICollection<CommitteeMembers> CommitteeMembers { get; set; }
        public ICollection<Donations> Donations { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<GuestInfoServiceType> GuestInfoServiceTypes { get; set; }
    }
}
