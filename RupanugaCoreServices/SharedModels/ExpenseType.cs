using System;
using System.Collections.Generic;

namespace RupanugaCoreServices.SharedModels
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            Expense = new HashSet<Expense>();
        }

        public short ExpenseTypeId { get; set; }
        public string ExpenseName { get; set; }

        public ICollection<Expense> Expense { get; set; }
    }
}
