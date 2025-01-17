using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class DebtClear
    {
        public int DebtClearId { get; set; }
        public decimal DebtClearAmount { get; set; }
        public string DebtClearType { get; set; } = string.Empty;
        public DateTime DebtClearDate { get; set; } = DateTime.Now;
    }
}


