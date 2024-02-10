using Couchbase;
using MelbergFramework.Core.Health;

namespace MelbergFramework.Infrastructure.Couchbase;

public class CouchbaseHealthCheck : HealthCheck
{
    private readonly IBucket _bucket;
    public CouchbaseHealthCheck(IBucketFactory bucketFactory)
    {
        _bucket = bucketFactory.GetBucket();
    }

    public override string Name => $"couchbase";

    public override async Task<bool> IsOk(CancellationToken token) 
    {
        try
        {
            await _bucket.PingAsync(); 
        }
        catch (Exception)
        {
            return false;
        }
        
        return true;
    }
}