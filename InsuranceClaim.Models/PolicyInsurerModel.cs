using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Models
{
    public class PolicyInsurerModel
    {
        public int Id { get; set; }
        [Display(Name = "Insurer Name")]
        [Required(ErrorMessage = "Please Enter Insurer Name.")]
        public string InsurerName { get; set; }
        [Display(Name = "Insurer Code")]
        [Required(ErrorMessage = "Please Enter Insurer Code.")]
        public string InsurerCode { get; set; }
        [Display(Name = "Insurer Address")]
        [Required(ErrorMessage = "Please Enter Insurer Address.")]
        public string InsurerAddress { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

    }
}