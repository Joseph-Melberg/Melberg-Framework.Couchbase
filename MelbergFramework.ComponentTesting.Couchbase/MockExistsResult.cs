using Couchbase.KeyValue;

namespace MelbergFramework.ComponentTesting;

public class MockExistsResult : IExistsResult
{
    private readonly bool _exists;
    private readonly ulong _cas;
    public MockExistsResult(bool exists, ulong cas = 0)
    {
        _exists = exists;
        _cas = cas;
    }
    public bool Exists => _exists;

    public ulong Cas => _cas;
}

