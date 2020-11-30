using System.Collections.Generic;

namespace InsuranceClaim.Models
{
    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
        public string DisplayName { get; set; }
    }

    public class RootObject
    {
        public List<Country> countries { get; set; }
    }



}
