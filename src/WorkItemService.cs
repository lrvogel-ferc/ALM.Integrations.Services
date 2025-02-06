
using ALM.Integrations.Services.Apis;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace ALM.Integrations.Services;

/// <summary>
/// Actions to perform against WorkItems
/// </summary>
public class WorkItemService : BaseService
{
    public Task CreateWorkItem(string workItemId)
    {
        return Task.CompletedTask;
    }

    private readonly AtmsWebApi api;

    public WorkItemService(ILogger logger, IConfiguration configuration,
        IMemoryCache memoryCache, XrmService xrmService,
        AtmsWebApi atmsWebApi) 
        : base(logger, configuration, memoryCache)
    {
        api = atmsWebApi;
    }
}