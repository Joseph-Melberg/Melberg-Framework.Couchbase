using MelbergFramework.Infrastructure.Couchbase;

namespace Demo.Infrastructure;

public interface IDemoCouchbaseRepository
{
    Task Test();
    Task Upsert(string value);
    Task Remove();
    Task<string> Get();
}

public class DemoCouchbaseRepository : BaseRepository, IDemoCouchbaseRepository
{
    public DemoCouchbaseRepository(IBucketFactory factory) : base("test", factory)
    {

    }

    public async Task<string> Get()
    {
        return (await Collection.GetAsync("testing")).ContentAs<string>();
    }

    public async Task Test()
    {
        await Collection.UpsertAsync("testing", "b");
    }

    public async Task Upsert(string value)
    {
        await Collection.UpsertAsync("testing", value);
    }

    public async Task Remove()
    {
        await Collection.RemoveAsync("testing");
    }
}
