using System;

namespace InsuranceClaim.Models
{
    public class BirthdayMessageModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}
