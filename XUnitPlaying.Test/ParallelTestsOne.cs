using System.Threading.Tasks;
using Xunit;

namespace XUnitPlaying.Test;

public class ParallelTestsOne
{
    [Fact]
    public async Task Test1()
    {
        await Task.Delay(2000);
    }
}