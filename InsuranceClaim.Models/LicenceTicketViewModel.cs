using System;
using System.Collections.Generic;

namespace InsuranceClaim.Models
{
    public class LicenceTicketViewModel
    {

        public int Id { get; set; }
        public string TicketNo { get; set; }
        public string PolicyNumber { get; set; }
        public int VehicleId { get; set; }
        public bool IsClosed { get; set; }
        public string Comments { get; set; }
        public string DeliveredTo { get; set; }

        public string CloseComments { get; set; }
        public string ReopenComments { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyBy { get; set; }
    }

    public class ListLicenceTickets
    {
        public List<LicenceTicketViewModel> LicenceTickets { get; set; }
    }
}
