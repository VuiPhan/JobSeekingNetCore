using System;
using System.Collections.Generic;

namespace JobSeekingNetCore.Models.DBs
{
    public partial class UtesysInformationDatabase
    {
        public int RecId { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
    }
}
