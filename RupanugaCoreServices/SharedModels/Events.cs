using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Events
    {
        public int Eventd { get; set; }
        public string EventName { get; set; }
        public DateTime EventTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? VaishnavaId { get; set; }
        public string Topic { get; set; }

        public Vaishnavas Vaishnava { get; set; }
    }
}
