using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.ViewModels
{
    public class ServiceTypeViewModel
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
