using ArcheryStats.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ArcheryStats.Models
{
    public class PracticeStatistics : EntityBase
    {
        [DataMember]
        [Required]
        public DateTime PracticeDate { get; set; }

        [DataMember]
        [Required]
        public int NumberOfShots { get; set; }

        [DataMember]
        public int WhiteHits { get; set; }

        [DataMember]
        public int BlackHits { get; set; }

        [DataMember]
        public int BlueHits { get; set; }

        [DataMember]
        public int RedHits { get; set; }

        [DataMember]
        public int YellowHits { get; set; }
    }
}
