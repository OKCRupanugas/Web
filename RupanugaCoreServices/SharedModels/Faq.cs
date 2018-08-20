using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Faq
    {
        public short Faqid { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; }
    }
}
