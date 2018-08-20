using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Media
    {
        public int MediaId { get; set; }
        public short MediaTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public bool IsActive { get; set; }
        public string MediaLoc { get; set; }

        public MediaType MediaType { get; set; }
    }
}
