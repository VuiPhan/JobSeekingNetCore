﻿using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DB
{
    public partial class UtelsFormsOfTraining
    {
        public UtelsFormsOfTraining()
        {
            UteappApplicants = new HashSet<UteappApplicant>();
        }

        public int RecId { get; set; }
        public string FormsOfTrainingId { get; set; }
        public string FormsOfTrainingName { get; set; }
        public byte? Ordinal { get; set; }

        public virtual ICollection<UteappApplicant> UteappApplicants { get; set; }
    }
}
