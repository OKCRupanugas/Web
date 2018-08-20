using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Messages
    {
        public int MessageId { get; set; }
        public int MessageTypeId { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageStartDate { get; set; }
        public DateTime MessageEndDate { get; set; }
    }
}
