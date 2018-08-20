using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.ViewModels
{
    public class GuestInfoViewModel
    {
        public int GuestInfoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? AddressId { get; set; }
        public DateTime? Dob { get; set; }
        public short? Age { get; set; }
        public bool Active { get; set; }

        public string Phone { get; set; }
    }
}
