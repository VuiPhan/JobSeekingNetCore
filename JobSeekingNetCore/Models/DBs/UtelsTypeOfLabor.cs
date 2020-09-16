﻿using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UtelsTypeOfLabor
    {
        public UtelsTypeOfLabor()
        {
            UteappJobInformations = new HashSet<UteappJobInformation>();
        }

        public int RecId { get; set; }
        public string TypeOfLaborId { get; set; }
        public string TypeOfLaborName { get; set; }
        public string TypeOfLaborName2 { get; set; }

        public virtual ICollection<UteappJobInformation> UteappJobInformations { get; set; }
    }
}
