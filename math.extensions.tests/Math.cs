using Xunit;
namespace math.extensions.tests;

public class Math
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void ResturnFalseWhenNumberIsLEssThan2(int a)
    {
        Assert.False(math.extensions.Math.IsPrime(a) , $"{a} is Prime!");
    }

    [Theory]
    [InlineData(4)]
    [InlineData(111)]
    [InlineData(9)]
    [InlineData(15)]
    public void ResturnFalseWhenNotPrimeNumberGiven(int number)
    {
        Assert.False(math.extensions.Math.IsPrime(number) , $"{number} is not Prime");
    }

    [Fact]
    public void ReturnsTrueWhenGiven2()
    {
        Assert.True(math.extensions.Math.IsPrime(2) );
    }
}