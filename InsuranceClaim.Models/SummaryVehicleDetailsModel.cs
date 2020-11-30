using System;

namespace InsuranceClaim.Models
{
    public class SummaryVehicleDetailsModel
    {
        public int Id { get; set; }
        public int SummaryDetailId { get; set; }
        public int VehicleDetailsId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
