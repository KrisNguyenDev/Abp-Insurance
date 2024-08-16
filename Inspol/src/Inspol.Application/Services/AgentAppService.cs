using Inspol.Dtos.Agent;
using Inspol.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inspol.Services
{
    public class AgentAppService : ApplicationService, IAgentAppService
    {
        private readonly IRepository<Agent, Guid> _repository;

        public AgentAppService(IRepository<Agent, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<AgentDto> GetByIdAsync(Guid id)
        {
            var agent = await _repository.FindAsync(id);

            return ObjectMapper.Map<Agent, AgentDto>(agent);
        }

        public async Task<PagedResultDto<AgentDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var agents = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);
            var totalCount = await _repository.GetCountAsync();

            return new PagedResultDto<AgentDto>(
                totalCount,
                ObjectMapper.Map<List<Agent>, List<AgentDto>>(agents)
            );
        }

        public async Task<AgentDto> CreateAsync(CreateUpdateAgentDto input)
        {
            var agent = ObjectMapper.Map<CreateUpdateAgentDto, Agent>(input);
            await _repository.InsertAsync(agent);
            return ObjectMapper.Map<Agent, AgentDto>(agent);
        }

        public async Task<AgentDto> UpdateAsync(Guid id, CreateUpdateAgentDto input)
        {
            var agent = await _repository.GetAsync(id);
            ObjectMapper.Map(input, agent);
            await _repository.UpdateAsync(agent);
            return ObjectMapper.Map<Agent, AgentDto>(agent);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
