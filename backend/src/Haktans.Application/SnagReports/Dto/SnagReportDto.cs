using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Haktans.SnagReports.Dto
{
    [AutoMapFrom(typeof(Entities.SnagReport))]
    public class SnagReportDto : EntityDto<long>
    {
        public string AtaChapter { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Severity { get; set; }

        public string ReporterName { get; set; }

        public DateTime DetectedAt { get; set; }

        public string WorkPerformed { get; set; }

        public string CrsNumber { get; set; }

        public string RevisionNote { get; set; }

        public int Status { get; set; }

        /// <summary>
        /// String form of the status — used by flow conditions (triggerData.statusName equals "PendingX").
        /// </summary>
        public string StatusName { get; set; }

        public long AircraftId { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

    }
}