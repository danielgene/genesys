﻿using System;

namespace InsuranceClaim.Models
{
    public class CurrencyModel
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
