using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class EnquiryType
    {
        public EnquiryType()
        {
            Enquiry = new HashSet<Enquiry>();
        }

        public short EnquiryTypeId { get; set; }
        public string EnquiryType1 { get; set; }

        public ICollection<Enquiry> Enquiry { get; set; }
    }
}
