using System.Collections.Generic;

namespace Insurance.Domain
{
    public class InflationVehicleDTO
    {
        public IEnumerable<VehicleUsage> VehicleUsages { get; set; }
        public InflationFactor InflationFactor { get; set; }
    }

}
