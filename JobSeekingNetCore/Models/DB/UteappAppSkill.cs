using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DB
{
    public partial class UteappAppSkill
    {
        public int RecId { get; set; }
        public string CandidateCode { get; set; }
        public string SkillId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public virtual UteappApplicant CandidateCodeNavigation { get; set; }
        public virtual UtelsSkill Skill { get; set; }
    }
}
