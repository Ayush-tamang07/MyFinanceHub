using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class Debt
    {
        public int DebtId { get; set; }
        public string DebtName { get; set; } = string.Empty;
        public string DebtType {  get; set; } = string.Empty ;
        public decimal DebtAmount { get; set; }
        public string DebtTag { get; set; } = string.Empty;
        public DateTime DebtDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = string.Empty;
        public List<DebtClear> DebtClear { get; set; } = new List<DebtClear>();
    }
}
