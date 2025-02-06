using ALM.Integrations.Common.Constants;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace ALM.Integrations.Services.Apis;

/// <summary>
/// ATMS Web API wrapper 
/// </summary>
public class AtmsWebApi : BaseService
{


    private readonly HttpClient client;
    public AtmsWebApi(ILogger logger, IConfiguration configuration, IMemoryCache memoryCache,
        IHttpClientFactory clientFactory) 
        : base(logger, configuration, memoryCache)
    {
        client = clientFactory.CreateClient(ClientFactories.AtmsWebApi);
    }
}
