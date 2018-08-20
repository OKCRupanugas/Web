using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class CommitteeMembers
    {
        public int CommitteeMemberId { get; set; }
        public int GuestInfoId { get; set; }
        public short TitleId { get; set; }
        public DateTime EffectiveFromDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }

        public GuestInfo GuestInfo { get; set; }
        public Title Title { get; set; }
    }
}
