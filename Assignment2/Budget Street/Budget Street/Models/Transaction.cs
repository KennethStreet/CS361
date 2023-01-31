using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Street.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Charge { get; set; }
        public int Amount { get; set; }
        public DateTime ChargeDate { get; set; }
        public string Vendor { get; set; }
    }
}
