using System.Threading.Tasks;
using Abp.Application.Services;
using HQF.Daily.Sessions.Dto;

namespace HQF.Daily.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
