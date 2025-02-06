using ALM.Integrations.Common.Constants;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ALM.Integrations.Services.Handlers;

/// <summary>
/// The purpose of this handler is to assign authentication header information (or anything else)
/// to the requests going out to the web API. 
/// </summary>
public class AtmsWebApiHandler : DelegatingHandler
{

    ///<inheritdoc/>
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        /*
        var keyVal = await cache.GetOrCreateAsync<string>(
            CacheKeys.AtmsWebApi, async _ =>
            {
                return string.Empty;
            });


        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",keyVal!);
        */

        return await base.SendAsync(request, cancellationToken);
    }

    private readonly ILogger log;
    private readonly IConfiguration config;
    private readonly IMemoryCache cache;
    public AtmsWebApiHandler(ILogger<AtmsWebApiHandler> logger,
        IConfiguration configuration, IMemoryCache memoryCache)
    {
        log = logger;
        config = configuration;
        cache = memoryCache;
    }
}
