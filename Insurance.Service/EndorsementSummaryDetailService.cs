using Insurance.Domain;
using System;

namespace Insurance.Service
{
    public class EndorsementSummaryDetailService
    {
        public VehicleDetail GetVehicleInformation(int vehicleId)
        {
            var vehicle = InsuranceContext.VehicleDetails.Single(vehicleId);
            return vehicle;
        }

        public Int32 getNewDebitNote()
        {
            var vehicle = InsuranceContext.EndorsementSummaryDetails.Max("id");

            if (vehicle != null)
            {
                return Convert.ToInt32(vehicle) + 1;
            }
            else
            {
                return 1;
            }

        }
    }
}
