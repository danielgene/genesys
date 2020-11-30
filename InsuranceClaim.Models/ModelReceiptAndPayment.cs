using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaim.Models
{
    public class ModelReceiptAndPayment
    {

        public int Id { get; set; } // Auto increment
        public int policyId { get; set; } // policy reference
        public string reference { get; set; }
        public string policyNumber { get; set; } // policy reference check as invoice
        public string type { get; set; } // reciept or invoice

        public string paymentMethod { get; set; }
        public string Description { get; set; } // Description
        public decimal Amount { get; set; } // Amount - or +
        public string currency { get; set; } // currency options
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
