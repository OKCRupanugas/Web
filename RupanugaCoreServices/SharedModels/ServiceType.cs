using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
