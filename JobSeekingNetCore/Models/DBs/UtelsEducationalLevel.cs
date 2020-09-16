using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UtelsEducationalLevel
    {
        public UtelsEducationalLevel()
        {
            UteappApplicants = new HashSet<UteappApplicant>();
        }

        public int RecId { get; set; }
        public string EducationalLevelId { get; set; }
        public string EducationalLevelName { get; set; }
        public string EducationalLevelName2 { get; set; }

        public virtual ICollection<UteappApplicant> UteappApplicants { get; set; }
    }
}
