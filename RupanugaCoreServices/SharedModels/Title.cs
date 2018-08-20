using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Title
    {
        public Title()
        {
            CommitteeMembers = new HashSet<CommitteeMembers>();
        }

        public short TitleId { get; set; }
        public string TitleName { get; set; }
        public string Description { get; set; }

        public ICollection<CommitteeMembers> CommitteeMembers { get; set; }
    }
}
