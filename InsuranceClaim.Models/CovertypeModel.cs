using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Models
{
    public class CovertypeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
