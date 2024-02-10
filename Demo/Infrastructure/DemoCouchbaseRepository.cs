using MelbergFramework.Infrastructure.Couchbase;

namespace Demo.Infrastructure;

public interface IDemoCouchbaseRepository
{
    Task Test();
}

public class DemoCouchbaseRepository : BaseRepository, IDemoCouchbaseRepository
{
    public DemoCouchbaseRepository(IBucketFactory factory) : base("test", factory)
    {

    }

    public Task Test()
    {
        return Collection.UpsertAsync("testing", new {T = "b"});
    }
}