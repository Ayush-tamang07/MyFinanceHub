using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string TransactionName { get; set; } = string.Empty;
        public string TransactionType { get; set; } = string.Empty;
        public string TransactionLabel { get; set; } = string.Empty;
        public decimal TransactionAmount { get; set; }
        public string TransactionDescription { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
