using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }

        public AspNetUsers Identity { get; set; }
    }
}
