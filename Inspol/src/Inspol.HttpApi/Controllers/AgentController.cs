using Inspol.Dtos.Agent;
using Inspol.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Inspol.Controllers
{
    [Route("api/agents")]
    public class AgentController : AbpController
    {
        private readonly IAgentAppService _agentAppService;

        public AgentController(IAgentAppService agentAppService)
        {
            _agentAppService = agentAppService;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync([FromQuery] PagedAndSortedResultRequestDto input)
        {
            var agents = await _agentAppService.GetListAsync(input);
            return Ok(agents);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id)
        {
            var agent = await _agentAppService.GetAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }
            return Ok(agent);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateUpdateAgentDto input)
        {
            var agent = await _agentAppService.CreateAsync(input);
            return CreatedAtAction(nameof(GetAsync), new { id = agent.Id }, agent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] CreateUpdateAgentDto input)
        {
            var agent = await _agentAppService.GetAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }

            return Ok(agent);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            var agent = await _agentAppService.GetAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }
            await _agentAppService.DeleteAsync(id);
            return NoContent();
        }
    }
}
