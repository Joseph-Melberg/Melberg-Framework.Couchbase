using Couchbase.Diagnostics;

namespace MelbergFramework.ComponentTesting.Couchbase;

public class MockPingReport : IPingReport
{
    public string Id => "id";

    public short Version => 1;

    public ulong ConfigRev => 2;

    public string Sdk => "test";

    public IDictionary<string, IEnumerable<IEndpointDiagnostics>> Services => new Dictionary<string, IEnumerable<IEndpointDiagnostics>>();
}
