using Couchbase;
using Couchbase.KeyValue;
using Couchbase.Management.Collections;
using Demo.Infrastructure;
using MelbergFramework.Infrastructure.Couchbase;

namespace Demo;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        CouchbaseModule.RegisterCouchbaseBucket<IDemoCouchbaseRepository,DemoCouchbaseRepository>(builder.Services);
        var app = builder.Build();
        
        var serv = app.Services.GetService<IDemoCouchbaseRepository>();
        
        await serv.Test();


        app.MapGet("/", () => "Hello World!");


        //app.Run();
    }
}