using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Haktans.Entities
{
    // State Machine: status — Open → InProgress → PendingCRS → Closed
    // Initial: Open | Transitions: Open→InProgress[Approve], InProgress→PendingCRS[Approve], PendingCRS→Closed[Approve], PendingCRS→InProgress[Revise]
    [Table("SnagReports")]
    public class SnagReport : FullAuditedEntity<long>
    {
        [Required]
        [MaxLength(20)]
        public string AtaChapter { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        public Severity Severity { get; set; }

        [Required]
        [MaxLength(200)]
        public string ReporterName { get; set; }

        public DateTime DetectedAt { get; set; }

        [MaxLength(2000)]
        public string WorkPerformed { get; set; }

        [MaxLength(100)]
        public string CrsNumber { get; set; }

        [MaxLength(1000)]
        public string RevisionNote { get; set; }

        public Status Status { get; set; }

        public long AircraftId { get; set; }

        [ForeignKey(nameof(AircraftId))]
        public virtual Aircraft Aircraft { get; set; }

    }
}