using System;
using System.Collections.Generic;

namespace MyFinanceHub.Model
{
    public class Debt
    {
        public int DebtId { get; set; }
        public string DebtName { get; set; } = string.Empty;
        public string DebtType { get; set; } = string.Empty;
        public decimal DebtAmount { get; set; }
        public string DebtTag { get; set; } = string.Empty;
        public DateTime DebtDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddMonths(1); // Default due date
        public string Source { get; set; } = string.Empty; // E.g., "Bank", "Friend"
        public string Status { get; set; } = string.Empty;
        public List<DebtClear> DebtClear { get; set; } = new List<DebtClear>();
    }
}

