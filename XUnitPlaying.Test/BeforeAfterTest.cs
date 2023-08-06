using System;
using System.Diagnostics;
using System.Reflection;
using Xunit.Sdk;

namespace XUnitPlaying.Test;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
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