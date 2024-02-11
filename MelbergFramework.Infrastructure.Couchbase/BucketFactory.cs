using Couchbase;
using Couchbase.KeyValue;
using Couchbase.Management.Buckets;
using Couchbase.Management.Collections;
using MelbergFramework.Infrastructure.Couchbase.Configuration;
using Microsoft.Extensions.Options;

namespace MelbergFramework.Infrastructure.Couchbase;

public interface IBucketFactory
{
    IBucket GetBucket();
}

public class BucketFactory : IBucketFactory
{
    private readonly ICluster _cluster;
    private readonly IBucket _bucket;
    public BucketFactory(IOptions<BucketFactoryOptions> options) 
    {
        var clusterTask = Cluster.ConnectAsync(
            options.Value.Url,
            options.Value.Username,
            options.Value.Password);
        clusterTask.Wait();
        _cluster = clusterTask.Result;
        MakeBucket(options.Value).Wait();
        
        var bucketTask = GetBucketSync(options.Value.Bucket);
        bucketTask.Wait();
        
        _bucket = bucketTask.Result;

    }
    private async Task MakeBucket(BucketFactoryOptions options)
    {
        
        var bucketSettings = new BucketSettings
        {
            Name = options.Bucket,
            RamQuotaMB = options.RamQuotaMB,
            NumReplicas = 0,
            BucketType = BucketType.Couchbase, 

        };
        try
        {
            await _cluster.Buckets.CreateBucketAsync(bucketSettings,CreateBucketOptions.Default);
        }
        catch (BucketExistsException) { }
    }
    private async Task<IBucket> GetBucketSync(string name)
    {
        return await _cluster.BucketAsync(name);
    }

    public IBucket GetBucket() => _bucket;

}