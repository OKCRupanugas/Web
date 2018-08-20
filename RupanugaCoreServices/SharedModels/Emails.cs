using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Emails
    {
        public Emails()
        {
            Enquiry = new HashSet<Enquiry>();
        }

        public int EmaiIid { get; set; }
        public string Emailbody { get; set; }
        public string Subject { get; set; }
        public DateTime DateSent { get; set; }
        public string Bcc { get; set; }
        public string Cc { get; set; }
        public int? EnquiryId { get; set; }
        public short Status { get; set; }

        public ICollection<Enquiry> Enquiry { get; set; }
    }
}
