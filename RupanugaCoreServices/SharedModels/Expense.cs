using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class Expense
    {
        public int ExpenseId { get; set; }
        public short ExpenseTypeId { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public string SpentBy { get; set; }
        public decimal? Amount { get; set; }
        public int? GuestId { get; set; }

        public ExpenseType ExpenseType { get; set; }
        public GuestInfo Guest { get; set; }
    }
}
