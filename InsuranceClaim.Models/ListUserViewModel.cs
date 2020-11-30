using System.Collections.Generic;


namespace InsuranceClaim.Models
{
    public class ListUserViewModel
    {
        public List<CustomerModel> ListUsers { get; set; }

    }
    public class DataClass
    {
        public List<ListUserViewModel> Listuser { get; set; }

    }
}
