using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.ViewModels
{
    public class GuestInfoServiceTypeViewModel
    {
        public int GuestInfoServiceTypeId { get; set; }
        public int GuestInfoId { get; set; }
        public int ServiceTypeId { get; set; }
        public GuestInfoViewModel GuestInfo { get; set; }
        public ServiceTypeViewModel ServiceType { get; set; }
    }
}
