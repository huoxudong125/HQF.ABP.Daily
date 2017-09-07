using System.Threading.Tasks;
using Abp.Application.Services;
using HQF.Daily.Configuration.Dto;

namespace HQF.Daily.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}