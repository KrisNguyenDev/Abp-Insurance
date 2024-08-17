using Inspol.Dtos.Agent;
using Inspol.Permissions;
using Inspol.Services;
using Microsoft.AspNetCore.Authorization;
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
using Volo.Abp.Authorization;
using Volo.Abp.Users;

namespace Inspol.Controllers
{
    [Route("api/agents")]
    public class AgentController : AbpController
    {
        private readonly IAgentAppService _agentAppService;
        private readonly IAuthorizationService _authorizationService;
        private readonly ICurrentUser _currentUser;

        public AgentController(IAgentAppService agentAppService, IAuthorizationService authorizationService, ICurrentUser currentUser)
        {
            _agentAppService = agentAppService;
            _authorizationService = authorizationService;
            _currentUser = currentUser;
        }


        [HttpGet]
        [Authorize(InspolPermissions.Agents.Default)]
        public async Task<IActionResult> GetListAsync([FromQuery] PagedAndSortedResultRequestDto input)
        {
            if (_currentUser.IsAuthenticated)
            {
                return Ok(new
                {
                    _currentUser.Id,
                    _currentUser.UserName,
                    _currentUser.Email,
                    _currentUser.Name,
                    _currentUser.SurName
                });
            }

            var agents = await _agentAppService.GetAllAsync(input);
            return Ok(agents);
        }

        [HttpGet("{id}")]
        [Authorize(InspolPermissions.Agents.Default)]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id)
        {
            var agent = await _agentAppService.GetByIdAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }
            return Ok(agent);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateUpdateAgentDto input)
        {
            await _authorizationService.CheckAsync(InspolPermissions.Agents.Create);

            var agent = await _agentAppService.CreateAsync(input);
            return CreatedAtAction(nameof(GetAsync), new { id = agent.Id }, agent);
        }

        [HttpPut("{id}")]
        [Authorize(InspolPermissions.Agents.Edit)]
        public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] CreateUpdateAgentDto input)
        {
            var agent = await _agentAppService.GetByIdAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }

            return Ok(agent);
        }

        [HttpDelete("{id}")]
        [Authorize(InspolPermissions.Agents.Delete)]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            var agent = await _agentAppService.GetByIdAsync(id);

            if (agent == null)
            {
                return Problem(statusCode: StatusCodes.Status404NotFound, title: "Not found");
            }
            await _agentAppService.DeleteAsync(id);
            return NoContent();
        }
    }
}
