using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class DonationType
    {
        public DonationType()
        {
            Donations = new HashSet<Donations>();
        }

        public short DonationTypeId { get; set; }
        public string DonationTypeDescription { get; set; }

        public ICollection<Donations> Donations { get; set; }
    }
}
