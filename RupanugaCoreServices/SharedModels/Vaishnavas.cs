using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Vaishnavas
    {
        public Vaishnavas()
        {
            Events = new HashSet<Events>();
        }

        public int VaishnavasId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageLoc { get; set; }
        public string Email { get; set; }
        public int? Phone { get; set; }
        public string Url { get; set; }

        public ICollection<Events> Events { get; set; }
    }
}
