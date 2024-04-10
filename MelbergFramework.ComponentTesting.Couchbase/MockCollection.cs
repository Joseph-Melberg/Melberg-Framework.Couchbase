using Couchbase.Core.Exceptions.KeyValue;
using Couchbase.KeyValue;
using Couchbase.KeyValue.RangeScan;
using Couchbase.Management.Query;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockCollection : ICouchbaseCollection
{
    private readonly Dictionary<string,dynamic> _internal = 
        new Dictionary<string,dynamic>();
    private readonly string _name;
    public MockCollection(string name)
    {
        _name = name;
    }

    public uint? Cid => 0;

    public string Name => _name;

    public IScope Scope => throw new NotImplementedException();

    public IBinaryCollection Binary => throw new NotImplementedException();

    public bool IsDefaultCollection => true;

    public ICollectionQueryIndexManager QueryIndexes => throw new NotImplementedException();

    public Task<IExistsResult> ExistsAsync(string id, ExistsOptions? options = null)
    {
        bool exists = _internal.ContainsKey(id);
        var result = new MockExistsResult(exists, 0);
        return Task.FromResult((IExistsResult) result);
    }

    public IEnumerable<Task<IGetReplicaResult>> GetAllReplicasAsync(string id, GetAllReplicasOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IGetResult> GetAndLockAsync(string id, TimeSpan expiry, GetAndLockOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IGetResult> GetAndTouchAsync(string id, TimeSpan expiry, GetAndTouchOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IGetReplicaResult> GetAnyReplicaAsync(string id, GetAnyReplicaOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IGetResult> GetAsync(string id, GetOptions? options = null)
    {
        if(_internal.ContainsKey(id))
        {
            return Task.FromResult<IGetResult>(new MockGetResult(_internal[id]));
        }
        throw new DocumentNotFoundException();
    }

    public Task<IMutationResult> InsertAsync<T>(string id, T content, InsertOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<ILookupInReplicaResult> LookupInAllReplicasAsync(string id, IEnumerable<LookupInSpec> specs, LookupInAllReplicasOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<ILookupInReplicaResult> LookupInAnyReplicaAsync(string id, IEnumerable<LookupInSpec> specs, LookupInAnyReplicaOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<ILookupInResult> LookupInAsync(string id, IEnumerable<LookupInSpec> specs, LookupInOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IMutateInResult> MutateInAsync(string id, IEnumerable<MutateInSpec> specs, MutateInOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(string id, RemoveOptions? options = null)
    {
        if(_internal.ContainsKey(id))
        {
            _internal.Remove(id);
        }

        return Task.CompletedTask;
    }

    public Task<IMutationResult> ReplaceAsync<T>(string id, T content, ReplaceOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IScanResult> ScanAsync(IScanType scanType, ScanOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task TouchAsync(string id, TimeSpan expiry, TouchOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task UnlockAsync<T>(string id, ulong cas, UnlockOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task UnlockAsync(string id, ulong cas, UnlockOptions? options = null)
    {
        throw new NotImplementedException();
    }

    public Task<IMutationResult> UpsertAsync<T>(string id, T content, UpsertOptions? options = null)
    {
        _internal[id] = content;

        return Task.FromResult<IMutationResult>(null);
    }


}
