using Demo.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Features;

public partial class CouchTest
{
    private string RetrievedValue = string.Empty;
    private async Task Write()
    {
        var thing = GetClass<IDemoCouchbaseRepository>();
        await thing.Upsert("Hello");
    }

    private async Task Read()
    {
        var thing = GetClass<IDemoCouchbaseRepository>();
        RetrievedValue = await thing.Get();
    }

    private async Task AssertWasWritten()
    {
        Assert.AreEqual("Hello",RetrievedValue);
    }
}
