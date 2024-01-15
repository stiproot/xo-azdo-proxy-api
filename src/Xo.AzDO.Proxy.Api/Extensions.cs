using Xo.AzDO.Engine.Extensions;
using Microsoft.Extensions.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddXoAzDOProxyApiServices(this IServiceCollection @this)
    {
        @this.AddServices();

        @this.TryAddSingleton<IManager<CloneWiReq, CloneWiResp>, CloneManager>();
        @this.TryAddSingleton<IManager<BulkCreateWiReq, BulkCreateWiResp>, BulkCreateManager>();
        @this.TryAddSingleton<IManager<CreateDashReq, CreateDashResp>, DashboardManager>();

        return @this;
    }
}
