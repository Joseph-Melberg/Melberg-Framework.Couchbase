using LightBDD.Framework.Scenarios;
using LightBDD.MsTest3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Features;

[TestClass]
public partial class CouchTest : BaseTestFrame
{
    [Scenario]
    [TestMethod]
    public async Task Verify_read_and_write()
    {
        await Runner.RunScenarioAsync(
                _ => Write(),
                _ => Read(),
                _ => AssertWasWritten()
                );
    }

}
