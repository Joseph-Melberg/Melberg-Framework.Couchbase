using Couchbase.Core;
using Couchbase.KeyValue;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockMutationResult : IMutationResult
{
    public MutationToken MutationToken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ulong Cas => throw new NotImplementedException();
}
