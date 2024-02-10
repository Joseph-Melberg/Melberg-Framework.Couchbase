using MelbergFramework.Core.Health;
using MelbergFramework.Infrastructure.Couchbase.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MelbergFramework.Infrastructure.Couchbase;

public static class CouchbaseModule
{
    public static void RegisterCouchbaseBucket<ITRepository, TRepository>(IServiceCollection services)  
        where ITRepository : class
        where TRepository : BaseRepository, ITRepository
    {
        services.AddOptions<BucketFactoryOptions>()
            .BindConfiguration(BucketFactoryOptions.Section)
            .ValidateDataAnnotations();
        
        services.AddSingleton<IBucketFactory,BucketFactory>();

        services.AddTransient<ITRepository,TRepository>();
        
        services.AddSingleton<IBucketFactory,BucketFactory>();
        services.AddSingleton<IHealthCheck, CouchbaseHealthCheck>();

    }

}