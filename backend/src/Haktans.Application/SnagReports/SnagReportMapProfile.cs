using AutoMapper;
using Haktans.Entities;
using Haktans.SnagReports.Dto;

namespace Haktans.SnagReports
{
    public class SnagReportMapProfile : Profile
    {
        public SnagReportMapProfile()
        {
            CreateMap<SnagReport, SnagReportDto>()
                .ForMember(d => d.StatusName, o => o.MapFrom(s => s.Status.ToString()));
            CreateMap<CreateSnagReportDto, SnagReport>();
            CreateMap<SnagReportDto, SnagReport>();
        }
    }
}
