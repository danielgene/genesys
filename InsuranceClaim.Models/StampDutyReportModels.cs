using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Models
{
    public class StampDutyReportModels
    {
        public string Customer_Name { get; set; }
        public string Policy_Number { get; set; }
        public string Transaction_date { get; set; }
        public decimal Premium_due { get; set; }
        public decimal Stamp_duty { get; set; }
        public string Currency { get; set; }
    }
    public class ListStampDutyReportModels
    {
        public List<StampDutyReportModels> ListStampDutyReportdata { get; set; }
    }
    public class StampDutySearchReportModels
    {
        public List<StampDutyReportModels> ListStampDutyReportdata { get; set; }
        [Required(ErrorMessage = "Please Enter Start Date.")]
        public string FromDate { get; set; }
        [Required(ErrorMessage = "Please Enter End Date.")]
        public string EndDate { get; set; }
    }
}
