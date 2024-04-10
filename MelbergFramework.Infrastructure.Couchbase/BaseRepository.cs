using Couchbase.KeyValue;
using Couchbase.Management.Collections;

namespace MelbergFramework.Infrastructure.Couchbase;

public class BaseRepository
{
    public ICouchbaseCollection Collection {get; private set;}
    
    public BaseRepository(string name, IBucketFactory factory)
    {
        var collectionTask = SetupAsync(name, factory);
        collectionTask.Wait();
        Collection = collectionTask.Result;
    }
    
    private async Task<ICouchbaseCollection> SetupAsync(string name, IBucketFactory factory)
    {
        var bucket = factory.GetBucket();
        try
        {
            await bucket.Collections.CreateCollectionAsync("_default",name,CreateCollectionSettings.Default);
        }
        catch (CollectionExistsException) { }
        return await bucket.CollectionAsync(name);
    }
    

}
