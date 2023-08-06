using System.Threading.Tasks;
using Xunit;

namespace XUnitPlaying.Test;

//[Collection("test")]
public class UnitTest2
{
    [Fact]
    [BeforeAfter]
    public async Task Test2()
    {
        Assert.True("test".Equals("test"));
        await Task.Delay(3000);
    }
}