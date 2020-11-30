namespace InsuranceClaim.Models
{
    public class VehicleTaxClassModel
    {
        public int Id { get; set; }
        public int TaxClassId { get; set; }
        public string Description { get; set; }
        public int VehicleType { get; set; }

        public int VehicleUsageId { get; set; }
        public string CreatedOn { get; set; }
    }



}
