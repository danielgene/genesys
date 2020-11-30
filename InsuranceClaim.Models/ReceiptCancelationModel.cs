using Insurance.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Models
{
    public class ReceiptCancelationModel
    {

        [Required(ErrorMessage = "Please Enter Start Date.")]
        public string FromDate { get; set; }

        [Required(ErrorMessage = "Please Enter End Date.")]
        public string EndDate { get; set; }
        public List<ReceiptAndPayment> receiptAndPayments { get; set; }
    }
}
