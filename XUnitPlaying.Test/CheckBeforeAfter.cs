using System.Threading.Tasks;
using Xunit;

namespace XUnitPlaying.Test;

public class CheckBeforeAfter
{
    //[Fact, Trait("type", "unit")]
    //[BeforeAfter]
    public async Task Test1()
    {
        Assert.True("test".Equals("test"));
        await Task.Delay(2000);
    }
}
