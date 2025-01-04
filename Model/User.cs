using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceHub.Model
{
    public class User
    {
        public int UserID { get; set; }
        public  string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime JoinedOn { get; set; } = DateTime.Now;
        public List<Transaction> Transaction { get; set; } = new List<Transaction>();
        public List<Debt> Debt { get; set; } = new List<Debt>();
        public List<CashIn> CashIn { get; set; } = new List<CashIn>();
        public List<CashOut> CashOut { get; set; } = new List<CashOut>();
    }
}
