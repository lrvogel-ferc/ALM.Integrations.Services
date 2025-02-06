using ALM.Integrations.Common.Constants;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace ALM.Integrations.Services;


/// <summary>
/// The service for managing Dataverse connectivity and queries
/// </summary>
public class XrmService : BaseService
{
    public async Task<EntityCollection> Query(QueryExpression query)
    {
        var collection = await client.RetrieveMultipleAsync(query);
        return collection;
    }

    public async Task<EntityCollection> FetchXml(FetchExpression fetch)
    {
        var collection = await client.RetrieveMultipleAsync(fetch);
        return collection;
    }

    private readonly ServiceClient client;
    public XrmService(ILogger<XrmService> logger, IConfiguration configuration, IMemoryCache memoryCache) 
        : base(logger, configuration, memoryCache)
    {
        client = new ServiceClient(ConfigKeys.DataverseUrl, logger);
    }
}
