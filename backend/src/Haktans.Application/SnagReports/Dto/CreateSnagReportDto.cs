using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace Haktans.SnagReports.Dto
{
    [AutoMapTo(typeof(Entities.SnagReport))]
    public class CreateSnagReportDto
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

        public int Severity { get; set; }

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

        public int Status { get; set; }

        public long AircraftId { get; set; }

    }
}