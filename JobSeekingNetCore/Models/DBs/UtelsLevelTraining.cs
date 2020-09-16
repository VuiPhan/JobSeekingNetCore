﻿using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UtelsLevelTraining
    {
        public UtelsLevelTraining()
        {
            UteappAppEducations = new HashSet<UteappAppEducation>();
        }

        public int RecId { get; set; }
        public string LevelTrainingId { get; set; }
        public string LevelTrainingName { get; set; }
        public string LevelTrainingName2 { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<UteappAppEducation> UteappAppEducations { get; set; }
    }
}
