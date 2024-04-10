using MelbergFramework.Core.DependencyInjection;
using MelbergFramework.Infrastructure.Couchbase;
using MelbergFramework.Infrastructure.Couchbase.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MelbergFramework.ComponentTesting.Couchbase;

public static class CouchbaseComponentTestDependencyModule
{
    public static IServiceCollection OverrideCouchbaseDatabase
        (this IServiceCollection services)
    {
        return services
            .AddSingleton<MockBucket, MockBucket>()
            .AddSingleton<MockCouchbaseCollectionsManager,MockCouchbaseCollectionsManager>()
            .OverrideWithSingleton<IBucketFactory,MockBucketFactory>()
            .Configure<BucketFactoryOptions>(_ => 
            {
                _.Url = "a";
                _.Bucket = "bucket";
                _.Username = "user";
                _.Password = "pass";
                _.RamQuotaMB = 1000;
            })
            ;
    }
}
