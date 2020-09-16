﻿using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UteworkJob
    {
        public int RecId { get; set; }
        public int JobId { get; set; }
        public string CompanyId { get; set; }
        public string ReasonsToJoin { get; set; }
        public string JobDescriptions { get; set; }
        public string JobRequirements { get; set; }
        public string LoveWorkingHere { get; set; }
    }
}
