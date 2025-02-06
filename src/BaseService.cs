using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALM.Integrations.Services;
public abstract class BaseService
{
    protected readonly ILogger log;
    protected readonly IConfiguration config;
    protected readonly IMemoryCache cache;
    public BaseService(ILogger logger, IConfiguration configuration,
        IMemoryCache memoryCache)
    {
        log = logger;
        config = configuration;
        cache = memoryCache;
    }
}
