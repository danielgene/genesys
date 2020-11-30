using System;

namespace Insurance.Domain.Domain
{
    public class ServiceProviderPaymentHistory : Entity<ServiceProviderPaymentHistory>
    {
        public int Id { get; set; }
        public int ClaimRegistrationId { get; set; }
        public int RegistrationDetialProviderId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
