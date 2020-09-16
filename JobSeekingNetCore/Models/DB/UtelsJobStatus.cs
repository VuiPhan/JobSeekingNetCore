using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DB
{
    public partial class UtelsJobStatus
    {
        public UtelsJobStatus()
        {
            UteappJobInformation = new HashSet<UteappJobInformation>();
        }

        public int RecId { get; set; }
        public string JobStatusId { get; set; }
        public string JobStatusName { get; set; }
        public string JobStatusName2 { get; set; }

        public virtual ICollection<UteappJobInformation> UteappJobInformation { get; set; }
    }
}
