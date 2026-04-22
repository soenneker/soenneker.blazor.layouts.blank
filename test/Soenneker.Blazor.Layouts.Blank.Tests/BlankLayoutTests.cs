using Soenneker.Tests.HostedUnit;

namespace Soenneker.Blazor.Layouts.Blank.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class BlankLayoutTests : HostedUnitTest
{

    public BlankLayoutTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
