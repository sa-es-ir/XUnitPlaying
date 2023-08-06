using System.Threading.Tasks;
using Xunit;

namespace XUnitPlaying.Test;

public class ParallelTestsTwo
{
    [Fact]
    public async Task Test2()
    {
        await Task.Delay(3000);
    }
}