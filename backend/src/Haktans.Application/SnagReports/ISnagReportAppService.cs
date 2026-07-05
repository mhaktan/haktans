using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Haktans.SnagReports.Dto;

namespace Haktans.SnagReports
{
    public interface ISnagReportAppService : IAsyncCrudAppService<
        SnagReportDto,
        long,
        PagedSnagReportResultRequestDto,
        CreateSnagReportDto,
        SnagReportDto>
    {
        Task<SnagReportDto> ChangeStatusAsync(long id, ChangeStatusInput input);
    }
}
