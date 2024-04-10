using Couchbase;
using Couchbase.Diagnostics;
using Couchbase.KeyValue;
using Couchbase.Management.Collections;
using Couchbase.Management.Views;
using Couchbase.Views;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockBucket : IBucket
{

    private readonly IDictionary<string, MockCollection> _collections = 
        new Dictionary<string, MockCollection>();

    private readonly MockCouchbaseCollectionsManager _manager;

    public MockBucket(MockCouchbaseCollectionsManager manager)
    {
        _manager = manager;
    }

    public bool SupportsCollections => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    public ICluster Cluster => throw new NotImplementedException();

    public IViewIndexManager ViewIndexes => throw new NotImplementedException();

    public ICouchbaseCollectionManager Collections => _manager;

    public ICouchbaseCollection Collection(string collectionName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICouchbaseCollection> CollectionAsync(string collectionName)
    {
        if(!_collections.ContainsKey(collectionName))
        {
            _collections.Add(collectionName, new MockCollection(collectionName));
        }
        return ValueTask.FromResult( (ICouchbaseCollection)_collections[collectionName]);
    }

    public ICouchbaseCollection DefaultCollection()
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICouchbaseCollection> DefaultCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public IScope DefaultScope() { throw new NotImplementedException(); }

    public ValueTask<IScope> DefaultScopeAsync() { throw new NotImplementedException(); }

    public void Dispose() { }

    public ValueTask DisposeAsync() { throw new NotImplementedException(); }

    public Task<IPingReport> PingAsync(PingOptions? options = null) 
    { return Task.FromResult((IPingReport) new MockPingReport()); }

    public IScope Scope(string scopeName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IScope> ScopeAsync(string scopeName)
    {
        throw new NotImplementedException();
    }

    public Task<IViewResult<TKey, TValue>> ViewQueryAsync<TKey, TValue>(string designDocument, string viewName, ViewOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task WaitUntilReadyAsync(TimeSpan timeout, WaitUntilReadyOptions? options = null)
    {
        throw new NotImplementedException();
    }
}
