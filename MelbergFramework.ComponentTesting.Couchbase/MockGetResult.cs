using Couchbase.KeyValue;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockGetResult : IGetResult
{
    private dynamic _value;
    public MockGetResult(dynamic value)
    {
        _value = value;
    }
    public TimeSpan? Expiry => throw new NotImplementedException();

    public DateTime? ExpiryTime => throw new NotImplementedException();

    public ulong Cas => throw new NotImplementedException();

    public T? ContentAs<T>()
    {
        return (T) _value;
    }

    public void Dispose() { }
}
