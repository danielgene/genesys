using System;

namespace InsuranceClaim.Models
{
    class AspNetUsersDetailModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool PasswordExpire { get; set; }
    }
}
