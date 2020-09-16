﻿using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UtelsMajor
    {
        public UtelsMajor()
        {
            UteappAppEducations = new HashSet<UteappAppEducation>();
        }

        public int RecId { get; set; }
        public string MajorsId { get; set; }
        public string MajorsName { get; set; }
        public string MajorsName2 { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<UteappAppEducation> UteappAppEducations { get; set; }
    }
}
