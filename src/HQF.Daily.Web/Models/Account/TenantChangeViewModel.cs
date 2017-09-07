using Abp.AutoMapper;
using HQF.Daily.Sessions.Dto;

namespace HQF.Daily.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}