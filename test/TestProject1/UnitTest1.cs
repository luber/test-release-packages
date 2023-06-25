using FluentAssertions;
using test_release_packages;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1.GetString("Test").Should().Be("Test2Test");
    }
}