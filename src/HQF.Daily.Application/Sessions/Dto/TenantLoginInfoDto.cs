using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HQF.Daily.MultiTenancy;

namespace HQF.Daily.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}