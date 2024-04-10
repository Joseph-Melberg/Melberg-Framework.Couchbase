using Demo.Infrastructure;
using MelbergFramework.Application;
using MelbergFramework.Infrastructure.Couchbase;

namespace Demo;

public class AppRegistrator : Registrator
{
    public override void RegisterServices(IServiceCollection services)
    {
        CouchbaseModule.RegisterCouchbaseBucket<IDemoCouchbaseRepository,DemoCouchbaseRepository>(services);
    }
}
