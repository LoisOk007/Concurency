using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuleTestAsync;
using Nito.AsyncEx;

[TestMethod]
void SmthAsync_False()
{
    AsyncContext.Run(async () =>
    {
        var value = new Sata(5);
        bool results = await value.IsCountTwo();
        Assert.IsFalse(results);
    });
}
