using System.ComponentModel.DataAnnotations;


namespace InsuranceClaim.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        [Display(Name = "Provider Type")]
        [Required(ErrorMessage = "Please Enter BranchName")]
        public string BranchName { get; set; }

        public string AlmId { get; set; }
    }
}
