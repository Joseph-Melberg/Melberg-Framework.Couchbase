using Demo.Infrastructure;
using MelbergFramework.Application;

namespace Demo;

internal class Program
{
    private static async Task Main(string[] args)
    {

        var host = MelbergHost
            .CreateHost<AppRegistrator>()
            .Build();

        var repo = host.Services.GetService<IDemoCouchbaseRepository>();

        await repo.Remove();
        //app.Run();
    }
}
