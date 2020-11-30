using System;

namespace InsuranceClaim.Models
{
    public class BusinessSourceModel
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
