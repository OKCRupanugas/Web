using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class GuestInfoServiceType
    {
        public int GuestInfoServiceTypeId { get; set; }
        public int GuestInfoId { get; set; }
        public int ServiceTypeId { get; set; }
        public GuestInfo GuestInfo { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
