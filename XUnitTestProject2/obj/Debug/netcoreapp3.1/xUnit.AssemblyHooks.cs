// <auto-generated />
using System.CodeDom.Compiler;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::XUnitTestProject2_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.4.31")]
public class XUnitTestProject2_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    public XUnitTestProject2_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(XUnitTestProject2_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}
