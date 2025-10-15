using Xunit;

namespace CSharpTests;

public class MathTests
{
    [Fact]
    public void Suma_Correcta()
    {
        Assert.Equal(4, 2 + 2);
    }
}
