using System.Diagnostics;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace XUnitPlaying.Test;

public class BeforeAfterAttribute : BeforeAfterTestAttribute
{
    public override void Before(MethodInfo methodUnderTest)
    {
        Debug.WriteLine($"Before Method: {methodUnderTest.Name}");
    }

    public override void After(MethodInfo methodUnderTest)
    {
        Debug.WriteLine($"After Method: {methodUnderTest.Name}");
    }
}

public class UnitTest1
{
    [Fact]
    [BeforeAfter]
    public void Test1()
    {

    }
}