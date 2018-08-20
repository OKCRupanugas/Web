using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class MediaType
    {
        public MediaType()
        {
            MediaNavigation = new HashSet<Media>();
        }

        public short MediaTypeId { get; set; }
        public string Media { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Media> MediaNavigation { get; set; }
    }
}
