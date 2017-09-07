using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HQF.Daily.Configuration.Dto;

namespace HQF.Daily.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DailyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
