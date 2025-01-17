using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class CashOut
    {
        public int CashOutId { get; set; }
        public string CashOutName { get; set; } = string.Empty;
        public string CashOutType { get; set; } = string.Empty;
        public string CashOutLabel { get; set; } = string.Empty;
        public decimal CashOutAmount { get; set; }
        public string CashOutDescription { get; set; } = string.Empty;
        public DateTime CashOutDate { get; set; } = DateTime.Now;
    }
}


