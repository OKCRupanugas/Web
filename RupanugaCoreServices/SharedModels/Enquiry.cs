using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Enquiry
    {
        public int EnquiryId { get; set; }
        public string FromEmail { get; set; }
        public DateTime EnquiryDate { get; set; }
        public string Subject { get; set; }
        public string EnquiryDesc { get; set; }
        public bool IsReplied { get; set; }
        public int? RepliedEmailId { get; set; }
        public short? EnquiryTypeId { get; set; }

        public EnquiryType EnquiryType { get; set; }
        public Emails RepliedEmail { get; set; }
    }
}
