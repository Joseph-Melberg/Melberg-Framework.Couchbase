using Couchbase.Management.Buckets;
using Couchbase.Management.Collections;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockCouchbaseCollectionsManager : ICouchbaseCollectionManager
{
    public Task CreateCollectionAsync(string scopeName, string collectionName, CreateCollectionSettings settings, CreateCollectionOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task CreateCollectionAsync(CollectionSpec spec, CreateCollectionOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task CreateScopeAsync(ScopeSpec spec, CreateScopeOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task CreateScopeAsync(string scopeName, CreateScopeOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task DropCollectionAsync(string scopeName, string collectionName, DropCollectionOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task DropCollectionAsync(CollectionSpec spec, DropCollectionOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task DropScopeAsync(string scopeName, DropScopeOptions? options = null)
    {
        return Task.CompletedTask;
    }

    public Task<IEnumerable<ScopeSpec>> GetAllScopesAsync(GetAllScopesOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<ScopeSpec> GetScopeAsync(string scopeName, GetScopeOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCollectionAsync(string scopeName, string collectionName, UpdateCollectionSettings settings, UpdateCollectionOptions? options = null)
    {
        return Task.CompletedTask;
    }
}
