using Inspol.Dtos.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inspol.Services
{
    public interface IAgentAppService : IApplicationService
    {
        Task<AgentDto> GetAsync(Guid id);
        Task<PagedResultDto<AgentDto>> GetListAsync(PagedAndSortedResultRequestDto input);
        Task<AgentDto> CreateAsync(CreateUpdateAgentDto input);
        Task<AgentDto> UpdateAsync(Guid id, CreateUpdateAgentDto input);
        Task DeleteAsync(Guid id);
    }
}
