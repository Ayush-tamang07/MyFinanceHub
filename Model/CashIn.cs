using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class CashIn
    {
        public int CashInId { get; set; }
        public string CashInName { get; set; } = string.Empty;
        public string CashInType { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string CashInDescription { get; set; } = string.Empty;
        public DateTime CashInDate { get; set; } = DateTime.Now;
    }
}





