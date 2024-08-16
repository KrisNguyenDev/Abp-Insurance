using AutoMapper;
using Inspol.Dtos.Agent;
using Inspol.Entity;

namespace Inspol;

public class InspolApplicationAutoMapperProfile : Profile
{
    public InspolApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Agent, AgentDto>();
        CreateMap<CreateUpdateAgentDto, Agent>();
    }
}
