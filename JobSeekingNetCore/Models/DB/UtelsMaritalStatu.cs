using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DB
{
    public partial class UtelsMaritalStatu
    {
        public UtelsMaritalStatu()
        {
            UteappApplicants = new HashSet<UteappApplicant>();
        }

        public int RecId { get; set; }
        public string MaritalStatusId { get; set; }
        public string MaritalStatusName { get; set; }
        public string MaritalStatusName2 { get; set; }

        public virtual ICollection<UteappApplicant> UteappApplicants { get; set; }
    }
}
