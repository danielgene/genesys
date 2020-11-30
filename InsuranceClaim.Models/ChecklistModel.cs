using System.Collections.Generic;

namespace InsuranceClaim.Models
{


    public class ChecklistModel
    {
        public int Id { get; set; }
        public string ChecklistDetail { get; set; }

        public List<RegisterClaimViewModel> checklistData { get; set; }

        public bool IsChecked { get; set; }

    }
    //public class ChecklistModel
    //{
    //    public int Id { get; set; }
    //    public string ChecklistDetail { get; set; }

    //    public bool IsChecked { get; set; }

    //}
}
