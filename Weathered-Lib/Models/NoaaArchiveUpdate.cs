using MongoDB.Bson;
using System;

namespace Weathered_Lib.Models
{
    public partial class NoaaArchiveUpdate
    {
        public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
        public string FileName { get; set; }
        public DateTime LastSiteUpdate { get; set; }
    }
}
