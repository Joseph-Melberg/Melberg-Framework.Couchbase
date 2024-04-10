using Couchbase;
using MelbergFramework.Infrastructure.Couchbase;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockBucketFactory : IBucketFactory
{
    private readonly MockBucket _bucket;
    public MockBucketFactory(MockBucket bucket)
    {
        _bucket = bucket;
    }
    public IBucket GetBucket() => _bucket;
}
